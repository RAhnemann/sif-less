using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.ServiceProcess;
using System.Windows.Forms;
using System.Xml;
using SIFLess.Model;
using SIFLess.Model.Profiles;

namespace SIFLess
{
    public partial class SolrCreateProfile : Form
    {
        private readonly SolrProfile _profile;
        public SolrCreateProfile(SolrProfile profile)
        {
            InitializeComponent();
            InitServices();

            _profile = profile;
           
            profileTextBox.Text = profile.Name;
            urlTextBox.Text = profile.Url;
            serviceComboBox.SelectedItem = profile.ServiceName;
            corePathTextBox.Text = profile.CorePath;

            validateButton.Text = "Update Profile";
        }  

        public SolrCreateProfile()
        {
            InitializeComponent();
            InitServices();
        }
        
        private void validateButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(profileTextBox.Text))
            {
                MessageBox.Show("Need a Profile Name!");
                return;
            }

            if (string.IsNullOrWhiteSpace(urlTextBox.Text))
            {
                MessageBox.Show("Enter a Url");
                return;
            }

            if (serviceComboBox.SelectedItem == null)
            {
                MessageBox.Show("Select a Service");
                return;
            }

            if (string.IsNullOrWhiteSpace(corePathTextBox.Text))
            {
                MessageBox.Show("Enter a Core Path");
                return;
            }

            //Validate
            #region Folder Check

            try
            {
                if (!Directory.Exists(corePathTextBox.Text))
                {
                    MessageBox.Show("Core Directory doesn't exist");
                    validateCoreFolderLabel.ForeColor = Color.Red;
                    return;
                }

                if (!File.Exists(Path.Combine(corePathTextBox.Text.EnsureEndsWith("\\"), "server\\solr\\solr.xml")))
                {
                    MessageBox.Show("Couldn't find solr.xml in Core Folder");
                    validateCoreFolderLabel.ForeColor = Color.Red;
                    return;
                }

                validateCoreFolderLabel.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error validating folder: " + ex.Message);
                validateCoreFolderLabel.ForeColor = Color.Red;
                return;
            }               
            #endregion
            #region Url Check
            try
            {
                if (!urlTextBox.Text.ToLower().StartsWith("https"))
                {
                    MessageBox.Show("Solr Url needs to be HTTPS");
                    validateUrlLabel.ForeColor = Color.Red;
                    return;
                }

                if (!urlTextBox.Text.ToLower().EndsWith("/solr"))
                {
                    MessageBox.Show("Solr Url should end at /solr");
                    validateUrlLabel.ForeColor = Color.Red;
                    return;
                }

                var request = WebRequest.Create(urlTextBox.Text + "/admin/info/system");

                var response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    validateUrlLabel.ForeColor = Color.Green;
                }
                else
                {
                    MessageBox.Show("Non-Ok Response in Url Check: " + response.StatusDescription);
                    validateUrlLabel.ForeColor = Color.Red;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't validate Url: " + ex.Message);
                validateUrlLabel.ForeColor = Color.Red;
                return;
            }
            #endregion

            #region Version Check
            try
            {
                var minVersion = Version.Parse("6.6.2");
                using (var client = new HttpClient())
                {
                    using (var response = client.GetAsync(urlTextBox.Text + "/admin/info/system").Result)
                    {
                        using (var content = response.Content)
                        {
                            var responseXML = content.ReadAsStringAsync().Result;

                            var responseDoc = new XmlDocument();
                            responseDoc.LoadXml(responseXML);

                            var versionNode =
                                responseDoc.SelectSingleNode("//response/lst[@name='lucene']/str[@name='solr-spec-version']");

                            var versionText = versionNode.InnerText;

                            var runningVersion = Version.Parse(versionText);

                            if (runningVersion >= minVersion)
                            {
                                validateVersionLabel.ForeColor = Color.Green;
                            }
                            else
                            {
                                validateVersionLabel.ForeColor = Color.Red;
                                MessageBox.Show("Invalid Solr Version: " + runningVersion);
                                return;
                            }
                        }
                    }
                }

                validateVersionLabel.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error validating version: " + ex.Message);
                validateVersionLabel.ForeColor = Color.Red;
                return;
            }

            #endregion

            SifLessProfiles currentProfiles = ProfileManager.Fetch();

            if (_profile == null)
            {
                SolrProfile newProfile = new SolrProfile
                {
                    Name = profileTextBox.Text,
                    Url = urlTextBox.Text,
                    ServiceName = serviceComboBox.SelectedItem.ToString(),
                    CorePath = corePathTextBox.Text,
                    Id = Guid.NewGuid()
                };

                currentProfiles.SolrProfiles.Add(newProfile);
            }
            else
            {
                var profile = currentProfiles.SolrProfiles.Find(p => p.Id == _profile.Id);

                profile.Name = profileTextBox.Text;
                profile.Url = urlTextBox.Text;
                profile.ServiceName = serviceComboBox.SelectedItem.ToString();
                profile.CorePath = corePathTextBox.Text;
            }


            ProfileManager.Update(currentProfiles);

            this.Close();

        }

        private void InitServices()
        {
            serviceComboBox.Items.Clear();

            ServiceController[] services = ServiceController.GetServices();

            foreach (var serviceController in services)
            {
                serviceComboBox.Items.Add(serviceController.ServiceName);
            }
        }

        private void setCorePathBox_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var result = solrCorePathBrowser.ShowDialog();

            if (result == DialogResult.OK)
            {
                corePathTextBox.Text = solrCorePathBrowser.SelectedPath;
            }
        }
    }
}

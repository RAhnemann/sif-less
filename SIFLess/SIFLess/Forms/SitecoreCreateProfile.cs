using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SIFLess.Model.Profiles;

namespace SIFLess
{
    public partial class SitecoreCreateProfile : Form
    {
        private readonly SitecoreProfile _profile;
        public SitecoreCreateProfile(SitecoreProfile profile)
        {
            InitializeComponent();
            InitData();

            _profile = profile;

            profileTextBox.Text = profile.Name;
            topologyList.SelectedIndex = topologyList.FindStringExact(profile.Topology);
            versionList.SelectedIndex = versionList.FindStringExact(profile.Version);
            dataRepoTextBox.Text = profile.DataFolder;

            RebuildFiles();

            validateButton.Text = "Update Profile";
        }

        public SitecoreCreateProfile()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            ConfigurationManager.AppSettings["Topologies"].Split('|').ToList().ForEach(t => topologyList.Items.Add(t));
            ConfigurationManager.AppSettings["Versions"].Split('|').ToList().ForEach(v => versionList.Items.Add(v));
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var result = repoBrowerDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                dataRepoTextBox.Text = repoBrowerDialog.SelectedPath;
            }
        }


        private void validateButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(profileTextBox.Text))
            {
                MessageBox.Show("Need a Profile Name!");
                return;
            }

            if (topologyList.SelectedItem == null)
            {
                MessageBox.Show("Select a Topology");
                return;
            }

            if (versionList.SelectedItem == null)
            {
                MessageBox.Show("Select a Version");
                return;
            }

            if (string.IsNullOrWhiteSpace(licenseFileTextBox.Text))
            {
                MessageBox.Show("Select a License File");
                return;
            }

            if (string.IsNullOrWhiteSpace(dataRepoTextBox.Text) || !Directory.Exists(dataRepoTextBox.Text))
            {
                MessageBox.Show("Invalid Data File Repo");
                return;
            }

            bool allFilesGood = true;
            foreach (var ctrl in fileGroupBox.Controls)
            {
                if (ctrl is Label lbl)
                {
                    var fullPath = Path.Combine(dataRepoTextBox.Text, lbl.Text);

                    if (File.Exists(fullPath))
                    {
                        lbl.ForeColor = Color.Green;
                    }
                    else
                    {
                        lbl.ForeColor = Color.Red;
                        allFilesGood = false;
                    }
                }
            }

            if (!allFilesGood)
            {
                MessageBox.Show("One or more required files are missing");
                return;
            }

            //Save our profile
            var currentProfiles = ProfileManager.Fetch();



            if (_profile == null)
            {
                var newProfile = new SitecoreProfile
                {
                    Name = profileTextBox.Text,
                    Topology = topologyList.SelectedItem.ToString(),
                    Version = versionList.SelectedItem.ToString(),
                    DataFolder = dataRepoTextBox.Text,
                    LicenseFile = licenseFileTextBox.Text,
                    Id = Guid.NewGuid()
                };

                foreach (var ctrl in fileGroupBox.Controls)
                {
                    if (ctrl is Label lbl)
                    {
                        newProfile.Files.Add(lbl.Text);
                    }
                }

                currentProfiles.SiteforeProfiles.Add(newProfile);

            }
            else
            {
                var profile = currentProfiles.SiteforeProfiles.Find(p => p.Id == _profile.Id);

                profile.Name = profileTextBox.Text;
                profile.Topology = topologyList.SelectedItem.ToString();
                profile.Version = versionList.SelectedItem.ToString();
                profile.DataFolder = dataRepoTextBox.Text;
                profile.LicenseFile = licenseFileTextBox.Text;

                profile.Files.Clear();

                foreach (var ctrl in fileGroupBox.Controls)
                {
                    if (ctrl is Label lbl)
                    {
                        profile.Files.Add(lbl.Text);
                    }
                }
            }

            ProfileManager.Update(currentProfiles);

            this.Close();

        }

        private void versionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RebuildFiles();
        }

        private void topologyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RebuildFiles();
        }
        
        private void RebuildFiles()
        {
            fileGroupBox.Controls.Clear();

            if (topologyList.SelectedItem == null || versionList.SelectedItem == null)
                return;

            var topology = topologyList.SelectedItem.ToString();
            var scVer = versionList.SelectedItem.ToString();
            var files = Utility.GetFilesForInstance(topology, scVer);


            var offset = 0;
            foreach (var fileName in files)
            {
                var newLabel = new Label
                {
                    Text = fileName,
                    Width = 478,
                    Left = 20,
                    Top = 20 + (21 * offset)
                };
                fileGroupBox.Controls.Add(newLabel);
                offset++;
            }
        }

        private void setLicenseLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var result = licenseSelectDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                licenseFileTextBox.Text = licenseSelectDialog.FileName;
            }
        }
    }
}

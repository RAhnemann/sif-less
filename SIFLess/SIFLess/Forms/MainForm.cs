using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows.Forms;
using Microsoft.Practices.Unity.Configuration;
using SIFLess.Controls;
using SIFLess.Model.Configuration;
using SIFLess.Model.Managers;
using SIFLess.Model.Profiles;
using Unity;
using ioFile = System.IO.File;

namespace SIFLess.Forms
{
    public partial class MainForm : Form
    {
        private readonly IProfileManager _profileManager;

        public MainForm()
        {
            InitializeComponent();

            IUnityContainer container = new UnityContainer();
            container.LoadConfiguration();

            _profileManager = container.Resolve<IProfileManager>();

            //Hiding
            mainTabControl.TabPages.Remove(instanceTab);
        }

        #region Events
        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshSitecoreProfiles();
            RefreshConnectionProfiles();
            RefreshSolrProfiles();

            this.Text = $"SIF-less v{this.ProductVersion}";
            
        }

        private void manageSitecoreProfilesLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var mgr = new SitecoreProfileManager(_profileManager);
            mgr.ShowDialog();
            RefreshSitecoreProfiles();
        }

        private void manageConnectionProfileLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var mgr = new ConnectionProfileManager(_profileManager);
            mgr.ShowDialog();
            RefreshConnectionProfiles();
        }

        private void manageSolrLinkButtonsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var mgr = new SolrProfileManager(_profileManager);
            mgr.ShowDialog();
            RefreshSolrProfiles();
        }

        private void profileListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            customFieldsGroupBox.Controls.Clear();

            if (!(profileListBox.SelectedItem is SitecoreProfile profile))
                return;

            //Load all the files for the profile
            var configuration = Utility.GetInstanceConfiguration(profile.Topology, profile.Version);

            var fields = new List<Field>();

            foreach (var file in configuration.Files)
            {
                if (file.FieldMaps != null)
                {
                    foreach (var fieldMap in file.FieldMaps.Fields)
                    {
                        if (fields.Find(f => f.Name == fieldMap.Name) == null)
                        {
                            fields.Add(fieldMap);
                        }
                    }
                }
            }

            var position = 20;
            foreach (var field in fields)
            {
                switch (field.Type.ToLower())
                {
                    case "text":
                        customFieldsGroupBox.Controls.Add(new StringControl(field.Label, field.Map, field.Description) { Top = position, Left = 20 });
                        break;
                }

                position += 25;
            }
        }

        private void generateScriptsButton_Click(object sender, EventArgs e)
        {
            //TODO: We need some validation

            var scProfile = profileListBox.SelectedItem as SitecoreProfile;
            var sqlProfile = connectionListBox.SelectedItem as SqlProfile;
            var solrProfile = solrListBox.SelectedItem as SolrProfile;

            if (scProfile == null)
            {
                MessageBox.Show("No Sitecore profile selected");
                return;
            }

            if (sqlProfile == null)
            {
                MessageBox.Show("No SQL Profile selected");
                return;
            }

            if (solrProfile == null)
            {
                MessageBox.Show("No solr profile selected");
                return;
            }

            var ps1Generated = SIFGenerator.Generate(prefixTextBox.Text, scProfile, sqlProfile, solrProfile, ExtractFieldValues());

            saveScriptDialog.FileName = $"SIFless-EZ-{(Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds}.{prefixTextBox.Text}.ps1";

            var result = saveScriptDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                var filePath = saveScriptDialog.FileName;

                ioFile.WriteAllText(filePath, ps1Generated);

                MessageBox.Show("File Saved to: " + filePath);
            }
        }
        #endregion

        #region Methods

        public void RefreshSitecoreProfiles()
        {
            profileListBox.Items.Clear();

            var currentProfiles = _profileManager.Fetch();

            currentProfiles.SitecoreProfiles?.ForEach(p => profileListBox.Items.Add(p));
        }

        public void RefreshConnectionProfiles()
        {
            connectionListBox.Items.Clear();

            var currentProfiles = _profileManager.Fetch();

            currentProfiles.SqlProfiles?.ForEach(p => connectionListBox.Items.Add(p));
        }

        public void RefreshSolrProfiles()
        {
            solrListBox.Items.Clear();

            var currentProfiles = _profileManager.Fetch();

            currentProfiles.SolrProfiles?.ForEach(p => solrListBox.Items.Add(p));
        }

        public NameValueCollection ExtractFieldValues()
        {
            var values = new NameValueCollection();

            foreach (var control in customFieldsGroupBox.Controls)
            {
                if (control is StringControl scControl)
                {
                    values.Add(scControl.FieldMap, scControl.Value);
                }
            }

            return values;
        }

        #endregion

        private void installButton_Click(object sender, EventArgs e)
        {
            //var ezText = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "EZ.ps1"));

            //var solrPath = solrURLTextBox.Text.EndsWith("/")
            //  ? solrURLTextBox.Text.Substring(0, solrURLTextBox.TextLength - 1)
            //  : solrURLTextBox.Text;
            //ezText = ezText.Replace("[SC_PREFIX]", prefixTextBox.Text);
            //ezText = ezText.Replace("[SCRIPT_ROOT]", configTextBox.Text);
            //ezText = ezText.Replace("[XCONNECT_NAME]", xConnectName.Text);
            //ezText = ezText.Replace("[SITE_NAME]", siteNameTextBox.Text);
            //ezText = ezText.Replace("[SOLR_URL]", solrPath);
            //ezText = ezText.Replace("[SOLR_FOLDER]", solrFolderTextBox.Text);
            //ezText = ezText.Replace("[SOLR_SERVICE]", solrServiceTextBox.Text);
            //ezText = ezText.Replace("[SQL_SERVER]", sqlServerTextBox.Text);
            //ezText = ezText.Replace("[SQL_USER]", sqlLoginTextBox.Text);
            //ezText = ezText.Replace("[SQL_PASSWORD]", sqlPasswordTextBox.Text);
            //ezText = ezText.Replace("[XCONNECT_PACKAGE]", xConnectPackageTextBox.Text);
            //ezText = ezText.Replace("[SITECORE_PACKAGE]", sitecorePackageTextBox.Text);
            //ezText = ezText.Replace("[LICENSE_XML]", licenseTextBox.Text);

            //var fileName = $"SIFless-EZ-{DateTimeOffset.Now.ToUnixTimeSeconds()}.ps1";
            //var fullFileName = Path.Combine(Environment.CurrentDirectory, fileName);
            //File.WriteAllText(fullFileName, ezText);


            //var ezUninstallText = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "EZ-Uninstall.ps1"));

            //ezUninstallText = ezUninstallText.Replace("[SC_PREFIX]", prefixTextBox.Text);
            //ezUninstallText = ezUninstallText.Replace("[SCRIPT_ROOT]", configTextBox.Text);
            //ezUninstallText = ezUninstallText.Replace("[XCONNECT_NAME]", xConnectName.Text);
            //ezUninstallText = ezUninstallText.Replace("[SITE_NAME]", siteNameTextBox.Text);
            //ezUninstallText = ezUninstallText.Replace("[SOLR_URL]", solrPath);
            //ezUninstallText = ezUninstallText.Replace("[SOLR_FOLDER]", solrFolderTextBox.Text);
            //ezUninstallText = ezUninstallText.Replace("[SOLR_SERVICE]", solrServiceTextBox.Text);
            //ezUninstallText = ezUninstallText.Replace("[SQL_SERVER]", sqlServerTextBox.Text);
            //ezUninstallText = ezUninstallText.Replace("[SQL_USER]", sqlLoginTextBox.Text);
            //ezUninstallText = ezUninstallText.Replace("[SQL_PASSWORD]", sqlPasswordTextBox.Text);
            //ezUninstallText = ezUninstallText.Replace("[XCONNECT_PACKAGE]", xConnectPackageTextBox.Text);
            //ezUninstallText = ezUninstallText.Replace("[SITECORE_PACKAGE]", sitecorePackageTextBox.Text);
            //ezUninstallText = ezUninstallText.Replace("[LICENSE_XML]", licenseTextBox.Text);

            //var uninstallFileName = $"SIFless-EZUninstall-{DateTimeOffset.Now.ToUnixTimeSeconds()}.ps1";
            //var fullUninstallFileName = Path.Combine(Environment.CurrentDirectory, uninstallFileName);
            //File.WriteAllText(fullUninstallFileName, ezUninstallText);

            //if (!ezGenOnlyCheckbox.Checked)
            //{
            //    var exeForm = new ExecuteForm();
            //    exeForm.Show();
            //    exeForm.Run(fullFileName);
            //}
        }

        private void runButton_Click_1(object sender, EventArgs e)
        {
            //foreach (var parameter in _parameterList.Parameters)
            //{
            //    //Find the corresponding Control
            //    var control = _controls.Find(c => c.Field == parameter.Name);

            //    if (string.IsNullOrEmpty(control?.Value))
            //    {
            //        MessageBox.Show("Missing Value: " + control.Field, "Requird Field Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }

            //    parameter.Value = control.Value;
            //}


            //var paramsListBuilder = new StringBuilder();
            //foreach (var param in _parameterList.Parameters)
            //    paramsListBuilder.AppendFormat(" -{0} {1}", param.Name, param.Value);

            //var templateText = File.ReadAllText(_configFile);

            //templateText = templateText.Replace("[CONFIG]", _configFile);
            //templateText = templateText.Replace("[PARAMS]", paramsListBuilder.ToString());

            //var configFileName = Path.GetFileNameWithoutExtension(_configFile);
            //var tempFileName = $"SIFless-{configFileName}-{DateTimeOffset.Now.ToUnixTimeSeconds()}.ps1";
            //var fullFileName = Path.Combine(Environment.CurrentDirectory, tempFileName);

            //File.WriteAllText(fullFileName, templateText);

            //if (!hcGenerateCheckbox.Checked)
            //{
            //    var exeForm = new ExecuteForm();
            //    exeForm.Show();
            //    exeForm.Run(fullFileName);
            //}
        }

    }
}

using Microsoft.Practices.Unity.Configuration;
using SIFLess.Controls;
using SIFLess.Model;
using SIFLess.Model.Configuration;
using SIFLess.Model.Managers;
using SIFLess.Model.Profiles;
using SIFLess.Model.Update;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows.Forms;
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

            Text = $"SIF-less v{ProductVersion}";

           

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

            foreach (var field in configuration.FieldSet.Fields)
            {
                if (field != null)
                {
                    fields.Add(field);
                }
            }

            var position = 20;
            foreach (var field in fields)
            {
                switch (field.Type.ToLower())
                {
                    case "text":
                        var stringControl = new StringControl(field.Label, field.Map, field.Description) { Top = position, Left = 20 };
                        stringControl.Value = field.DefaultValue.Replace("[[PREFIX]]", prefixTextBox.Text);
                        stringControl.DefaultValue = field.DefaultValue;
                        prefixTextBox.TextChanged += stringControl.Prefix_Changed;
                        customFieldsGroupBox.Controls.Add(stringControl);
                        break;
                    case "folder":
                        var folderControl = new FolderControl(field.Label, field.Map, field.Description) { Top = position, Left = 20 };
                        customFieldsGroupBox.Controls.Add(folderControl);
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


        private void runButton_Click(object sender, EventArgs e)
        {
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

                var executeForm = new Execute(filePath);
                executeForm.ShowDialog();
            }
        }
        #endregion

        #region Methods

        public void RefreshSitecoreProfiles()
        {
            profileListBox.Items.Clear();

            var currentProfiles = _profileManager.Fetch();

            currentProfiles.SitecoreProfiles?.Sort((p1, p2) => string.Compare(p1.Name, p2.Name, StringComparison.Ordinal));

            currentProfiles.SitecoreProfiles?.ForEach(p => profileListBox.Items.Add(p));

        }

        public void RefreshConnectionProfiles()
        {
            connectionListBox.Items.Clear();

            var currentProfiles = _profileManager.Fetch();

            currentProfiles.SqlProfiles?.Sort((p1, p2) => string.Compare(p1.Name, p2.Name, StringComparison.Ordinal));

            currentProfiles.SqlProfiles?.ForEach(p => connectionListBox.Items.Add(p));
        }

        public void RefreshSolrProfiles()
        {
            solrListBox.Items.Clear();

            var currentProfiles = _profileManager.Fetch();

            currentProfiles.SolrProfiles?.Sort((p1, p2) => string.Compare(p1.Name, p2.Name, StringComparison.Ordinal));

            currentProfiles.SolrProfiles?.ForEach(p => solrListBox.Items.Add(p));
        }

        public NameValueCollection ExtractFieldValues()
        {
            var values = new NameValueCollection();

            foreach (var control in customFieldsGroupBox.Controls)
            {
                if (control is IParameterControl scControl)
                {
                    values.Add(scControl.FieldMap, scControl.Value);
                }
            }

            return values;
        }

        #endregion

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var configWindow = new CheckConfigs();
            configWindow.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settingsWindow = new SettingsForm();
            settingsWindow.ShowDialog();
        }

        private void runExternalButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "This feature is still experimental.  Please only use it to run SIF-less files.  Thanks and may the odds be forever in your favor.",
                "I volunteer as tribute!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            var openResult = selectExternalScriptDialog.ShowDialog();

            if (openResult == DialogResult.OK)
            {
                var fileName = selectExternalScriptDialog.FileName;

                var executeForm = new Execute(fileName);
                executeForm.ShowDialog();
            }

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.CheckForUpdates)
            {
                var fileList = Utility.GetUpdateFiles();

                if (fileList?.Find(f => f.FileStatus == UpdateFile.Status.Missing || f.FileStatus == UpdateFile.Status.Outdated) != null)
                {
                    var showResult = MessageBox.Show("Updates are available. Would you like to view them?",
                        "Updates Available", MessageBoxButtons.YesNo);

                    if (showResult == DialogResult.Yes)
                    {
                        CheckConfigs configs = new CheckConfigs();
                        configs.ShowDialog();
                        configs.UpdateFileList();
                    }
                }
            }
        }
    }
}

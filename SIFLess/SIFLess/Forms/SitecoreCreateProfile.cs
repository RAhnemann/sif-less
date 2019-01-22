using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SIFLess.Model.Managers;
using SIFLess.Model.Profiles;
using Unity.Interception.Utilities;

namespace SIFLess
{
    public partial class SitecoreCreateProfile : Form
    {
        private SitecoreProfile _profile;
        private readonly IProfileManager _profileManager;

        private const int LABEL_WIDTH = 478;
        private const int LABEL_LEFT = 20;
        private const int LABEL_TOP_START = 20;
        private const int LABEL_TOP_OFFSET = 21;

        public SitecoreCreateProfile(IProfileManager profileManager)
        {
            _profileManager = profileManager;
            InitializeComponent();
            InitVersions();
        }

        public void SetProfile(SitecoreProfile profile)
        {
            _profile = profile;

            profileTextBox.Text = profile.Name;

            versionList.SelectedIndex = versionList.FindStringExact(profile.Version);
            topologyList.SelectedIndex = topologyList.FindStringExact(profile.Topology);
           
            dataRepoTextBox.Text = profile.DataFolder;
            licenseFileTextBox.Text = profile.LicenseFile;

            RebuildFiles();

            validateButton.Text = "Update Profile";
        }

        private void InitVersions()
        {
            var configs = Utility.GetConfigSets();
            var versions = new List<string>();
            var topologies = new List<string>();

            configs.Configurations.ForEach(c => versions.Add(c.Version));
            configs.Configurations.ForEach(t => topologies.Add(t.Topology));

            versions.Distinct().ForEach(v => versionList.Items.Add(v));
            topologies.Distinct().ForEach(t => topologyList.Items.Add(t));

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
            var currentProfiles = _profileManager.Fetch();

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

                currentProfiles.SitecoreProfiles.Add(newProfile);

            }
            else
            {
                var profile = currentProfiles.SitecoreProfiles.Find(p => p.Id == _profile.Id);

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

            _profileManager.Update(currentProfiles);

            this.Close();
        }

        private void versionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            topologyList.Items.Clear();

            //Need to rebuild the topologies available for the version selected
            var configs = Utility.GetConfigSets();

            var topologies = new List<string>();

            configs.Configurations.Where(c => c.Version == (string)versionList.SelectedItem).ForEach(t => topologies.Add(t.Topology));

            topologies.Distinct().ForEach(t => topologyList.Items.Add(t));

            topologyList.SelectedIndex = 0;

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
                    Width = LABEL_WIDTH,
                    Left = LABEL_LEFT,
                    Top = LABEL_TOP_START + (LABEL_TOP_OFFSET * offset)
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

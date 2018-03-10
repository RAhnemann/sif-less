using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using SIFLess.Model;
using SIFLess.Properties;

namespace SIFLess
{
    public partial class SitecoreCreateProfile : Form
    {
        private bool _requiresvalidation = true;

        private SitecoreProfile _profile;
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
        }

        public SitecoreCreateProfile()
        {
            InitializeComponent();
            InitData();

        }

        private void InitData()
        {
            versionList.Items.Add("9.0 Initial Release");
            versionList.Items.Add("9.0 Update 1");
            topologyList.Items.Add("XM");
            topologyList.Items.Add("XP");
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
            var profileText = Settings.Default.SitecoreProfiles;

            List<SitecoreProfile> profiles;

            if (_profile == null)
            {
                SitecoreProfile newProfile = new SitecoreProfile
                {
                    Name = profileTextBox.Text,
                    Topology = topologyList.SelectedItem.ToString(),
                    Version = versionList.SelectedItem.ToString(),
                    DataFolder = dataRepoTextBox.Text,
                    ID = Guid.NewGuid()
                };

                foreach (var ctrl in fileGroupBox.Controls)
                {
                    if (ctrl is Label lbl)
                    {
                        newProfile.Files.Add(lbl.Text);
                    }
                }

                if (string.IsNullOrWhiteSpace(profileText))
                {
                    profiles = new List<SitecoreProfile>() { newProfile };
                }
                else
                {
                    profiles = JsonConvert.DeserializeObject<List<SitecoreProfile>>(profileText);
                    profiles.Add(newProfile);
                }

            }
            else
            {
                profiles = JsonConvert.DeserializeObject<List<SitecoreProfile>>(profileText);

                var profile = profiles.Find(p => p.ID == _profile.ID);

                profile.Name = profileTextBox.Text;
                profile.Topology = topologyList.SelectedItem.ToString();
                profile.Version =versionList.SelectedItem.ToString();
                profile.DataFolder = dataRepoTextBox.Text;

                profile.Files.Clear();

                foreach (var ctrl in fileGroupBox.Controls)
                {
                    if (ctrl is Label lbl)
                    {
                        profile.Files.Add(lbl.Text);
                    }
                }
            }




            Settings.Default.SitecoreProfiles = JsonConvert.SerializeObject(profiles);
            Settings.Default.Save();
 
            this.Close();

        }

        private void versionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RequireValidation();
            RebuildFiles();
        }

        private void topologyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RequireValidation();
            RebuildFiles();
        }

        private void RequireValidation()
        {

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


    }
}

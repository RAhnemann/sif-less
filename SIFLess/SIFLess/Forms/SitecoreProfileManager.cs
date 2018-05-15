using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using SIFLess.Model;
using SIFLess.Model.Managers;
using SIFLess.Model.Profiles;
using SIFLess.Properties;

namespace SIFLess
{
    public partial class SitecoreProfileManager : Form
    {
        private readonly IProfileManager _profileManager;

        public SitecoreProfileManager(IProfileManager profileManager)
        {
            _profileManager = profileManager;
            InitializeComponent();
            RefreshList();

            var editLink = new DataGridViewLinkColumn
            {
                UseColumnTextForLinkValue = true,
                HeaderText = "Edit",
                DataPropertyName = "lnkColumn",
                LinkBehavior = LinkBehavior.SystemDefault,
                Text = "Edit"
            };

            profileGrid.Columns.Add(editLink);

            var deleteLink = new DataGridViewLinkColumn
            {
                UseColumnTextForLinkValue = true,
                HeaderText = "Delete",
                DataPropertyName = "lnkColumn",
                LinkBehavior = LinkBehavior.SystemDefault,
                Text = "Delete"
            };

            profileGrid.Columns.Add(deleteLink);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SitecoreCreateProfile profile = new SitecoreCreateProfile(_profileManager);

            profile.ShowDialog();

            RefreshList();
        }

        private void RefreshList()
        {
            var currentProfiles = _profileManager.Fetch();

            if (currentProfiles.SitecoreProfiles != null)
            {
                var bindingList = new BindingList<SitecoreProfile>(currentProfiles.SitecoreProfiles);

                profileGrid.DataSource = bindingList;
            }

        }

        private void profileGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 || e.ColumnIndex == 1)
            {
                var currentProfiles = _profileManager.Fetch();

                var scProfile = currentProfiles.SitecoreProfiles[e.RowIndex];

                //Edit
                if (e.ColumnIndex == 0)
                {
                    var profileWindow = new SitecoreCreateProfile(_profileManager);

                    profileWindow.SetProfile(scProfile);

                    profileWindow.ShowDialog();

                    RefreshList();
                }

                //Delete
                if (e.ColumnIndex == 1)
                {
                    if (MessageBox.Show($"Are you sure you wish to remove the profile '{scProfile.Name}'?", "Confirm",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        currentProfiles.SitecoreProfiles.Remove(scProfile);

                        _profileManager.Update(currentProfiles);

                        RefreshList();
                    }
                }
            }
        }
    }
}

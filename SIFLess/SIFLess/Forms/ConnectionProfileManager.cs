using System;
using System.ComponentModel;
using System.Windows.Forms;
using SIFLess.Model.Managers;
using SIFLess.Model.Profiles;

namespace SIFLess
{
    public partial class ConnectionProfileManager : Form
    {
        private readonly IProfileManager _profileManager;

        public ConnectionProfileManager(IProfileManager profileManager)
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

        private void RefreshList()
        {
            var currentProfiles = _profileManager.Fetch();

            if (currentProfiles.SqlProfiles != null)
            {
                var bindingList = new BindingList<SqlProfile>(currentProfiles.SqlProfiles);
                profileGrid.DataSource = bindingList;
            }
        }

        private void profileGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 || e.ColumnIndex == 1)
            {
                var currentProfiles = _profileManager.Fetch();

                var sqlProfile = currentProfiles.SqlProfiles[e.RowIndex];

                //Edit
                if (e.ColumnIndex == 0)
                {
                    ConnectionCreateProfile profileWindow = new ConnectionCreateProfile(_profileManager);

                    profileWindow.SetProfile(sqlProfile);

                    profileWindow.ShowDialog();

                    RefreshList();
                }

                //Delete
                if (e.ColumnIndex == 1)
                {
                    if (MessageBox.Show($"Are you sure you wish to remove the profile '{sqlProfile.Name}'?", "Confirm",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        currentProfiles.SqlProfiles.Remove(sqlProfile);

                        _profileManager.Update(currentProfiles);

                        RefreshList();
                    }
                }
            }
        }

        private void addProfileButton_Click(object sender, EventArgs e)
        {
            var profile = new ConnectionCreateProfile(_profileManager);

            profile.ShowDialog();

            RefreshList();
        }
    }
}

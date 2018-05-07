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
    public partial class ConnectionProfileManager : Form
    {
        private IProfileManager _profileManager;

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

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionCreateProfile profile = new ConnectionCreateProfile(_profileManager);

            profile.ShowDialog();

            RefreshList();
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
            }
        }
    }
}

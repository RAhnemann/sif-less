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
using SIFLess.Model.Profiles;
using SIFLess.Properties;

namespace SIFLess
{
    public partial class SitecoreProfileManager : Form
    {
        private MainForm _mainForm;

        public SitecoreProfileManager(MainForm main) : this()
        {
            _mainForm = main;
        }
        public SitecoreProfileManager()
        {
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
            SitecoreCreateProfile profile = new SitecoreCreateProfile();

            profile.ShowDialog();

            RefreshList();
        }

        private void RefreshList()
        {
            var currentProfiles = ProfileManager.Fetch();

            if (currentProfiles.SiteforeProfiles != null)
            {
                var bindingList = new BindingList<SitecoreProfile>(currentProfiles.SiteforeProfiles);

                profileGrid.DataSource = bindingList;
            }

        }

        private void profileGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 || e.ColumnIndex == 1)
            {
                var currentProfiles = ProfileManager.Fetch();

                var scProfile = currentProfiles.SiteforeProfiles[e.RowIndex];

                //Edit
                if (e.ColumnIndex == 0)
                {
                    SitecoreCreateProfile profile = new SitecoreCreateProfile(scProfile);

                    profile.ShowDialog();
                    RefreshList();
                }
            }
        }
    }
}

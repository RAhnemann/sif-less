using System;
using System.Windows.Forms;

namespace SIFLess.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            updateSettingsCheckbox.Checked = Properties.Settings.Default.CheckForUpdates;
        }

        private void updateSettingsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CheckForUpdates = updateSettingsCheckbox.Checked;
            Properties.Settings.Default.Save();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

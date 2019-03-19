using SIFLess.Model.Update;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace SIFLess.Forms
{
    public partial class CheckConfigs : Form
    {
        public CheckConfigs()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateFileList();
        }

        public void UpdateFileList()
        {
            fileCheckboxList.Items.Clear();

            var fileList = Utility.GetUpdateFiles();

            foreach (var updateFile in fileList)
            {
                fileCheckboxList.Items.Add(updateFile);
            }
        }

        private void fileCheckboxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            fixButton.Enabled = fileCheckboxList.CheckedItems.Count > 0;
        }

        public class CustomCheckListBox : CheckedListBox
        {
            protected override void OnDrawItem(DrawItemEventArgs e)
            {
                if (Items.Count == 0)
                {
                    base.OnDrawItem(e);
                    return;
                }

                var updateFile = (UpdateFile)Items[e.Index];
                var foreColor = new Color();

                switch (updateFile.FileStatus)
                {
                    case UpdateFile.Status.Outdated:
                        foreColor = Color.Orange;
                        break;
                    case UpdateFile.Status.Missing:
                        foreColor = Color.Red;
                        break;
                    case UpdateFile.Status.Current:
                        foreColor = Color.Gray;
                        break;
                    default:
                        foreColor = Color.Black;
                        break;
                }

                var newDrawItemEventArgs = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, e.Index,
                    e.State, foreColor, e.BackColor);

                base.OnDrawItem(newDrawItemEventArgs);
            }
        }

        private void fixButton_Click(object sender, EventArgs e)
        {
            foreach (var item in fileCheckboxList.CheckedItems)
            {
                var updateItem = (UpdateFile)item;

                if (updateItem == null)
                    continue;

                if (updateItem.FileStatus == UpdateFile.Status.Current)
                    continue;

                var fullFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, updateItem.Path);

                using (var webClient = new WebClient())
                {
                    //We need to replcae the unix line breaks
                    var fileContents = webClient.DownloadString(updateItem.Url);
                    fileContents = fileContents.Replace("\n", "\r\n");


                    File.WriteAllText(fullFilePath, fileContents, Encoding.UTF8);
                }
            }

            UpdateFileList();
        }
    }
}


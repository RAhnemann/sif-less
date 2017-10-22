using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIFLess.Model;

namespace SIFLess.Controls
{
    public partial class FileControl: UserControl, IParameterControl
    {
        private readonly string _fieldName;
        private readonly string _defaultValue;
        private readonly string _description;

        public FileControl()
        {
            InitializeComponent();
        }

        public string Field => _fieldName;
        public string Value => $"\"{valueTextBox.Text}\"";

        public FileControl(string fieldName, string defaultValue, string description) :this()
        {
            _fieldName = fieldName;
            _defaultValue = defaultValue;
            _description = description;

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            fieldLabel.Text = _fieldName;
            valueTextBox.Text = _defaultValue;
            fieldTip.SetToolTip(fieldLabel, _description);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            var fileResult = openFileDialog1.ShowDialog();

            if (fileResult == DialogResult.OK)
            {
                valueTextBox.Text = openFileDialog1.FileName;
            }
        }

      
    }
}

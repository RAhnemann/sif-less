using System;
using System.Windows.Forms;
using SIFLess.Model;

namespace SIFLess.Controls
{
    public partial class StringControl: UserControl, IParameterControl
    {
        private readonly string _fieldName;
        private readonly string _defaultValue;
        private readonly string _description;

        public StringControl()
        {
            InitializeComponent();
        }

        public string Value => valueTextBox.Text;
        public string Field => _fieldName;

        public StringControl(string fieldName, string defaultValue, string description) :this()
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
    }
}

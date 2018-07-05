using System;
using System.Windows.Forms;
using SIFLess.Model;

namespace SIFLess.Controls
{
    public partial class StringControl : UserControl, IParameterControl
    {
        private readonly string _description;
        private bool _isDirty;

        public StringControl()
        {
            InitializeComponent();
        }

        public string Value
        {
            get => valueTextBox.Text;
            set => valueTextBox.Text = value;
        }

        public string Field { get; }

        public string FieldMap { get; }

        public string DefaultValue { get; set; }

        public StringControl(string fieldName, string fieldMapName, string description) : this()
        {
            Field = fieldName;
            _description = description;
            FieldMap = fieldMapName;
        }

        private void StringControl_Load(object sender, EventArgs e)
        {
            fieldLabel.Text = Field;
            fieldTip.SetToolTip(fieldLabel, _description);
        }

        public void Prefix_Changed(object sender, EventArgs e)
        {
            if (!_isDirty)
            {
                if (sender is TextBox prefixBox)
                    Value = DefaultValue.Replace("[[PREFIX]]", prefixBox.Text);
            }
        }

        private void valueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            _isDirty = true;
        }
    }
}

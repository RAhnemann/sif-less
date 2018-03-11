using System;
using System.Windows.Forms;
using SIFLess.Model;

namespace SIFLess.Controls
{
    public partial class StringControl : UserControl, IParameterControl
    {
        private readonly string _description;

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

        public StringControl(string fieldName, string fieldMapName, string description) : this()
        {
            Field = fieldName;
            _description = description;
            FieldMap = fieldMapName;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            fieldLabel.Text = Field;
            fieldTip.SetToolTip(fieldLabel, _description);
        }
    }
}

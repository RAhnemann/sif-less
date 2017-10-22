using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using SIFLess.Model;

namespace SIFLess
{
    public partial class MainForm : Form
    {
        private readonly List<string> _fileParameters = new List<string> { "Package", "LicenseFile" };
        private ParameterList _parameterList;
        private List<IParameterControl> _controls;

        private string _configFile;

        public MainForm()
        {
            InitializeComponent();
        }


        private void selectFileButton_Click(object sender, EventArgs e)
        {
            var result = selectConfigDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                _configFile = selectConfigDialog.FileName;
                if (!File.Exists(_configFile))
                {
                    MessageBox.Show("Config file magically disappeared");
                }

                var cleanLines = File.ReadAllLines(_configFile).Where(line => !line.Trim().StartsWith("//")).ToArray();

                _parameterList = JsonConvert.DeserializeObject<ParameterList>(string.Join("", cleanLines));

                mainFlowPanel.Controls.Clear();
                _controls = new List<IParameterControl>();

                foreach (var parameter in _parameterList.Parameters)
                {

                    if (_fileParameters.Contains(parameter.Name))
                    {
                        var fileControl = new Controls.FileControl(parameter.Name, parameter.DefaultValue, parameter.Description);

                        mainFlowPanel.Controls.Add(fileControl);
                        _controls.Add(fileControl);
                    }
                    else
                    {
                        var stringControl = new Controls.StringControl(parameter.Name, parameter.DefaultValue, parameter.Description);

                        mainFlowPanel.Controls.Add(stringControl);
                        _controls.Add(stringControl);
                    }
                }
            }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            foreach (var parameter in _parameterList.Parameters)
            {
                //Find the corresponding Control
                var control = _controls.Find(c => c.Field == parameter.Name);

                if (string.IsNullOrEmpty(control?.Value))
                {
                    MessageBox.Show("Missing Value: " + control.Field, "Requird Field Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                parameter.Value = control.Value;
            }

            var exeForm = new ExecuteForm(_parameterList, _configFile);
            exeForm.Show(); //Show it first and THEN run it.
            exeForm.Run();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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

        private bool isEZSiteNameDirty;
        private bool isEZConnectNameDirty;
        private bool isEZDirty;

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

        private void prefixTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!isEZSiteNameDirty)
            {
                siteNameTextBox.Text = $"{prefixTextBox.Text}.sc";
            }

            if (!isEZConnectNameDirty)
            {
                xConnectName.Text = $"{prefixTextBox.Text}.xconnect";
            }
        }

        private void siteNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            isEZSiteNameDirty = true;
        }

        private void xConnectName_KeyPress(object sender, KeyPressEventArgs e)
        {
            isEZConnectNameDirty = true;
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            var parameters = new TestWindow.TestParams
            {
                LicensePath = licenseTextBox.Text,
                SitecoreConfigPath = configTextBox.Text,
                SitecorePackagePath = sitecorePackageTextBox.Text,
                xConnectPackagePath = xConnectPackageTextBox.Text,
                SolrFolder = solrFolderTextBox.Text,
                SolrURL = solrURLTextBox.Text,
                SQLLogin = sqlLoginTextBox.Text,
                SolrServiceName = solrServiceTextBox.Text,
                SQLPassword = sqlPasswordTextBox.Text,
                SQLServer = sqlServerTextBox.Text
            };

            var window = new TestWindow(parameters);
            window.Show();

            window.Run();
        }

        private void licenseFolderButton_Click(object sender, EventArgs e)
        {
            var dialogResult = ezFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                licenseTextBox.Text = ezFileDialog.FileName;
            }
        }

        private void configFolderButton_Click(object sender, EventArgs e)
        {
            var dialogResult = ezFolderDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                configTextBox.Text = ezFolderDialog.SelectedPath;
            }
        }

        private void sitecorePackage_Click(object sender, EventArgs e)
        {
            var dialogResult = ezFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                sitecorePackageTextBox.Text = ezFileDialog.FileName;
            }
        }

        private void xConnectPackageButton_Click(object sender, EventArgs e)
        {
            var dialogResult = ezFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                xConnectPackageTextBox.Text = ezFileDialog.FileName;
            }
        }

        private void solrFolderButton_Click(object sender, EventArgs e)
        {
            var dialogResult = ezFolderDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                solrFolderTextBox.Text = ezFolderDialog.SelectedPath;
            }
        }

        private void installButton_Click(object sender, EventArgs e)
        {
            var ezText = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "EZ.ps1"));

            ezText = ezText.Replace("[SC_PREFIX]", prefixTextBox.Text);
            ezText = ezText.Replace("[SCRIPT_ROOT]", configTextBox.Text);
            ezText = ezText.Replace("[XCONNECT_NAME]", xConnectName.Text);
            ezText = ezText.Replace("[SITE_NAME]", siteNameTextBox.Text);
            ezText = ezText.Replace("[SOLR_URL]", solrURLTextBox.Text);
            ezText = ezText.Replace("[SOLR_FOLDER]", solrFolderTextBox.Text);
            ezText = ezText.Replace("[SOLR_SERVICE]", solrServiceTextBox.Text);
            ezText = ezText.Replace("[SQL_SERVER]", sqlServerTextBox.Text);
            ezText = ezText.Replace("[SQL_USER]", sqlLoginTextBox.Text);
            ezText = ezText.Replace("[SQL_PASSWORD]", sqlPasswordTextBox.Text);
            ezText = ezText.Replace("[XCONNECT_PACKAGE]", xConnectPackageTextBox.Text);
            ezText = ezText.Replace("[SITECORE_PACKAGE]", sitecorePackageTextBox.Text);
            ezText = ezText.Replace("[LICENSE_XML]", licenseTextBox.Text);

            var fileName = $"SIFless-EZ-{DateTimeOffset.Now.ToUnixTimeSeconds()}.ps1";
            var fullFileName = Path.Combine(Environment.CurrentDirectory, fileName);
            File.WriteAllText(fullFileName, ezText);

            if (!ezGenOnlyCheckbox.Checked)
            {
                var exeForm = new ExecuteForm();
                exeForm.Show();
                exeForm.Run(fullFileName);
            }
        }

        private void runButton_Click_1(object sender, EventArgs e)
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


            var paramsListBuilder = new StringBuilder();
            foreach (var param in _parameterList.Parameters)
                paramsListBuilder.AppendFormat(" -{0} {1}", param.Name, param.Value);

            var templateText = File.ReadAllText(_configFile);

            templateText = templateText.Replace("[CONFIG]", _configFile);
            templateText = templateText.Replace("[PARAMS]", paramsListBuilder.ToString());

            var configFileName = Path.GetFileNameWithoutExtension(_configFile);
            var tempFileName = $"SIFless-{configFileName}-{DateTimeOffset.Now.ToUnixTimeSeconds()}.ps1";
            var fullFileName = Path.Combine(Environment.CurrentDirectory, tempFileName);

            File.WriteAllText(fullFileName, templateText);

            if (!hcGenerateCheckbox.Checked)
            {
                var exeForm = new ExecuteForm();
                exeForm.Show();
                exeForm.Run(fullFileName);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            new ToolTip().SetToolTip(licenseLabel, "Location of your license.xml file");
            new ToolTip().SetToolTip(configLabel, "The Folder containing all your json config files (e.g. xconnect-solr.json)");
            new ToolTip().SetToolTip(scPackageLabel, "The location of your Sitecore Package (Sitecore 9.0.0 rev. 171002 (OnPrem)_single.scwdp.zip)");
            new ToolTip().SetToolTip(xConnectPackageLabel, "The location of your xConnect Package (Sitecore 9.0.0 rev. 171002 (OnPrem)_xp0xconnect.scwdp.zip)");
            new ToolTip().SetToolTip(installPrefixLabel, "The prefix for this installation. Should be unique to this system.");
            new ToolTip().SetToolTip(siteNameLabel, "The Site's Name.  This will be http://<SiteName>/sitecore");
            new ToolTip().SetToolTip(xConnectSiteNameLabel, "The xConnect Site Name. This will be used to access xConnect");
            new ToolTip().SetToolTip(solrUrlLabel, "The URL to access Solr");
            new ToolTip().SetToolTip(solrFolderLabel, "The folder where Solr is installed");
            new ToolTip().SetToolTip(solrServiceLabel, "The name of the Windows Service running Solr");
            new ToolTip().SetToolTip(sqlServerLabel, "Your SQL instance name");
            new ToolTip().SetToolTip(sqlLoginLabel, "SQL Admin login");
            new ToolTip().SetToolTip(sqlPasswordLabel, "SQL Admin password");
        }
    }
}

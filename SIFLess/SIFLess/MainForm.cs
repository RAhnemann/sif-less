using Newtonsoft.Json;
using SIFLess.Model;
using SIFLess.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

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
        private readonly string _instancesListPath = Path.Combine(Environment.CurrentDirectory, "Instances.xml");

        public MainForm()
        {
            InitializeComponent();
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

          var solrPath = solrURLTextBox.Text.EndsWith("/")
            ? solrURLTextBox.Text.Substring(0, solrURLTextBox.TextLength - 1)
            : solrURLTextBox.Text;
            ezText = ezText.Replace("[SC_PREFIX]", prefixTextBox.Text);
            ezText = ezText.Replace("[SCRIPT_ROOT]", configTextBox.Text);
            ezText = ezText.Replace("[XCONNECT_NAME]", xConnectName.Text);
            ezText = ezText.Replace("[SITE_NAME]", siteNameTextBox.Text);
            ezText = ezText.Replace("[SOLR_URL]", solrPath);
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


            var ezUninstallText = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "EZ-Uninstall.ps1"));

            ezUninstallText = ezUninstallText.Replace("[SC_PREFIX]", prefixTextBox.Text);
            ezUninstallText = ezUninstallText.Replace("[SCRIPT_ROOT]", configTextBox.Text);
            ezUninstallText = ezUninstallText.Replace("[XCONNECT_NAME]", xConnectName.Text);
            ezUninstallText = ezUninstallText.Replace("[SITE_NAME]", siteNameTextBox.Text);
            ezUninstallText = ezUninstallText.Replace("[SOLR_URL]", solrPath);
            ezUninstallText = ezUninstallText.Replace("[SOLR_FOLDER]", solrFolderTextBox.Text);
            ezUninstallText = ezUninstallText.Replace("[SOLR_SERVICE]", solrServiceTextBox.Text);
            ezUninstallText = ezUninstallText.Replace("[SQL_SERVER]", sqlServerTextBox.Text);
            ezUninstallText = ezUninstallText.Replace("[SQL_USER]", sqlLoginTextBox.Text);
            ezUninstallText = ezUninstallText.Replace("[SQL_PASSWORD]", sqlPasswordTextBox.Text);
            ezUninstallText = ezUninstallText.Replace("[XCONNECT_PACKAGE]", xConnectPackageTextBox.Text);
            ezUninstallText = ezUninstallText.Replace("[SITECORE_PACKAGE]", sitecorePackageTextBox.Text);
            ezUninstallText = ezUninstallText.Replace("[LICENSE_XML]", licenseTextBox.Text);

            var uninstallFileName = $"SIFless-EZUninstall-{DateTimeOffset.Now.ToUnixTimeSeconds()}.ps1";
            var fullUninstallFileName = Path.Combine(Environment.CurrentDirectory, uninstallFileName);
            File.WriteAllText(fullUninstallFileName, ezUninstallText);

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

            if (Settings.Default.UpgradeRequired)
            {
                Settings.Default.Upgrade();
                Settings.Default.UpgradeRequired = false;
                Settings.Default.Save();
            }

            licenseTextBox.Text = Settings.Default.LicenseFilePath;
            configTextBox.Text = Settings.Default.ConfigPath;
            sitecorePackageTextBox.Text = Settings.Default.SitecorePackagePath;
            xConnectPackageTextBox.Text = Settings.Default.xConnectPackagePath;
            solrFolderTextBox.Text = Settings.Default.SolrFolder;
            solrServiceTextBox.Text = Settings.Default.SolrServiceName;
            solrURLTextBox.Text = Settings.Default.SolrUrl;

            sqlServerTextBox.Text = Settings.Default.SQLServer;
            sqlLoginTextBox.Text = Settings.Default.SQLLogin;
            sqlPasswordTextBox.Text = Settings.Default.SQLPassword;

            this.Text = $"SIF-less v{this.ProductVersion}";

            if (!File.Exists(_instancesListPath))
                File.WriteAllText(_instancesListPath, "<Instances />");

            instanceListWatcher.Path = Path.GetDirectoryName(_instancesListPath);
            instanceListWatcher.Filter = Path.GetFileName(_instancesListPath);

            //We're not quite ready for prime time on this
            tabControl1.TabPages.Remove(tabPage3);
            //LoadInstances();
        }

        private void selectFileButton_Click_1(object sender, EventArgs e)
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.LicenseFilePath = licenseTextBox.Text.Trim();
            Settings.Default.SitecorePackagePath = sitecorePackageTextBox.Text.Trim();
            Settings.Default.ConfigPath = configTextBox.Text.Trim();
            Settings.Default.SQLLogin = sqlLoginTextBox.Text.Trim();
            Settings.Default.SQLPassword = sqlPasswordTextBox.Text.Trim();
            Settings.Default.SQLServer = sqlServerTextBox.Text.Trim();
            Settings.Default.SolrFolder = solrFolderTextBox.Text.Trim();
            Settings.Default.SolrServiceName = solrServiceTextBox.Text.Trim();
            Settings.Default.SolrUrl = solrURLTextBox.Text.Trim();
            Settings.Default.xConnectPackagePath = xConnectPackageTextBox.Text.Trim();

            Settings.Default.Save();
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            try
            {
                //This guy gets chatty...
                instanceListWatcher.EnableRaisingEvents = false;

                //Let's give the modifying process a second to finish
                Thread.Sleep(1000);

                LoadInstances();
            }
            finally
            {
                instanceListWatcher.EnableRaisingEvents = true;
            }

        }

        private void LoadInstances()
        {
            instancesListBox.Items.Clear();

            var instancesDoc = new XmlDocument();

            instancesDoc.LoadXml(File.ReadAllText(_instancesListPath));

            foreach (XmlNode install in instancesDoc.SelectNodes("Instances/Instance"))
            {
                instancesListBox.Items.Add(install.Attributes["prefix"].Value);
            }

        }

        private void instancesListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDetails(instancesListBox.SelectedItem.ToString());
        }

        private void LoadDetails(string prefix)
        {

        }

        private void ezGenOnlyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ezGenOnlyCheckbox.Checked)
                installButton.Text = "Generate Files";
            else
                installButton.Text = "Generate Files and Install";

        }
    }
}

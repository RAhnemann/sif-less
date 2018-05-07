using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Management.Automation.Language;
using System.Net;
using System.Net.Http;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32;
using SIFLess.Model;

namespace SIFLess
{
    public partial class TestWindow : Form
    {
        private TestParams _parameters;

        public TestWindow(TestParams parameters) : this()
        {
            _parameters = parameters;
        }
        public TestWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Run()
        {
            CheckCondition(() => File.Exists(_parameters.LicensePath), licenseLabel);

            CheckCondition(() => File.Exists(Path.Combine(_parameters.SitecoreConfigPath, "xconnect-createcert.json")), xConnectCertJsonLabel);

            CheckCondition(() => File.Exists(Path.Combine(_parameters.SitecoreConfigPath, "xconnect-xp0.json")), xConnectXPJsonLabel);

            CheckCondition(() => File.Exists(Path.Combine(_parameters.SitecoreConfigPath, "xconnect-solr.json")), xConnectSolrJsonLabel);

            CheckCondition(() => File.Exists(Path.Combine(_parameters.SitecoreConfigPath, "sitecore-solr.json")), sitecoreSolrJsonLabel);

            CheckCondition(() => File.Exists(Path.Combine(_parameters.SitecoreConfigPath, "sitecore-xp0.json")), sitecoreXPJsonLabel);

            CheckCondition(() => File.Exists(_parameters.xConnectPackagePath), xConnectPackageLabel);

            CheckCondition(() => File.Exists(_parameters.SitecorePackagePath), sitecorePackageLabel);

            CheckCondition(() =>
            {
                var request = WebRequest.Create(_parameters.SolrURL.EnsureEndsWith("/") + "admin/info/system");

                var response = (HttpWebResponse)request.GetResponse();

                return response.StatusCode == HttpStatusCode.OK;

            }, solrURLLabel);

            CheckCondition(() => Directory.Exists(_parameters.SolrFolder), solrFolderLabel);

            CheckCondition(() => Directory.Exists(Path.Combine(_parameters.SolrFolder, @"server\solr\configsets")), solrConfigSetsLabel);

            CheckCondition(() =>
            {
                ServiceController[] scServices;
                scServices = ServiceController.GetServices();

                foreach (ServiceController scTemp in scServices)
                {
                    if (scTemp.ServiceName == _parameters.SolrServiceName)
                        return true;
                }

                return false;
            }, solrServiceLabel);

            CheckCondition(() =>
            {
                var minVersion = Version.Parse(WebConfigurationManager.AppSettings["SolrRequiredVersion"]);
                using (var client = new HttpClient())
                {
                    using (var response = client.GetAsync(_parameters.SolrURL.EnsureEndsWith("/") + "admin/info/system").Result)
                    {
                        using (var content = response.Content)
                        {
                            var responseXML = content.ReadAsStringAsync().Result;

                            var responseDoc = new XmlDocument();
                            responseDoc.LoadXml(responseXML);

                            var versionNode =
                                responseDoc.SelectSingleNode("//response/lst[@name='lucene']/str[@name='solr-spec-version']");

                            var versionText = versionNode.InnerText;

                            var runningVersion = Version.Parse(versionText);

                            return runningVersion >= minVersion;
                        }
                    }
                }

            }, solrVersionLabel);

            CheckCondition(() =>
            {
                using (var sqlConnection = new SqlConnection($"user id={_parameters.SQLLogin};password={_parameters.SQLPassword};Data Source={_parameters.SQLServer};Database=master"))
                {
                    try
                    {
                        sqlConnection.Open();

                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"SQL Error: {ex.Message}");
                        return false;
                    }
                }
            }, sqlLabel);

            CheckCondition(() =>
            {
                return Registry.LocalMachine.GetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\IIS Extensions\MSDeploy\3", "Version") != null;
                
            }, webDeployLabel);

            CheckCondition(() =>
            {
                var versionKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\PowerShell\3\PowerShellEngine");

                var installedVersion = versionKey.GetValue("PowerShellVersion").ToString();
                return Version.Parse(installedVersion) >= Version.Parse("5.1.0.0");


            }, powershellVersionLabel);

            //HACK: There's a better way to do this.
            CheckCondition(() =>
            {
                return Utility.CheckPowerShell("Get-InstalledModule SitecoreInstallFramework",
                    "Framework to install Sitecore instances");

            }, sifInstalledLabel);

            //HACK: There's a better way to do this, too.
            CheckCondition(() =>
            {
                return Utility.CheckPowerShell("Get-InstalledModule SitecoreFundamentals",
                    "PowerShell extensions for Sitecore security");
            }, sifFundLabel);
        }

        private void CheckCondition(Func<bool> condition, Label label)
        {
            label.ForeColor = Color.RoyalBlue;

            Application.DoEvents();

            try
            {
                if (condition.Invoke())
                {
                    label.Text = "✓ " + label.Text;
                    label.ForeColor = Color.DarkGreen;
                }
                else
                {
                    label.Text = "X " + label.Text;
                    label.ForeColor = Color.Red;
                }
            }
            catch 
            {
                label.Text = "X " + label.Text;
                label.ForeColor = Color.Red;
            }

            Application.DoEvents();
        }
        public class TestParams
        {
            public string LicensePath { get; set; }

            public string SitecoreConfigPath { get; set; }

            public string SitecorePackagePath { get; set; }

            public string xConnectPackagePath { get; set; }

            public string SolrURL { get; set; }

            public string SolrFolder { get; set; }
            public string SolrServiceName { get; set; }

            public string SQLServer { get; set; }

            public string SQLLogin { get; set; }

            public string SQLPassword { get; set; }
        }
    }
}

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
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                var request = WebRequest.Create(_parameters.SolrURL);

                var response = (HttpWebResponse)request.GetResponse();

                return response.StatusCode == HttpStatusCode.OK;

            }, solrURLLabel);

            CheckCondition(() => Directory.Exists(_parameters.SolrFolder), solrFolderLabel);

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
                using (var sqlConnection = new SqlConnection($"user id={_parameters.SQLLogin};password={_parameters.SQLPassword};Data Source={_parameters.SQLServer};Database=master"))
                {
                    try
                    {
                        sqlConnection.Open();

                        return true;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"SQL Error: {ex.Message}");
                        return false;
                    }
                }
            }, sqlLabel);
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
            catch (Exception ex)
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

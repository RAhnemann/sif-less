using System;
using System.Diagnostics;
using System.IO;
using System.Management.Automation;
using System.Text;
using System.Windows.Forms;

namespace SIFLess
{
    public partial class ExecuteForm : Form
    {
        private readonly ParameterList _parameterList;
        private readonly string _configFile;
        private readonly string _templatePath = Path.Combine(Environment.CurrentDirectory, "Template.ps1");

        public ExecuteForm()
        {
            InitializeComponent();
        }

        public ExecuteForm(ParameterList parameters, string configFile) : this()
        {
            _parameterList = parameters;
            _configFile = configFile;
        }
        

        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AppendTextBox), value);
                return;
            }
            textBox1.AppendText(value + "\r\n");
            Application.DoEvents();
        }

        public void Run()
        {
            //We're gonna need to grant some permissions...just for this process
            using (var psInst = PowerShell.Create())
            {
                psInst.AddScript("Set-ExecutionPolicy -Scope Process -ExecutionPolicy Unrestricted");
                psInst.Invoke();
            }

            var paramsListBuilder = new StringBuilder();
            foreach (var param in _parameterList.Parameters)
                paramsListBuilder.AppendFormat(" -{0} {1}", param.Name, param.Value);

            var templateText = File.ReadAllText(_templatePath);

            templateText = templateText.Replace("[CONFIG]", _configFile);
            templateText = templateText.Replace("[PARAMS]", paramsListBuilder.ToString());

            var configFileName = Path.GetFileNameWithoutExtension(_configFile);
            var tempFileName = $"{configFileName}-{DateTimeOffset.Now.ToUnixTimeSeconds()}.ps1";
            var fullFileName = Path.Combine(Environment.CurrentDirectory, tempFileName);

            File.WriteAllText(fullFileName, templateText);

            var pInfo = new ProcessStartInfo("powershell.exe");
            pInfo.WorkingDirectory = Environment.CurrentDirectory;
            pInfo.UseShellExecute = false;
            pInfo.RedirectStandardOutput = true;
            pInfo.RedirectStandardError = true;
            pInfo.CreateNoWindow = true;
            pInfo.Arguments = "-file " + fullFileName;

            var p = new Process();
            p.StartInfo = pInfo;
            p.OutputDataReceived += (senderOD, args) => AppendTextBox(args.Data);
            p.ErrorDataReceived += (senderOD, args) => AppendTextBox(args.Data);
            p.Start();

            p.BeginOutputReadLine();
            p.BeginErrorReadLine();

            while (!p.HasExited)
            {
               
                Application.DoEvents();
            }

            if (p.ExitCode != 0)
            {
                MessageBox.Show("Something went wrong. Check the log files:", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Done running!");
            }
        }

    }
}

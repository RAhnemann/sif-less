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
       
        public ExecuteForm()
        {
            InitializeComponent();
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

        public void Run(string fileName)
        {
            //We're gonna need to grant some permissions...just for this process
            using (var psInst = PowerShell.Create())
            {
                psInst.AddScript("Set-ExecutionPolicy -Scope Process -ExecutionPolicy Unrestricted");
                psInst.Invoke();
            }

            var pInfo = new ProcessStartInfo("powershell.exe");
            pInfo.WorkingDirectory = Environment.CurrentDirectory;
            pInfo.UseShellExecute = false;
            pInfo.RedirectStandardOutput = true;
            pInfo.RedirectStandardError = true;
            pInfo.CreateNoWindow = true;
            pInfo.Arguments = "-file " + fileName;

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
                MessageBox.Show("Something went wrong. Check the log files", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Done executing: " + fileName);
            }
        }

    }
}

using System;
using System.Collections.ObjectModel;
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
            DateTime start = DateTime.Now;

            //We're gonna need to grant some permissions...just for this process
            using (var psInst = PowerShell.Create())
            {
                psInst.AddScript("Set-ExecutionPolicy -Scope Process -ExecutionPolicy Unrestricted");
                psInst.Invoke();


                PSDataCollection<PSObject> output = new PSDataCollection<PSObject>();
                output.DataAdded += (sender, args) =>
                {
                    var psData = (PSDataCollection<PSObject>)sender;

                    var results = psData.ReadAll();

                    foreach (var result in results)
                    {
                        AppendTextBox(result.ToString());
                    }
                };

                // Invoke the pipeline asynchronously.
                IAsyncResult asyncResult = psInst.BeginInvoke<PSObject, PSObject>(null, output);
            }
            TimeSpan elapsed = DateTime.Now.Subtract(start);

            MessageBox.Show($"Done executing in {elapsed.ToReadableString()}");

        }

    }
}

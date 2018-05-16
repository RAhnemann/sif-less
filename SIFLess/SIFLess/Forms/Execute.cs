using System;
using System.Drawing;
using System.Management.Automation;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIFLess.Forms
{
    public partial class Execute : Form
    {

        public Execute()
        {
            InitializeComponent();
        }


        public void AddError(string value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AddError), value);
                return;
            }

            errorTextbox.Text += value;
            allOutputTextbox.AppendText(value, Color.Red);

            Application.DoEvents();
        }

        public void AddWarning(string value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AddWarning), value);
                return;
            }

            warningTextbox.AppendText(value, Color.Gold);
            allOutputTextbox.AppendText(value, Color.Gold);

            Application.DoEvents();
        }


        public void AddInfo(string value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AddInfo), value);
                return;
            }

            infoTextbox.Text += value;
            allOutputTextbox.AppendText(value, Color.White);

            Application.DoEvents();
        }


        public void AddDebug(string value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AddDebug), value);
                return;
            }

            debugTextbox.Text += value;
            allOutputTextbox.AppendText(value, Color.White);

            Application.DoEvents();
        }

        public void Run(string fileName)
        {
            var start = DateTime.Now;

            //We're gonna need to grant some permissions...just for this process

            try
            {

                var psInst = PowerShell.Create();
                psInst.AddScript("Set-ExecutionPolicy -Scope Process -ExecutionPolicy Unrestricted");
                psInst.Invoke();
                psInst.AddScript(fileName);


                var output = new PSDataCollection<PSObject>();
                psInst.Streams.Error.DataAdded += (sender, args) =>
                {
                    var psData = (PSDataCollection<ErrorRecord>)sender;

                    var results = psData.ReadAll();

                    foreach (var result in results)
                    {
                        AddError(result.ToString());
                    }
                };

                psInst.Streams.Warning.DataAdded += (sender, args) =>
                {
                    var psData = (PSDataCollection<WarningRecord>)sender;

                    var results = psData.ReadAll();

                    foreach (var result in results)
                    {
                        AddWarning(result.ToString());
                    }
                };

                psInst.Streams.Information.DataAdded += (sender, args) =>
                {
                    var psData = (PSDataCollection<InformationRecord>)sender;

                    var results = psData.ReadAll();

                    foreach (var result in results)
                    {
                        AddInfo(result.ToString());
                    }
                };

                psInst.Streams.Debug.DataAdded += (sender, args) =>
                {
                    var psData = (PSDataCollection<DebugRecord>)sender;

                    var results = psData.ReadAll();

                    foreach (var result in results)
                    {
                        AddDebug(result.ToString());
                    }
                };

                // Invoke the pipeline asynchronously.
                var asyncResult = psInst.BeginInvoke();

                while (!asyncResult.IsCompleted)
                {
                    Application.DoEvents();
                    Thread.Sleep(100);
                }


                TimeSpan elapsed = DateTime.Now.Subtract(start);

                MessageBox.Show($"Done executing in {elapsed.ToReadableString()}");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Running Script: {ex.Message}", "MERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

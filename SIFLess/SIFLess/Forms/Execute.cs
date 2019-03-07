using System;
using System.Drawing;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIFLess.Host;

namespace SIFLess.Forms
{
    public partial class Execute : Form
    {
        private string m_FileName;
        private int m_ToolTipIndex;

        private PowerShell m_PSInst;
        private SIFLessPSHostUserInterface m_UI = new SIFLessPSHostUserInterface();
        private Runspace m_Runspace;
        private IAsyncResult m_AsyncResult;

        public Execute()
        {
            InitializeComponent();
        }

        public Execute(string fileName) :this()
        {
            m_FileName = fileName;
        }
        
        private void Execute_Load(object sender, EventArgs e)
        {
            ParseParameters();
        }
        private void Execute_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_PSInst.InvocationStateInfo.State == PSInvocationState.Running || m_PSInst.InvocationStateInfo.State == PSInvocationState.Stopping)
            {
                e.Cancel = true;
                AddProgress(null, new ProgressEventArgs{Message="Stopping...this might take a second", Percent=0});
                m_PSInst.BeginStop(StopGracefully, null);

            }
        }

        private void Powershell_InvocationStateChanged(object sender, PSInvocationStateChangedEventArgs e)
        {
            switch (e.InvocationStateInfo.State)
            {
                case PSInvocationState.Failed:
                    AddError(null, new MessageEventArgs{Message = $"Errored out: {e.InvocationStateInfo.Reason.Message}"});
                    break;
                default:
                    AddInfo(null, new MessageEventArgs{Message = e.InvocationStateInfo.State.ToString()});
                    break;
            }
        }

        private void parameterCheckBoxList_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_ToolTipIndex != parameterCheckBoxList.IndexFromPoint(e.Location))
                ShowToolTip();
        }
        
        private void runButton_Click(object sender, EventArgs e)
        {
            outputTabControl.SelectedTab = allTab;

            Run();
        }



        public void Run()
        {
            var start = DateTime.Now;

            try
            {
                //Ensure we have WebAdministration setup
                var init = InitialSessionState.CreateDefault();
                init.ImportPSModule(new[] { "WebAdministration" });

                //We'll need a custom UI because the WebAdmin Cmdlets have issues with killing the Streams events
                var host = new SIFLessPSHost(m_UI);
                m_Runspace = RunspaceFactory.CreateRunspace(host, init);
                m_PSInst = PowerShell.Create(RunspaceMode.NewRunspace);

                m_PSInst.Runspace = m_Runspace;

                m_Runspace.Open();
                
                //Attach an event for state changes
                m_PSInst.InvocationStateChanged += Powershell_InvocationStateChanged;

                //Our command is the file
                var scriptCommand = new Command(m_FileName);

                //Add parameters to the command
                foreach (var checkedItem in parameterCheckBoxList.CheckedItems)
                {
                    var sifParam = checkedItem as PSParameter;

                    scriptCommand.Parameters.Add(new CommandParameter(sifParam.Name, true));
                }

                m_PSInst.Commands.AddCommand(scriptCommand);

                //Wire up our events
                m_UI.ErrorReceived += AddError;
                m_UI.WarningReceived += AddWarning;
                m_UI.InfoReceived += AddInfo;
                m_UI.DebugReceived += AddDebug;
                m_UI.VerboseReceived += AddVerbose;
                m_UI.ProgressReceived += AddProgress;

                // Invoke the pipeline asynchronously.
                m_AsyncResult = m_PSInst.BeginInvoke();

                //Let's keep an eye on this while it runs
                while (!m_AsyncResult.IsCompleted)
                {
                    Thread.Sleep(100);
                    Application.DoEvents();
                }

                toolStripStatusLabel1.Text = $"Finished in {DateTime.Now.Subtract(start).ToReadableString()}";
                MessageBox.Show("Done processing");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Running Script: {ex.Message}", "Whoops?", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                m_PSInst.Dispose();
            }
        }


        private void ParseParameters()
        {
            var regexString = "(?:\\[Parameter\\((?s:.*?)HelpMessage=\"(.*?)\"\\)\\])?(?:\\s+?)\\[switch\\]\\$(\\w+)";

            var regex = new Regex(regexString, RegexOptions.Multiline);

            var matches = regex.Matches(File.ReadAllText(m_FileName));

            foreach (Match match in matches)
            {
                var paramName = match.Groups[2].Value;
                var paramDesc = match.Groups[1].Value;
                parameterCheckBoxList.Items.Add(new PSParameter { Description = paramDesc, Name = paramName });
            }
        }

        private void ShowToolTip()
        {
            m_ToolTipIndex = parameterCheckBoxList.IndexFromPoint(parameterCheckBoxList.PointToClient(MousePosition));
            if (m_ToolTipIndex > -1)
            {

                parameterToolTip.ToolTipTitle = "Parameter Description";
                parameterToolTip.SetToolTip(parameterCheckBoxList, ((PSParameter)parameterCheckBoxList.Items[m_ToolTipIndex]).Description);

            }
        }

        void StopGracefully(IAsyncResult result)
        {
            m_PSInst.Dispose();

            AddProgress(null, new ProgressEventArgs{Message="Stopped", Percent=0});

            if (InvokeRequired)
            {
                Invoke(new Action(CloseForm));
                return;
            }

            CloseForm();
        }

        void CloseForm()
        {
            Close(); //Simple enough?
        }

        #region Render Methods

        public void AddError(object o, MessageEventArgs args)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<object, MessageEventArgs>(AddError), o, args);
                return;
            }

            errorTextBox.AppendText(args.Message, Color.Red);
            allOutputTextBox.AppendText(args.Message, Color.Red);

            Application.DoEvents();
        }

        public void AddWarning(object o, MessageEventArgs args)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<object, MessageEventArgs>(AddWarning), o, args);
                return;
            }

            warningTextBox.AppendText(args.Message, Color.Gold);
            allOutputTextBox.AppendText(args.Message, Color.Gold);

            Application.DoEvents();
        }


        public void AddInfo(object o, MessageEventArgs args)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<object, MessageEventArgs>(AddInfo), o, args);
                return;
            }

            infoTextBox.AppendText(args.Message, Color.White);
            allOutputTextBox.AppendText(args.Message, Color.White);

            Application.DoEvents();
        }


        public void AddDebug(object o, MessageEventArgs args)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<object, MessageEventArgs>(AddDebug), o, args);
                return;
            }

            debugTextBox.AppendText(args.Message, Color.White);
            allOutputTextBox.AppendText(args.Message, Color.White);

            Application.DoEvents();
        }


        public void AddVerbose(object o, MessageEventArgs args)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<object, MessageEventArgs>(AddVerbose), o, args);
                return;
            }

            verboseTextBox.AppendText(args.Message, Color.White);
            allOutputTextBox.AppendText(args.Message, Color.White);

            Application.DoEvents();
        }

        public void AddProgress(object o, ProgressEventArgs args)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<object, ProgressEventArgs>(AddProgress), o, args);
                return;
            }


            toolStripStatusLabel1.Text = args.Message;

            toolStripProgressBar1.Value = args.Percent < 0 ? 0 : args.Percent;

            Application.DoEvents();
        }
        #endregion

       
    }
}

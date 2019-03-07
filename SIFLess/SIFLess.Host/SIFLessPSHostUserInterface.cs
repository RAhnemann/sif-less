using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Security;

namespace SIFLess.Host
{
    public class SIFLessPSHostUserInterface : PSHostUserInterface
    {

        private readonly SIFLessPSHostRawUserInterface _UI;

        public SIFLessPSHostUserInterface()
        {
            _UI = new SIFLessPSHostRawUserInterface();
        }

        public override PSHostRawUserInterface RawUI => _UI;

        #region Events

        public event EventHandler<MessageEventArgs> ErrorReceived;
        public event EventHandler<MessageEventArgs> WarningReceived;
        public event EventHandler<MessageEventArgs> InfoReceived;
        public event EventHandler<MessageEventArgs> DebugReceived;
        public event EventHandler<MessageEventArgs> VerboseReceived;
        public event EventHandler<ProgressEventArgs> ProgressReceived;

        protected virtual void OnErrorReceived(MessageEventArgs e)
        {
            ErrorReceived?.Invoke(this, e);
        }

        protected virtual void OnWarningReceived(MessageEventArgs e)
        {
            WarningReceived?.Invoke(this, e);
        }

        protected virtual void OnInfoReceived(MessageEventArgs e)
        {
            InfoReceived?.Invoke(this, e);
        }

        protected virtual void OnDebugReceived(MessageEventArgs e)
        {
            DebugReceived?.Invoke(this, e);
        }

        protected virtual void OnVerboseReceived(MessageEventArgs e)
        {
            VerboseReceived?.Invoke(this, e);
        }

        protected virtual void OnProgressReceived(ProgressEventArgs e)
        {
            ProgressReceived?.Invoke(this, e);
        }

        #endregion


        public override void WriteErrorLine(string value)
        {
            OnErrorReceived(new MessageEventArgs{Message = value});
        }

        public override void WriteWarningLine(string message)
        {
           OnWarningReceived(new MessageEventArgs{Message = message});
        }
        public override void WriteInformation(InformationRecord record)
        {
            OnInfoReceived(new MessageEventArgs { Message = record.ToString() });
        }
        
        public override void WriteDebugLine(string message)
        {
            OnDebugReceived(new MessageEventArgs{Message = message});
        }

        public override void WriteVerboseLine(string message)
        {
            OnVerboseReceived(new MessageEventArgs{Message = message});
        }
        public override void WriteProgress(long sourceId, ProgressRecord record)
        {
            OnProgressReceived(new ProgressEventArgs{Message =  record.StatusDescription, Percent = record.PercentComplete});
        }

        #region Not Implemented

        public override void Write(string value)
        {
            //Empty
        }

        public override void Write(ConsoleColor foregroundColor, ConsoleColor backgroundColor, string value)
        {
            //Empty
        }

        public override void WriteLine(string value)
        {
            //Empty
        }

        public override string ReadLine() => throw new NotImplementedException();
        public override SecureString ReadLineAsSecureString() => throw new NotImplementedException();
        public override Dictionary<string, PSObject> Prompt(string caption, string message, Collection<FieldDescription> descriptions) => throw new NotImplementedException();
        public override PSCredential PromptForCredential(string caption, string message, string userName, string targetName) => throw new NotImplementedException();
        public override PSCredential PromptForCredential(string caption, string message, string userName, string targetName,
            PSCredentialTypes allowedCredentialTypes, PSCredentialUIOptions options) => throw new NotImplementedException();
        public override int PromptForChoice(string caption, string message, Collection<ChoiceDescription> choices, int defaultChoice) => throw new NotImplementedException();
        #endregion
    }
}

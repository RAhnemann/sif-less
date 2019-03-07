using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Management.Automation.Host;

namespace SIFLess.Host
{
    public class SIFLessPSHost : PSHost
    {
    
            private readonly PSHostUserInterface _hostUserInterface;

            public SIFLessPSHost(PSHostUserInterface hostUserInterface)
            {
                _hostUserInterface = hostUserInterface;
            }

            public override PSHostUserInterface UI => _hostUserInterface;

            public override string Name => "SIF-less";
            public override Version Version => new Version(1, 0);
            public override Guid InstanceId => new Guid("eb30b404-18c2-455d-8271-423039280b9b");


            public override CultureInfo CurrentCulture => Thread.CurrentThread.CurrentCulture;
            public override CultureInfo CurrentUICulture => Thread.CurrentThread.CurrentUICulture;

            public override void SetShouldExit(int exitCode)
            {
                //Something
            }

            public override void EnterNestedPrompt()
            {

            }

            public override void ExitNestedPrompt()
            {

            }

            public override void NotifyBeginApplication()
            {

            }

            public override void NotifyEndApplication()
            {

            }

        }

    
}

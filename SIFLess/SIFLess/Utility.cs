using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading.Tasks;

namespace SIFLess
{
   public class Utility
    {
        public static bool CheckPowerShell(string commandText, string expected)
        {
            var runspace = RunspaceFactory.CreateRunspace();

            // open it

            runspace.Open();

            // create a pipeline and feed it the script text

            var pipeline = runspace.CreatePipeline();
            pipeline.Commands.AddScript(commandText);

            // add an extra command to transform the script
            // output objects into nicely formatted strings

            // remove this line to get the actual objects
            // that the script returns. For example, the script

            // "Get-Process" returns a collection
            // of System.Diagnostics.Process instances.

            pipeline.Commands.Add("Out-String");

            // execute the script

            var results = pipeline.Invoke();

            // close the runspace

            runspace.Close();

            // convert the script result into a single string

            var stringBuilder = new StringBuilder();
            foreach (var obj in results)
            {
                stringBuilder.AppendLine(obj.ToString());
            }


            return stringBuilder.ToString().Contains(expected);
        }
    }
}

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

        public static List<string> GetFilesForInstance(string topology, string version)
        {
            var files = new List<string>();
            switch (version)
            {
                case "9.0 Initial Release":
                    if (topology == "XM")
                    {

                    }
                    else if (topology == "XP")
                    {
                        files.Add("Sitecore 9.0.0 rev. 171002 (OnPrem)_single.scwdp.zip");
                        files.Add("Sitecore 9.0.0 rev. 171002 (OnPrem)_xp0xconnect.scwdp.zip");
                        files.Add("sitecore-solr.json");
                        files.Add("sitecore-XP0.json");
                        files.Add("xconnect-createcert.json");
                        files.Add("xconnect-solr.json");
                        files.Add("xconnect-XP0.json");
                    }

                    break;
                case "9.0 Update 1":
                    if (topology == "XM")
                    {
                        files.Add("Sitecore 9.0.1 rev. 171219 (OnPrem)_cm.scwdp.zip");
                        files.Add("sitecore-solr.json");
                        files.Add("sitecore-XM1-cm.json");
                    }
                    else if (topology == "XP")
                    {
                        files.Add("Sitecore 9.0.1 rev. 171219 (OnPrem)_single.scwdp.zip");
                        files.Add("Sitecore 9.0.1 rev. 171219 (OnPrem)_xp0xconnect.scwdp.zip");
                        files.Add("sitecore-solr.json");
                        files.Add("sitecore-XP0.json");
                        files.Add("xconnect-createcert.json");
                        files.Add("xconnect-solr.json");
                        files.Add("xconnect-XP0.json");
                    }
                    break;
            }

            return files;

        }
    }
}

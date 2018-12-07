using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using SIFLess.Model.Configuration;
using Configuration = SIFLess.Model.Configuration.Configuration;

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

        public static Configuration GetInstanceConfiguration(string topology, string version)
        {

            ConfigurationSet configs = GetConfigSets();

            if (configs != null)
            {
                var config = configs.Configurations.Find(c => c.Topology == topology && c.Version == version);

                return config;
            }
            else
            {
                throw new Exception($"Couldn't find associated config for [{topology}][{version}]");
            }


        }
        public static List<string> GetFilesForInstance(string topology, string version)
        {
            var configs = GetConfigSets();

            if (configs != null)
            {
                var config = configs.Configurations.Find(c => c.Topology == topology && c.Version == version);

                var files = new List<string>();

                foreach (var file in config.Files)
                {
                    files.Add(file.Name);
                }

                return files;
            }
            else
            {
                throw new Exception($"Couldn't find associated config for [{topology}][{version}]");
            }

        }

        public static ConfigurationSet GetConfigSets()
        {
            var configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                ConfigurationManager.AppSettings["ConfigManifestPath"]);

            var mainSet = new ConfigurationSet();

            foreach (var filePath in Directory.GetFiles(configPath))
            {

                var serializer = new XmlSerializer(typeof(ConfigurationSet));
                using (var reader = new StreamReader(filePath))
                {
                    try
                    {
                        var versionSet = (ConfigurationSet) serializer.Deserialize(reader);
                        mainSet.Configurations.AddRange(versionSet.Configurations);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        return null;
                    }
                    finally
                    {
                        reader.Close();
                    }
                }
            }

            return mainSet;

        }
    }
}

using SIFLess.Model.Configuration;
using SIFLess.Model.Update;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Management.Automation.Runspaces;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
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
                        var versionSet = (ConfigurationSet)serializer.Deserialize(reader);
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

        public static List<UpdateFile> GetUpdateFiles()
        {
            var manifestUrl = ConfigurationManager.AppSettings["ManifestUrl"];

            var xmlManifest = new XmlDocument();


            xmlManifest.Load(manifestUrl);


            var root = AppDomain.CurrentDomain.BaseDirectory;
            var fileList = new List<UpdateFile>();

            foreach (XmlNode item in xmlManifest.SelectNodes("Manifest/Item"))
            {
                var name = item.Attributes["name"].Value;
                var fileName = item.Attributes["fileName"].Value;
                var hash = item.Attributes["hash"].Value;
                var url = item.Attributes["url"].Value;

                var fullFilePath = Path.Combine(root, fileName);
                var state = UpdateFile.Status.Current;

                if (!System.IO.File.Exists(fullFilePath))
                {
                    state = UpdateFile.Status.Missing;
                }
                else
                {
                    using (var md5 = MD5.Create())
                    {
                        using (var stream = System.IO.File.OpenRead(fullFilePath))
                        {
                            if (!BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToLowerInvariant().Equals(hash))
                            {
                                state = UpdateFile.Status.Outdated;
                            }
                        }
                    }
                }

                fileList.Add(new UpdateFile
                {
                    Name = name,
                    Path = fileName,
                    FileStatus = state,
                    Url = url
                });

            }

            return fileList;
        }
    }
}

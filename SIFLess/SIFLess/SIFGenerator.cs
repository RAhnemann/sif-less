using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using SIFLess.Controls;
using SIFLess.Model.Configuration;
using SIFLess.Model.Profiles;
using ioFile = System.IO.File;

namespace SIFLess
{
    public class SIFGenerator
    {
        public static string Generate(SitecoreProfile scProfile, SqlProfile sqlProfile, SolrProfile solrProfile)
        {
            var configuration = Utility.GetInstanceConfiguration(scProfile.Topology, scProfile.Version);

            var wrapperPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, configuration.Wrapper);

            if (!ioFile.Exists(wrapperPath))
            {
              //TODO
                throw new Exception("Couldn't find Wrapper: " + wrapperPath);
            }

            var wrapper = ioFile.ReadAllText(wrapperPath);


            var allMaps = new Dictionary<string, List<ScriptMap>>();

            foreach (var mapType in configuration.ScriptMapNames.Split('|'))
            {
                allMaps.Add(mapType, new List<ScriptMap>());
            }

            var configScriptMaps = configuration.ScriptMaps;

            foreach (var scriptMap in configScriptMaps.ScriptMapList)
            {
                allMaps[scriptMap.Location].Add(scriptMap);
            }

            foreach (var file in configuration.Files.Where(f => f.Type == "config"))
            {
                foreach (var scriptMap in file.ScriptMaps.ScriptMapList)
                {
                    allMaps[scriptMap.Location].Add(scriptMap);
                }
            }

            foreach (var mapType in allMaps)
            {
                var scriptText = new StringBuilder();
                allMaps[mapType.Key].ForEach(st => scriptText.Append(st.Text));
                wrapper = wrapper.Replace($"[{mapType.Key}]", scriptText.ToString());
            }

            var wrapperWithBaseBooks = ReplaceAllBaseBookmarks(wrapper);

            foreach (var control in customFieldsGroupBox.Controls)
            {
                if (control is StringControl sControl)
                {
                    wrapperWithBaseBooks = wrapperWithBaseBooks.Replace($"[{sControl.FieldMap}]", sControl.Value);
                }
            }
        }

        private static string ReplaceAllBaseBookmarks(string wrapperContents)
        {
            var input = wrapperContents;
            var scProfile = profileListBox.SelectedItem as SitecoreProfile;
            var sqlProfile = connectionListBox.SelectedItem as SqlProfile;
            var solrProfile = solrListBox.SelectedItem as SolrProfile;

            input = input.Replace("[PREFIX]", prefixTextBox.Text.Trim());
            input = input.Replace("[DATA_FOLDER]", scProfile.DataFolder);
            input = input.Replace("[LICENSE_FILE]", scProfile.LicenseFile);

            //Solr
            input = input.Replace("[SOLR_URL]", solrProfile.Url);
            input = input.Replace("[SOLR_ROOT]", solrProfile.CorePath);
            input = input.Replace("[SOLR_SERVICE]", solrProfile.ServiceName);

            //sql
            input = input.Replace("[SQL_SERVER]", sqlProfile.ServerName);
            input = input.Replace("[SQL_USER]", sqlProfile.Login);
            input = input.Replace("[SQL_PASSWORD]", sqlProfile.Password);

            return input;
        }
    }
}

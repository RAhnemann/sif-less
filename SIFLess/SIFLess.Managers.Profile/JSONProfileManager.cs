using System;
using System.Configuration;
using System.IO;
using Newtonsoft.Json;
using SIFLess.Model.Managers;
using SIFLess.Model.Profiles;

namespace SIFLess.Managers.Profile
{
    public class JSONProfileManager : IProfileManager
    {
        public SifLessProfiles Fetch()
        {
            string configPath;

            if (string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["ProfilePath"]))
            {
                configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Profiles.json");

                if (!File.Exists(configPath))
                {
                    return new SifLessProfiles() { Version = System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString() };
                }

            }
            else
            {
                configPath = ConfigurationManager.AppSettings["ProfilePath"];
            }

            return JsonConvert.DeserializeObject<SifLessProfiles>(File.ReadAllText(configPath));
        }

        public void Update(SifLessProfiles profileData)
        {
            string configPath;

            if (string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["ProfilePath"]))
            {
                configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Profiles.json");
            }
            else
            {
                configPath = ConfigurationManager.AppSettings["ProfilePath"];
            }

            File.WriteAllText(configPath, JsonConvert.SerializeObject(profileData));
        }
    }
}

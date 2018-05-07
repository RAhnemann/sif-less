using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SIFLess.Model.Managers;
using SIFLess.Model.Profiles;

namespace SIFLess.Managers.Profile
{
    public class JSONProfileManager : IProfileManager
    {
        public SifLessProfiles Fetch()
        {
            var configPath = string.Empty;

            if (string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["ProfilePath"]))
            {
                configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Profiles.json");

                if (!File.Exists(configPath))
                {
                    return new SifLessProfiles();
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
            var configPath = string.Empty;

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

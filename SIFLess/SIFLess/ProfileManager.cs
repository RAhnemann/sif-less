using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SIFLess.Model;
using SIFLess.Properties;

namespace SIFLess
{
    public class ProfileManager
    {
        public static SIFLessProfiles Fetch()
        {
            var profileText = Settings.Default.SIFlessProfiles;

            if (string.IsNullOrWhiteSpace(profileText))
            {
                SIFLessProfiles newProfileData = new SIFLessProfiles
                {
                    SiteforeProfilese = new List<SitecoreProfile>(),
                    SqlProfiles = new List<SQLProfile>()
                };

                Update(newProfileData);

                return newProfileData;
            }

            return JsonConvert.DeserializeObject<SIFLessProfiles>(profileText);
        }
        public static void Update(SIFLessProfiles profileData)
        {
            Settings.Default.SIFlessProfiles = JsonConvert.SerializeObject(profileData);
            Settings.Default.Save();
            Settings.Default.Reload();
        }
    }
}

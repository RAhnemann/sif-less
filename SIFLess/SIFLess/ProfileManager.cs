using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Caching;
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
                    SiteforeProfiles = new List<SitecoreProfile>(),
                    SqlProfiles = new List<SQLProfile>(),
                    SolrProfiles = new List<SolrProfile>()
                };

                Update(newProfileData);

                return newProfileData;
            }

            var currentData = JsonConvert.DeserializeObject<SIFLessProfiles>(profileText);

            if (currentData.SiteforeProfiles == null)
                currentData.SiteforeProfiles = new List<SitecoreProfile>();

            if (currentData.SolrProfiles == null)
                currentData.SolrProfiles = new List<SolrProfile>();

            if (currentData.SqlProfiles == null)
                currentData.SqlProfiles = new List<SQLProfile>();

            return currentData;
        }
        public static void Update(SIFLessProfiles profileData)
        {
            Settings.Default.SIFlessProfiles = JsonConvert.SerializeObject(profileData);
            Settings.Default.Save();
            Settings.Default.Reload();
        }
    }
}

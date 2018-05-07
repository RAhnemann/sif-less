using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Caching;
using Newtonsoft.Json;
using SIFLess.Model;
using SIFLess.Model.Managers;
using SIFLess.Model.Profiles;
using SIFLess.Properties;

namespace SIFLess
{
    public class SIFProfile 
    {
       
        public SifLessProfiles Fetch()
        {
            var profileText = Settings.Default.SIFlessProfiles;

            if (string.IsNullOrWhiteSpace(profileText))
            {
                SifLessProfiles newProfileData = new SifLessProfiles
                {
                    SitecoreProfiles = new List<SitecoreProfile>(),
                    SqlProfiles = new List<SqlProfile>(),
                    SolrProfiles = new List<SolrProfile>()
                };

                Update(newProfileData);

                return newProfileData;
            }

            var currentData = JsonConvert.DeserializeObject<SifLessProfiles>(profileText);

            if (currentData.SitecoreProfiles == null)
                currentData.SitecoreProfiles = new List<SitecoreProfile>();

            if (currentData.SolrProfiles == null)
                currentData.SolrProfiles = new List<SolrProfile>();

            if (currentData.SqlProfiles == null)
                currentData.SqlProfiles = new List<SqlProfile>();

            return currentData;
        }
        public void Update(SifLessProfiles profileData)
        {
            Settings.Default.SIFlessProfiles = JsonConvert.SerializeObject(profileData);
            Settings.Default.Save();
            Settings.Default.Reload();
        }
    }
}

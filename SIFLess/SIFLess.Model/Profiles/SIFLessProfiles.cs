using System.Collections.Generic;

namespace SIFLess.Model.Profiles
{
    public class SifLessProfiles
    {
        public SifLessProfiles()
        {
            SitecoreProfiles = new List<SitecoreProfile>();
            SqlProfiles = new List<SqlProfile>();
            SolrProfiles = new List<SolrProfile>();
        }
        public List<SitecoreProfile> SitecoreProfiles { get; set; }

        public List<SqlProfile> SqlProfiles { get; set; }

        public List<SolrProfile> SolrProfiles { get; set; }

        public string Version { get; set; }
    }
}

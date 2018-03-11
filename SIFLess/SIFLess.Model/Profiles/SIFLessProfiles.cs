using System.Collections.Generic;

namespace SIFLess.Model.Profiles
{
    public class SifLessProfiles
    {
        public List<SitecoreProfile> SiteforeProfiles { get; set; }

        public List<SqlProfile> SqlProfiles { get; set; }

        public List<SolrProfile> SolrProfiles { get; set; }
    }
}

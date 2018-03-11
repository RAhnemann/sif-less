using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIFLess.Model
{
    public class SIFLessProfiles
    {
        public List<SitecoreProfile> SiteforeProfiles { get; set; }

        public List<SQLProfile> SqlProfiles { get; set; }

        public List<SolrProfile> SolrProfiles { get; set; }
    }
}

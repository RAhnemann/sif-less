using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIFLess.Model
{
    public class SitecoreProfile
    {
        public SitecoreProfile()
        {
            Files = new List<string>();
            
        }

        [Browsable(false)]
        public Guid ID { get; set; }
        public string Name { get; set; }

        public string Topology { get; set; }

        public string Version { get; set; }
        [Browsable(false)]
        public string DataFolder { get; set; }
        [Browsable(false)]
        public List<string> Files { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

using System;
using System.ComponentModel;

namespace SIFLess.Model
{
    public class SolrProfile
    {
       

        [Browsable(false)]
        public Guid ID { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public string ServiceName { get; set; }

        [Browsable(false)]
        public string CorePath { get; set; }
        
        public override string ToString()
        {
            return Name;
        }
    }
}

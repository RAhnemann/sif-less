using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SIFLess.Model.Configuration
{
    [XmlRoot(ElementName = "Configurations")]
    public class ConfigurationSet
    {
        [XmlElement(ElementName = "Configuration")]
        public List<Configuration> Configurations { get; set; }
    }
}

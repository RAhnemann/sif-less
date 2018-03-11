using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SIFLess.Model.Configuration
{
    [XmlRoot(ElementName = "Configuration")]
    public class Configuration
    {
        [XmlElement(ElementName = "File")]
        public List<File> Files { get; set; }

        [XmlElement(ElementName = "ScriptMap")]
        public ScriptMap ScriptMap { get; set; }

        [XmlAttribute(AttributeName = "topology")]
        public string Topology { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }

        [XmlAttribute(AttributeName = "wrapper")]
        public string Wrapper { get; set; }
    }
}

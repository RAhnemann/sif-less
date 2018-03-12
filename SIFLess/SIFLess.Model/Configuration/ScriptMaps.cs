using System.Collections.Generic;
using System.Xml.Serialization;

namespace SIFLess.Model.Configuration
{
    [XmlRoot(ElementName = "ScriptMaps")]
    public class ScriptMaps
    {
        [XmlElement(ElementName = "ScriptMap")]
        public List<ScriptMap> ScriptMapList { get; set; }
    }
}
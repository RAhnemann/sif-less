using System.Xml.Serialization;

namespace SIFLess.Model.Configuration
{
    [XmlRoot(ElementName = "ScriptMap")]
    public class ScriptMap
    {
        [XmlAttribute(AttributeName = "location")]
        public string Location { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}
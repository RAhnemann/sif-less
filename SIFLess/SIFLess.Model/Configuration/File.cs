using System.Xml.Serialization;

namespace SIFLess.Model.Configuration
{
    [XmlRoot(ElementName = "File")]
    public class File
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "ScriptMaps")]
        public ScriptMaps ScriptMaps { get; set; }

        [XmlElement(ElementName = "FieldMaps")]
        public FieldMaps FieldMaps { get; set; }
    }
}
using System.ComponentModel;
using System.Xml.Serialization;

namespace SIFLess.Model.Configuration
{
    [XmlRoot(ElementName = "Field")]
    public class Field
    {
        public Field()
        {
            DefaultValue = "";
        }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlAttribute(AttributeName = "map")]
        public string Map { get; set; }

        [XmlAttribute(AttributeName = "label")]
        public string Label { get; set; }

        [XmlAttribute(AttributeName = "description")]
        public string Description { get; set; }

        [XmlAttribute(AttributeName = "defaultValue")]
        public string DefaultValue { get; set; }
    }
}
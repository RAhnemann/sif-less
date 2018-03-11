using System.Collections.Generic;
using System.Xml.Serialization;

namespace SIFLess.Model.Configuration
{
    [XmlRoot(ElementName = "FieldMaps")]
    public class FieldMaps
    {
        [XmlElement(ElementName = "Field")]
        public List<Field> Fields { get; set; }
    }
}
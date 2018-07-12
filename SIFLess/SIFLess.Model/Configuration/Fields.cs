using System.Collections.Generic;
using System.Xml.Serialization;

namespace SIFLess.Model.Configuration
{
    [XmlRoot(ElementName = "Fields")]
    public class FieldSet
    {
        [XmlElement(ElementName = "Field")]
        public List<Field> Fields { get; set; }
    }
}
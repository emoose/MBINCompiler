using System.Collections.Generic;
using System.Xml.Serialization;

namespace MBINCompiler.Models
{
    [XmlType("Property")]
    public class EXmlProperty
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("value")]
        public string Value { get; set; }

        [XmlElement("Data")]
        public List<EXmlData> Data { get; set; }
    }
}
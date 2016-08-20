using System.Collections.Generic;
using System.Xml.Serialization;

namespace MBINCompiler.Models
{
    [XmlType("Data")]
    public class EXmlData
    {
        [XmlAttribute("template")]
        public string Template { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlElement("Property")]
        public List<EXmlProperty> Properties { get; set; }

        [XmlElement("Data")]
        public List<EXmlData> Data { get; set; }
    }
}
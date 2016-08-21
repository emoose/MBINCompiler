using System.Xml.Serialization;

namespace MBINCompiler.Models
{
    [XmlType("Data")]
    public class EXmlData : EXmlBase
    {
        [XmlAttribute("template")]
        public string Template { get; set; }
    }
}
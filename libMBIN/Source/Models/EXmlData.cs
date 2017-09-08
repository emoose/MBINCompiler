using System.Xml.Serialization;

namespace libMBIN.Models
{
    [XmlType("Data")]
    public class EXmlData : EXmlBase
    {
        [XmlAttribute("template")]
        public string Template { get; set; }
    }
}
using System.Xml.Serialization;

namespace libMBIN
{
    [XmlType("Data")]
    public class EXmlData : EXmlBase
    {
        [XmlAttribute("template")]
        public string Template { get; set; }
    }
}
using System.Xml.Serialization;

namespace libMBIN
{
    [XmlType("Data")]
    public class MXmlData : MXmlBase
    {
        [XmlAttribute("template")]
        public string Template { get; set; }
    }
}
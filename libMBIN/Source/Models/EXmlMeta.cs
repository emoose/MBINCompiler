using System.Xml.Serialization;

namespace libMBIN.Models
{
    [XmlType("Meta")]
    public class EXmlMeta : EXmlBase
    {
        [XmlAttribute("comment")]
        public string Comment { get; set; }
    }
}
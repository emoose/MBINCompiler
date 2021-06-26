using System.Xml.Serialization;

namespace libMBIN
{
    [XmlType("Meta")]
    public class EXmlMeta : EXmlBase
    {
        [XmlAttribute("comment")]
        public string Comment { get; set; }
    }
}
using System.Xml.Serialization;

namespace libMBIN
{
    [XmlType("Meta")]
    public class MXmlMeta : MXmlBase
    {
        [XmlAttribute("comment")]
        public string Comment { get; set; }
    }
}
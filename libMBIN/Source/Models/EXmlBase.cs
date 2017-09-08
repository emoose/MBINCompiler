using System.Collections.Generic;
using System.Xml.Serialization;

namespace libMBIN.Models
{
    [XmlInclude(typeof(EXmlData))]
    [XmlInclude(typeof(EXmlProperty))]
    public abstract class EXmlBase
    {
        protected EXmlBase()
        {
            Elements = new List<EXmlBase>();
        }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlElement(typeof(EXmlData), ElementName = "Data")]
        [XmlElement(typeof(EXmlProperty), ElementName = "Property")]
        public List<EXmlBase> Elements { get; set; }
    }
}
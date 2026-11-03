using System.Xml.Serialization;

namespace libMBIN
{
    [XmlType("Property")]
    public class MXmlProperty : MXmlBase
    {
        [XmlAttribute("value")]
        public string Value { get; set; }
        [XmlAttribute("linked")]
        public string Linked { get; set; }
        [XmlAttribute("array_size")]
        public string ArraySize { get; set; }
        [XmlAttribute("_id")]
        public string ID { get; set; }
        [XmlAttribute("_index")]
        public string Index { get; set; }

        public override string ToString()
        {
            string result = "<";
            if (this.Name != null) {
                result += $"name=\"{this.Name}\"";
            }
            if (this.Value != null) {
                result += $" value=\"{this.Value}\"";
            }
            if (this.Linked != null) {
                result += $" linked=\"{this.Linked}\"";
            }
            if (this.ArraySize != null) {
                result += $" array_size=\"{this.ArraySize}\"";
            }
            result += ">";
            return result;
        }
    }
}
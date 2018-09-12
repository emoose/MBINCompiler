using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x0AAC94F73173CF13F)]
    public class TkLSystemRuleTemplate : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Name;
        [NMS(Size = 0x80)]
        public string LSystem;
    }
}

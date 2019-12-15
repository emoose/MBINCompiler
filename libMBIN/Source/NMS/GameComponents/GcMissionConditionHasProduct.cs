using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xE6E234A9D25B6EEA, NameHash = 0x9537448E73030512)]
    public class GcMissionConditionHasProduct : NMSTemplate
    {
        public GcDefaultMissionProductEnum Default;
        public GcProductTableEnum Product;
        public int Amount;
    }
}

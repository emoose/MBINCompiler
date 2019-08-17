using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xEFA72FE029883888, SubGUID = 0x9537448E73030512)]
    public class GcMissionConditionHasProduct : NMSTemplate
    {
        public GcDefaultMissionProductEnum Default;
        public GcProductTableEnum Product;
        public int Amount;
    }
}

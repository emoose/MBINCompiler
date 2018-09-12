using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x10D1C9635DE9A5FB)]
    public class GcRewardSpecificTech : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string TechId;
    }
}

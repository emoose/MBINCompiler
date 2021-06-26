using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8, GUID = 0xF2988827094F2E19, NameHash = 0x5A9334071F34CD7A)]
    public class GcRewardHealth : NMSTemplate
    {
        public int AmountMin;
        public int AmountMax;
    }
}
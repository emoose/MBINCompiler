using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8, GUID = 0x529AA936CA2FF50, NameHash = 0xB9BE65CA55BBE004)]
    public class GcRewardHazard : NMSTemplate
    {
        public int AmountMin;
        public int AmountMax;
    }
}
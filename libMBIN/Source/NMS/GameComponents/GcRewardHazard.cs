using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC, GUID = 0x0, NameHash = 0xB9BE65CA55BBE004)]
    public class GcRewardHazard : NMSTemplate
    {
        public int AmountMin;
        public int AmountMax;
        public bool Silent;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Endpadding;
    }
}
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xA18791E073723FD)]
    public class GcMissionConditionPercentageChance : NMSTemplate
    {
        public int Percent;
        public bool Seeded;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8, GUID = 0x5B63D336145942E4, NameHash = 0xA420A86F131CF88)]
    public class GcMissionConditionPercentageChance : NMSTemplate
    {
        /* 0x0 */ public int Percent;
        /* 0x4 */ public bool Seeded;
        /* 0x5 */ public bool OverrideZeroSeed;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x6 */ public byte[] EndPadding;
    }
}

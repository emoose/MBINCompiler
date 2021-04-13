using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x8, GUID = 0x0000000000000000, NameHash = 0x0A420A86F131CF88)]
    public class GcMissionConditionPercentageChance : NMSTemplate
    {
        /* 0x0 */ public int Percent;
        /* 0x4 */ public bool Seeded;
        /* 0x5 */ public bool OverrideZeroSeed;
        /* 0x6 */ public bool OverrideMissionSeedWithRandomSeed;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x7 */ public byte[] EndPadding;
    }
}

using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x38, GUID = 0x22227A02DF0A88DD, NameHash = 0xC06F148BB67FE0E2)]
    public class GcUnlockableSeasonReward : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string ID;
        /* 0x10 */ public bool MustBeUnlocked;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x11 */ public byte[] Padding11;
        /* 0x18 */ public List<int> SeasonIds;
        /* 0x28 */ public List<int> StageIds;
    }
}

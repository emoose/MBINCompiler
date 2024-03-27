using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDAF010C15889DC1D, NameHash = 0xC06F148BB67FE0E2)]
    public class GcUnlockableSeasonReward : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public bool MustBeUnlocked;
        /* 0x11 */ public bool UniqueInventoryItem;
        /* 0x12 */ public bool SwitchExclusive;
        /* 0x18 */ public List<int> SeasonIds;
        /* 0x28 */ public List<int> StageIds;
        /* 0x38 */ public NMSString0x20A SpecificMilestoneLoc;
    }
}

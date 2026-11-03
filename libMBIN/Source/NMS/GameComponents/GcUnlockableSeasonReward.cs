using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x30D200763EB03686, NameHash = 0x43D90E15)]
    public class GcUnlockableSeasonReward : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public NMSString0x20A SpecificMilestoneLoc;
        [NMS(Index = 6)]
        /* 0x20 */ public NMSString0x20A TeamName;
        [NMS(Index = 0)]
        /* 0x40 */ public NMSString0x10 ID;
        [NMS(Index = 4)]
        /* 0x50 */ public List<int> SeasonIds;
        [NMS(Index = 5)]
        /* 0x60 */ public List<int> StageIds;
        [NMS(Index = 1)]
        /* 0x70 */ public bool MustBeUnlocked;
        [NMS(Index = 3)]
        /* 0x71 */ public bool SwitchExclusive;
        [NMS(Index = 2)]
        /* 0x72 */ public bool UniqueInventoryItem;
    }
}

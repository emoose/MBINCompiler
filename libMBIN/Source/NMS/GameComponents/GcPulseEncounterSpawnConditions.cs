using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD178F2FD090FBDD1, NameHash = 0x5E9C36EF)]
    public class GcPulseEncounterSpawnConditions : NMSTemplate
    {
        [NMS(Index = 15)]
        /* 0x00 */ public List<int> BlockDuringSeasons;
        [NMS(Index = 7)]
        /* 0x10 */ public NMSString0x10 RequiresMissionActive;
        [NMS(Index = 6)]
        /* 0x20 */ public NMSString0x10 RequiresMissionComplete;
        [NMS(Index = 9)]
        /* 0x30 */ public NMSString0x10 RequiresMissionNotActive;
        [NMS(Index = 8)]
        /* 0x40 */ public NMSString0x10 RequiresMissionNotComplete;
        [NMS(Index = 5)]
        /* 0x50 */ public NMSString0x10 RequiresProduct;
        [NMS(Index = 3)]
        /* 0x60 */ public bool AllowedBeyondPortals;
        [NMS(Index = 2)]
        /* 0x61 */ public bool AllowedDuringTutorial;
        [NMS(Index = 0)]
        /* 0x62 */ public bool AllowedInCreative;
        [NMS(Index = 1)]
        /* 0x63 */ public bool AllowedInEmptySystem;
        [NMS(Index = 4)]
        /* 0x64 */ public bool AllowedWhileOnMPMission;
        [NMS(Index = 14)]
        /* 0x65 */ public bool MissionEncounter;
        [NMS(Index = 10)]
        /* 0x66 */ public bool RequiresAlienShip;
        [NMS(Index = 11)]
        /* 0x67 */ public bool RequiresCorvette;
        [NMS(Index = 12)]
        /* 0x68 */ public bool RequiresNearbyCorruptWorld;
        [NMS(Index = 13)]
        /* 0x69 */ public bool StandardEncounter;
    }
}

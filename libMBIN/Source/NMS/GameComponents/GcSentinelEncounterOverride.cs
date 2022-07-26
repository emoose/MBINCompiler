using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xA0, GUID = 0x48D7991C5533198D, NameHash = 0x858F65761E6CEB71)]
    public class GcSentinelEncounterOverride : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public float SummonRadius;
        /* 0x18 */ public NMSString0x10 SpawnID;
        /* 0x28 */ public NMSString0x10 ExtremeSpawnID;
        /* 0x38 */ public bool SpawnsAreAggressive;
        /* 0x39 */ public bool EncounterBlocksWantedSpawns;
        /* 0x3A */ public bool EncounterClearsWantedOnDefeat;
        /* 0x3B */ public bool IgnoreBuildingCrimesOnDefeat;
        /* 0x40 */ public NMSString0x20A OSDMessage;
        /* 0x60 */ public NMSString0x20A OSDOnDefeat;
        /* 0x80 */ public bool UseCustomOSDIcon;
        /* 0x84 */ public GcRealityGameIcons CustomOSDIcon;
        /* 0x88 */ public NMSString0x10 StatusMessage;
        /* 0x98 */ public bool UseEncounterTypeOverride;
        /* 0x9C */ public GcEncounterType EncounterTypeOverride;
    }
}

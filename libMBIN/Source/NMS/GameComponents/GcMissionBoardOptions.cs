using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x83DA28A701B2FB8E, NameHash = 0xDD272E15749CCDF5)]
    public class GcMissionBoardOptions : NMSTemplate
    {
        /* 0x00 */ public GcMissionType Type;
        /* 0x04 */ public GcMissionDifficulty Difficulty;
        /* 0x08 */ public int MinRank;
        /* 0x0C */ public bool CloseMissionGiver;
        /* 0x0D */ public bool IsGuildShopMission;
        /* 0x0E */ public bool IsPlanetProcMission;
        /* 0x0F */ public bool IsMultiplayerEventMission;
        /* 0x10 */ public NMSString0x10 RewardPenaltyOnAbandon;
        /* 0x20 */ public List<GcMissionFaction> Faction;
        /* 0x30 */ public int Weighting;
        /* 0x34 */ public bool IgnoreCalculatedObjective;
        /* 0x38 */ public NMSString0x20A MultiplayerMissionInitialWarpScanEvent;
        /* 0x58 */ public List<NMSString0x20A> DefaultItemInitialWarpScanEvents;
        // size: 0x5
        public enum DefaultItemTypeForInitialWarpEnum {
            None,
            PrimaryProduct,
            PrimarySubstance,
            SecondaryProduct,
            SecondarySubstance,
        }
        /* 0x68 */ public DefaultItemTypeForInitialWarpEnum DefaultItemTypeForInitialWarp;
        /* 0x70 */ public List<NMSString0x10> BasePartBlueprints;
    }
}

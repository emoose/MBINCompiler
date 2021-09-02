using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x0, GUID = 0x2139515D5061A383, NameHash = 0x8652A1B779227539, Broken = true)]
    public class GcSettlementGlobals : NMSTemplate
    {
        /* 0x0000 */ public ulong BuildingUpgradeTimeInSeconds;
        /* 0x0008 */ public ulong BuildingFreeUpgradeTimeInSeconds;
        /* 0x0010 */ public int MaxNPCPopulation;
        /* 0x0014 */ public bool DebugForceShowHiddenPerks;
        /* 0x0018 */ public float SettlementEntryMessageDistance;
        /* 0x0020 */ public NMSString0x10 SettlementMiniExpeditionMissionID;
        /* 0x0030 */ public float SettlementMiniExpeditionSuccessChance;
        [NMS(Size = 0x33, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x0038 */ public ulong[] SettlementBuildingTimes;
        [NMS(Size = 0x33, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x01D0 */ public GcSettlementBuildingCost[]  SettlementBuildingCosts;
        /* 0x3B30 */ public List<GcSettlementJudgementData> Judgements;
        [NMS(Size = 0x33, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x3B40 */ public GcSettlementStatChangeArray[] SettlementBuildingStatRewards;    // I think this is wrong? The object should be 0x60 in size...
    }
}

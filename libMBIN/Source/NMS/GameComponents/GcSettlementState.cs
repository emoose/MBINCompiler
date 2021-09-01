using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4E0, GUID = 0xC56C820368956A34, NameHash = 0x92FAA41D8355CBAE)]
    public class GcSettlementState : NMSTemplate
    {
        /* 0x000 */ public NMSString0x40 UniqueId;
        /* 0x040 */ public ulong UniverseAddress;
        /* 0x050 */ public Vector3f Position;
        /* 0x060 */ public ulong SeedValue;
        [NMS(Size = 0x30)]
        /* 0x068 */ public int[] BuildingStates;
        [NMS(Size = 0x30)]
        /* 0x128 */ public ulong[] LastBuildingUpgradesTimestamps;
        /* 0x2A8 */ public NMSString0x40 Name;
        /* 0x2E8 */ public GcDiscoveryOwner Owner;
        /* 0x3EC */ public GcSettlementJudgementType PendingJudgementType;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x3F0 */ public int[] Stats;
        /* 0x410 */ public List<NMSString0x10> Perks;
        /* 0x420 */ public ulong LastJudgementTime;
        /* 0x428 */ public ulong LastUpkeepDebtCheckTime;
        /* 0x430 */ public ulong LastDebtChangeTime;
        /* 0x438 */ public ulong LastAlertChangeTime;
        /* 0x440 */ public NMSString0x40 DbResourceId;
        /* 0x480 */ public ulong DbTimestamp;
        /* 0x488 */ public int DbVersion;
        [NMS(Size = 0x2)]
        /* 0x490 */ public GcSettlementProductionSlotData[] ProductionState;
        /* 0x4D0 */ public bool IsReported;
    }
}

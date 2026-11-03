using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCA771628D6975C32, NameHash = 0xA6E6CEBB)]
    public class GcSettlementProductionSlotData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ElementId;
        [NMS(Index = 1)]
        /* 0x10 */ public ulong LastChangeTimestamp;
        [NMS(Index = 2)]
        /* 0x18 */ public int Amount;
        [NMS(Index = 3)]
        /* 0x1C */ public int ProductionAccumulationCap;
        [NMS(Index = 6)]
        /* 0x20 */ public float ProductionAmountMultiplier;
        [NMS(Index = 7)]
        /* 0x24 */ public float ProductionTimeMultiplier;
        [NMS(Index = 4)]
        /* 0x28 */ public int RequiredSettlementBuildingLevel;
        [NMS(Index = 5)]
        /* 0x2C */ public GcBuildingClassification RequiredSettlementBuildingType;
    }
}

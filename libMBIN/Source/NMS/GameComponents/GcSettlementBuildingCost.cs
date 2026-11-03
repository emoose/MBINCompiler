using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x49CD6270A61719BB, NameHash = 0x8C1F1A30)]
    public class GcSettlementBuildingCost : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x9, EnumType = typeof(GcSettlementConstructionLevel.SettlementConstructionLevelEnum))]
        /* 0x0 */ public GcSettlementBuildingCostData[] StageCosts;
    }
}

using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x44D0190DA76AA16C, NameHash = 0x22A3B9FA5D01C4DD)]
    public class GcSettlementBuildingCost : NMSTemplate
    {
        [NMS(Size = 0x6, EnumType = typeof(GcSettlementConstructionLevel.SettlementConstructionLevelEnum))]
        /* 0x0 */ public GcSettlementBuildingCostData[] StageCosts;
    }
}

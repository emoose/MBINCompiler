using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6DA91C8455EA3DBE, NameHash = 0xB3348A3B)]
    public class GcSettlementProductionElementRequirement : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int RequiredSettlementBuildingLevel;
        [NMS(Index = 0)]
        /* 0x4 */ public GcBuildingClassification RequiredSettlementBuildingType;
    }
}

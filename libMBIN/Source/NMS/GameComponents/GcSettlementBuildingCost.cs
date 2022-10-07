using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x557013ACF7954FAD, NameHash = 0x22A3B9FA5D01C4DD)]
    public class GcSettlementBuildingCost : NMSTemplate
    {
        // size: 0x6
        public enum StageCostsEnum {
            Start,
            GroundStorey,
            RegularStorey,
            Roof,
            Decoration,
            Other
        }
        [NMS(Size = 0x6, EnumType = typeof(StageCostsEnum))]
        /* 0x0 */ public GcSettlementBuildingCostData[] StageCosts;
    }
}

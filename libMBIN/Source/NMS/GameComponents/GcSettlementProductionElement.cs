using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB4133CFD9FB277C1, NameHash = 0x502C7C3E)]
    public class GcSettlementProductionElement : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x10 Product;
        [NMS(Index = 4)]
        /* 0x10 */ public List<GcSettlementProductionElementRequirement> Requirements;
        [NMS(Index = 2)]
        /* 0x20 */ public int ProductionAccumulationCap;
        [NMS(Index = 0)]
        /* 0x24 */ public float ProductionAmountMultiplier;
        [NMS(Index = 1)]
        /* 0x28 */ public float ProductionTimeMultiplier;
    }
}

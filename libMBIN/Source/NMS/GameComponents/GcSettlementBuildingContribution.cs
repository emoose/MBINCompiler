using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x63BB0A47AFADA15C, NameHash = 0x7B84120E)]
    public class GcSettlementBuildingContribution : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<GcSettlementStatValueRange> Base;
        [NMS(Index = 1)]
        /* 0x10 */ public List<GcSettlementStatValueRange> Upgrade1;
        [NMS(Index = 2)]
        /* 0x20 */ public List<GcSettlementStatValueRange> Upgrade2;
        [NMS(Index = 3)]
        /* 0x30 */ public List<GcSettlementStatValueRange> Upgrade3;
    }
}

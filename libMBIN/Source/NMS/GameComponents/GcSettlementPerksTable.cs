using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x34625E03A674E543, NameHash = 0xF85CDB97)]
    public class GcSettlementPerksTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcSettlementPerkData> Table;
    }
}

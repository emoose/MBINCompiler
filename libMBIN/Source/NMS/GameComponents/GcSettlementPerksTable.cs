using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x26DD532F369FE935, NameHash = 0x3FBCD98A534164CD)]
    public class GcSettlementPerksTable : NMSTemplate
    {
        /* 0x0 */ public List<GcSettlementPerkData> Table;
    }
}

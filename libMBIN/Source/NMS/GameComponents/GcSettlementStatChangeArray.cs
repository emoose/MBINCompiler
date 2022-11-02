using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1EFF7D0258278835, NameHash = 0x661EFBF46F4B3D78)]
    public class GcSettlementStatChangeArray : NMSTemplate
    {
        /* 0x0 */ public List<GcSettlementStatChange> Stats;
    }
}

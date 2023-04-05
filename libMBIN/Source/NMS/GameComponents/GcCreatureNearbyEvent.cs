using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x41378BC23F48BA81, NameHash = 0x42869E79D40A84C1)]
    public class GcCreatureNearbyEvent : NMSTemplate
    {
        /* 0x00 */ public List<GcCreatureAlertData> AlertTable;
        /* 0x10 */ public bool Inverse;
    }
}

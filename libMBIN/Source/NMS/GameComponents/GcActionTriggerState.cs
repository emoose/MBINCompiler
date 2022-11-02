using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA0A34AF3610A202B, NameHash = 0x51A3F598097EC1ED)]
    public class GcActionTriggerState : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 StateID;
        /* 0x10 */ public List<GcActionTrigger> Triggers;
    }
}

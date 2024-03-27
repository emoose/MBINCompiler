using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x80C2AECAA8F3D80A, NameHash = 0x51A3F598097EC1ED)]
    public class GcActionTriggerState : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 StateID;
        /* 0x10 */ public List<GcActionTrigger> Triggers;
    }
}

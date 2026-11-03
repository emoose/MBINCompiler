using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x557FFABC650D4E36, NameHash = 0xF6A08813)]
    public class GcActionTriggerState : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 StateID;
        [NMS(Index = 1)]
        /* 0x10 */ public List<GcActionTrigger> Triggers;
    }
}

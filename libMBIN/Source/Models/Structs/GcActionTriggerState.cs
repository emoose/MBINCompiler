using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x20)]
    public class GcActionTriggerState : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string StateID;
        public List<GcActionTrigger> Triggers;
    }
}

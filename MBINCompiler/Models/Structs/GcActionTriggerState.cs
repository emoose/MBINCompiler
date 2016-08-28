using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcActionTriggerState : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string StateID;
        public List<GcActionTrigger> Triggers;
    }
}

using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x20, GUID = 0x85EAE598340B4C9E)]
    public class GcActionTriggerState : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string StateID;
        public List<GcActionTrigger> Triggers;
    }
}

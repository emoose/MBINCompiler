using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x58, GUID = 0x1DFBCEEAFDE9D7C6)]
    public class GcActionTrigger : NMSTemplate
    {
        public NMSTemplate Trigger;
        public List<NMSTemplate> Action;
    }
}

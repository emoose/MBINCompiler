using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x58)]
    public class GcActionTrigger : NMSTemplate
    {
        public NMSTemplate Trigger;
        public List<NMSTemplate> Action;
    }
}

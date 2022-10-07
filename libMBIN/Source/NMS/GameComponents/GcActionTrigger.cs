using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x44C0EC8F740E67E6, NameHash = 0x269AA19701CADAB8)]
    public class GcActionTrigger : NMSTemplate
    {
        /* 0x00 */ public NMSTemplate Event;
        /* 0x50 */ public List<NMSTemplate> Action;
    }
}

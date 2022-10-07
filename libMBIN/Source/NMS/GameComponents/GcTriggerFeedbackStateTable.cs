using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD528F914EC3DDD34, NameHash = 0x6E458F753254E426)]
    public class GcTriggerFeedbackStateTable : NMSTemplate
    {
        /* 0x0 */ public List<GcTriggerFeedbackState> Events;
    }
}

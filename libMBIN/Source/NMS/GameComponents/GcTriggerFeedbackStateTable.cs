using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2B1F1319BDFB52DE, NameHash = 0x6E458F753254E426)]
    public class GcTriggerFeedbackStateTable : NMSTemplate
    {
        /* 0x0 */ public List<GcTriggerFeedbackState> Events;
    }
}

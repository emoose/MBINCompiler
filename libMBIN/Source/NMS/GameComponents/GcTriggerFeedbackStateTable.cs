using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0x785B06492D65589E, NameHash = 0x6E458F753254E426)]
    public class GcTriggerFeedbackStateTable : NMSTemplate
    {
        public List<GcTriggerFeedbackState> Events;
    }
}

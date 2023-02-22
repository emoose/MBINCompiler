using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC78265C3E5673DE1, NameHash = 0xFADF3E5CAB7333FF)]
    public class GcJourney : NMSTemplate
    {
        /* 0x0 */ public List<GcJourneyCategory> Categories;
    }
}

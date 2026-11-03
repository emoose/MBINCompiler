using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD7BCA7E1A7543001, NameHash = 0x7249CADC)]
    public class GcJourney : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcJourneyCategory> Categories;
    }
}

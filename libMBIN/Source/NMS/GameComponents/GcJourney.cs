using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x66F78B275B9A7CD3, NameHash = 0xFADF3E5CAB7333FF)]
    public class GcJourney : NMSTemplate
    {
        public List<GcJourneyCategory> Categories;
    }
}
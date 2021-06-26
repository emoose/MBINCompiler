using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x73BD2E52B9F59B2D, NameHash = 0xFADF3E5CAB7333FF)]
    public class GcJourney : NMSTemplate
    {
        public List<GcJourneyCategory> Categories;
    }
}
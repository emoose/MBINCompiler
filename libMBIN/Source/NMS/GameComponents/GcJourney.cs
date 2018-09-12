using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0C7C1C04352D3F6A5)]
    public class GcJourney : NMSTemplate        // size: 0x10
    {
        public List<GcJourneyCategory> Categories;
    }
}

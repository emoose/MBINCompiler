using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xDE61BD5117FD2931)]
    public class GcJourney : NMSTemplate
    {
        public List<GcJourneyCategory> Categories;
    }
}

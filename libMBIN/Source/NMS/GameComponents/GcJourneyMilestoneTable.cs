using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0A4768229DACCC1)]
    public class GcJourneyMilestoneTable : NMSTemplate
    {
        public List<GcJourneyMilestoneData> Table; // called GcJourneyMilestoneTable in the exe
    }
}

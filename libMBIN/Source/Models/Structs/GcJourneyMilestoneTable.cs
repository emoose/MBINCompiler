using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0A4768229DACCC1)]
    public class GcJourneyMilestoneTable : NMSTemplate
    {
        public List<GcJourneyMilestoneData> Table; // called GcJourneyMilestoneTable in the exe
    }
}

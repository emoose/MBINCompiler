using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA34C759C950C6269, NameHash = 0x51722EF5)]
    public class GcJourneyMilestoneTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcJourneyMilestoneData> JourneyMilestoneTable;
    }
}

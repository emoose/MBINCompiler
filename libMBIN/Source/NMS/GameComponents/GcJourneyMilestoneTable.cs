using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA0C8BE3A4DC01E1F, NameHash = 0xD2E65AA0EC314D9C)]
    public class GcJourneyMilestoneTable : NMSTemplate
    {
        /* 0x0 */ public List<GcJourneyMilestoneData> JourneyMilestoneTable;
    }
}

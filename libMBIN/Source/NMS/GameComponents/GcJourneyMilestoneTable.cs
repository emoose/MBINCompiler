using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7E8338B7E91B5EFD, NameHash = 0xD2E65AA0EC314D9C)]
    public class GcJourneyMilestoneTable : NMSTemplate
    {
        /* 0x0 */ public List<GcJourneyMilestoneData> JourneyMilestoneTable;
    }
}

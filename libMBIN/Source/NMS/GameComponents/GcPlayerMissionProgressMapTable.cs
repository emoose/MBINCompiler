using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE4A305017D6CC09A, NameHash = 0x5A66ABB94CAE9E65)]
    public class GcPlayerMissionProgressMapTable : NMSTemplate
    {
        /* 0x0 */ public List<GcPlayerMissionProgressMapEntry> MissionProgressTable;
    }
}

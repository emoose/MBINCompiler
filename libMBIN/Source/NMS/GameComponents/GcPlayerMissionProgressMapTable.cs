using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x97711ED5616C8AA0, NameHash = 0x5A66ABB94CAE9E65)]
    public class GcPlayerMissionProgressMapTable : NMSTemplate
    {
        /* 0x0 */ public List<GcPlayerMissionProgressMapEntry> MissionProgressTable;
    }
}

using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7F202A350B88E87F, NameHash = 0x9EC89436)]
    public class GcPlayerMissionProgressMapTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcPlayerMissionProgressMapEntry> MissionProgressTable;
    }
}

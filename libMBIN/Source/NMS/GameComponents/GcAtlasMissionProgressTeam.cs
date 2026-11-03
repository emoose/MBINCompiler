using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1356177FE22BEB72, NameHash = 0xD46A78BB)]
    public class GcAtlasMissionProgressTeam : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public List<GcAtlasMissionProgressTarget> MissionTypes;
        [NMS(Index = 3)]
        /* 0x10 */ public int TeamSize;
        [NMS(Index = 1)]
        /* 0x14 */ public int TeamTotal;
        [NMS(Index = 0)]
        /* 0x18 */ public NMSString0x20 TeamName;
    }
}

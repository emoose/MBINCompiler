using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x177B3218B232724B, NameHash = 0x48911A28)]
    public class GcAtlasMissionProgress : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcAtlasMissionProgressTeam> Teams;
        [NMS(Index = 0)]
        /* 0x10 */ public int OverallTotal;
    }
}

using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBBFE0F2CE9AEC23, NameHash = 0x70AD46A6)]
    public class GcNPCWordReactionList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcNPCProbabilityWordReactionData> Reactions;
    }
}

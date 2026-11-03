using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD3FE2478F957D9C1, NameHash = 0x5589CB5C)]
    public class GcNPCReactionData : NMSTemplate
    {
        [NMS(Index = 1, Size = 0xA, EnumType = typeof(GcGameTableNPCEventTrigger.GameTableNPCEventTriggerEnum))]
        /* 0x000 */ public GcGameTableNPCEventReactionData[] GameTableEventReactions;
        [NMS(Index = 0)]
        /* 0x3C0 */ public List<GcNPCReactionEntry> Reactions;
    }
}

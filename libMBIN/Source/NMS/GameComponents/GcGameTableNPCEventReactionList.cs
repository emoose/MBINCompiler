using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x11BE5ADB3481D18F, NameHash = 0xCD3146AC)]
    public class GcGameTableNPCEventReactionList : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public List<GcNPCProbabilityReactionData> Animations;
        [NMS(Index = 2)]
        /* 0x10 */ public float MinEventScale;
        [NMS(Index = 0)]
        /* 0x14 */ public float Priority;
        [NMS(Index = 1)]
        /* 0x18 */ public float ReactionChance;
    }
}

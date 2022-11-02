using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x30967D0505873B30, NameHash = 0x55C21F4B95AD18C8)]
    public class GcNPCReactionEntry : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Emote;
        /* 0x10 */ public float ReactionChance;
        /* 0x18 */ public List<GcNPCProbabilityReactionData> Animations;
    }
}

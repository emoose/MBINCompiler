using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF931960224E27A21, NameHash = 0xF3A35A6135FAD505)]
    public class GcNPCAnimationSetData : NMSTemplate
    {
        /* 0x00 */ public List<GcNPCProbabilityAnimationData> IdleAnimations;
        /* 0x10 */ public List<GcNPCProbabilityAnimationData> IdleFlavourAnimations;
        /* 0x20 */ public List<GcNPCProbabilityAnimationData> ChatterAnimations;
        /* 0x30 */ public List<GcNPCProbabilityAnimationData> ListenAnimations;
        /* 0x40 */ public List<GcNPCProbabilityAnimationData> GreetAnimations;
        [NMS(Size = 0x9, EnumType = typeof(GcAlienMood.MoodEnum))]
        /* 0x50 */ public GcNPCAnimationList[] MoodAnims;
        [NMS(Size = 0x9, EnumType = typeof(GcAlienMood.MoodEnum))]
        /* 0xE0 */ public NMSString0x10[] MoodLoops;
    }
}

using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x800475F1A53F5F3F, NameHash = 0xB22ADF60)]
    public class GcNPCAnimationSetData : NMSTemplate
    {
        [NMS(Index = 5, Size = 0xA, EnumType = typeof(GcAlienMood.MoodEnum))]
        /* 0x000 */ public GcNPCAnimationList[] MoodAnims;
        [NMS(Index = 6, Size = 0xA, EnumType = typeof(GcAlienMood.MoodEnum))]
        /* 0x0A0 */ public NMSString0x10[] MoodLoops;
        [NMS(Index = 2)]
        /* 0x140 */ public List<GcNPCProbabilityAnimationData> ChatterAnimations;
        [NMS(Index = 4)]
        /* 0x150 */ public List<GcNPCProbabilityAnimationData> GreetAnimations;
        [NMS(Index = 0)]
        /* 0x160 */ public List<GcNPCProbabilityAnimationData> IdleAnimations;
        [NMS(Index = 1)]
        /* 0x170 */ public List<GcNPCProbabilityAnimationData> IdleFlavourAnimations;
        [NMS(Index = 3)]
        /* 0x180 */ public List<GcNPCProbabilityAnimationData> ListenAnimations;
    }
}

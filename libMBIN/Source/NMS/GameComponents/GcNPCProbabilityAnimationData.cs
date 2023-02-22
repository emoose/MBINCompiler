using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF23879D569337348, NameHash = 0x6ECD1E12A5E7A194)]
    public class GcNPCProbabilityAnimationData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        /* 0x10 */ public float Probability;
        // size: 0x4
        public enum AnimationIntensityEnum {
            Low,
            Medium,
            High,
            None,
        }
        /* 0x14 */ public AnimationIntensityEnum AnimationIntensity;
        /* 0x18 */ public List<GcAlienRace> ExcludeRace;
        /* 0x28 */ public List<NMSString0x10> Tags;
    }
}

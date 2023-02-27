using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC871D35B9F8AAF33, NameHash = 0x260459086692280D)]
    public class GcNPCProbabilityReactionData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        /* 0x10 */ public float Probability;
        /* 0x18 */ public List<GcNPCRaceProbabilityModifierData> RaceModifiers;
    }
}

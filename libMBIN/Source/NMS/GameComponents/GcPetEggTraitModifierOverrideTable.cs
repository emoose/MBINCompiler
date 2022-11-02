using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9269376D0CE8D9A5, NameHash = 0x34EE54AA314E3EDF)]
    public class GcPetEggTraitModifierOverrideTable : NMSTemplate
    {
        /* 0x0 */ public List<GcPetEggTraitModifierOverrideData> TraitModifiers;
    }
}

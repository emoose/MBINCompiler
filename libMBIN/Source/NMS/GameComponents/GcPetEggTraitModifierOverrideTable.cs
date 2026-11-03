using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA58B538A86A9DF73, NameHash = 0xB7FB7F0F)]
    public class GcPetEggTraitModifierOverrideTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcPetEggTraitModifierOverrideData> TraitModifiers;
    }
}

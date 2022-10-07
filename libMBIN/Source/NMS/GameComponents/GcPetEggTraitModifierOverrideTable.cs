using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6403DD26A54F5F36, NameHash = 0x34EE54AA314E3EDF)]
    public class GcPetEggTraitModifierOverrideTable : NMSTemplate
    {
        /* 0x0 */ public List<GcPetEggTraitModifierOverrideData> TraitModifiers;
    }
}

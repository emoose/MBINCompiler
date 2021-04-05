using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x1C, GUID = 0x0000000000000000, NameHash = 0x0DCD830657AF1993)]
    public class GcPetTraitStaminaModifier : NMSTemplate
    {
        /* 0x00 */ public GcCreaturePetTraits Trait;
        /* 0x04 */ public float TraitMin;
        /* 0x04 */ public float TraitMax;
        /* 0x04 */ public float StaminaDrainModifierMin;
        /* 0x04 */ public float StaminaDrainModifierMax;
        /* 0x04 */ public float StaminaRechargeModifierMin;
        /* 0x04 */ public float StaminaRechargeModifierMax;
    }
}

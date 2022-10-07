using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAE4A96D14E7797E5, NameHash = 0xDCD830657AF1993)]
    public class GcPetTraitStaminaModifier : NMSTemplate
    {
        /* 0x00 */ public GcCreaturePetTraits Trait;
        /* 0x04 */ public float TraitMin;
        /* 0x08 */ public float TraitMax;
        /* 0x0C */ public float StaminaDrainModifierMin;
        /* 0x10 */ public float StaminaDrainModifierMax;
        /* 0x14 */ public float StaminaRechargeModifierMin;
        /* 0x18 */ public float StaminaRechargeModifierMax;
    }
}

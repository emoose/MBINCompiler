using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x68467CCF27503B67, NameHash = 0xE41D8EA9BE5AA4F8)]
    public class GcPetBehaviourTraitModifier : NMSTemplate
    {
        /* 0x00 */ public GcCreaturePetTraits Trait;
        /* 0x04 */ public float TraitMin;
        /* 0x08 */ public float TraitMax;
        /* 0x0C */ public float WeightModifierMin;
        /* 0x10 */ public float WeightModifierMax;
        /* 0x14 */ public float CooldownModifierMin;
        /* 0x18 */ public float CooldownModifierMax;
    }
}

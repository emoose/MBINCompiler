using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF6E744738237701D, NameHash = 0xD3ED2C768AB1847C)]
    public class GcPetTraitMoodModifierList : NMSTemplate
    {
        [NMS(Size = 0x2, EnumType = typeof(GcCreaturePetMood.PetMoodEnum))]
        /* 0x0 */ public GcPetTraitMoodModifier[] Modifiers;
    }
}

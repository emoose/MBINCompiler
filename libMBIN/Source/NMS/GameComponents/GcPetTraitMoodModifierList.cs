using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE9DDE63F701FF8D0, NameHash = 0x96E981DC)]
    public class GcPetTraitMoodModifierList : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x2, EnumType = typeof(GcCreaturePetMood.PetMoodEnum))]
        /* 0x0 */ public GcPetTraitMoodModifier[] Modifiers;
    }
}

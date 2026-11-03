using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCABB8E2071ADEB9A, NameHash = 0x1556B82B)]
    public class GcPetActionMoodModifier : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x2, EnumType = typeof(GcCreaturePetMood.PetMoodEnum))]
        /* 0x0 */ public float[] MoodModifiers;
    }
}

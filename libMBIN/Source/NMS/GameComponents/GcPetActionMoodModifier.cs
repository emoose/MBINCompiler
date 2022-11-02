namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x74FF85B64E55CAFD, NameHash = 0xEB530C995C41BAF0)]
    public class GcPetActionMoodModifier : NMSTemplate
    {
        [NMS(Size = 0x2, EnumType = typeof(GcCreaturePetMood.PetMoodEnum))]
        /* 0x0 */ public float[] MoodModifiers;
    }
}

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8E3642E410CB8983, NameHash = 0xEB530C995C41BAF0)]
    public class GcPetActionMoodModifier : NMSTemplate
    {
        // size: 0x2
        public enum MoodModifiersEnum {
            Hungry,
            Lonely
        }
        [NMS(Size = 0x2, EnumType = typeof(MoodModifiersEnum))]
        /* 0x0 */ public float[] MoodModifiers;
    }
}

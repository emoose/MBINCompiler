namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1AC7B635602FC45A, NameHash = 0x2581D5C5DE2A6E6)]
    public class GcCreaturePetMood : NMSTemplate
    {
        // size: 0x2
        public enum PetMoodEnum {
            Hungry,
            Lonely
        }
        /* 0x0 */ public PetMoodEnum PetMood;
    }
}

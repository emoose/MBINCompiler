namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7DE22E5EE0D17D77, NameHash = 0xCC5B47BB)]
    public class GcCreaturePetMood : NMSTemplate
    {
        // size: 0x2
        public enum PetMoodEnum : uint {
            Hungry,
            Lonely,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PetMoodEnum PetMood;
    }
}

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCF3B4EE88158EA5E, NameHash = 0x2B863F63)]
    public class GcPetVocabularyWords : NMSTemplate
    {
        // size: 0xF
        public enum PetVocabularyWordEnum : uint {
            Attack,
            Dislike,
            Cute,
            Good,
            Happy,
            Hostile,
            Like,
            Lonely,
            Loved,
            Noise,
            OwnerLove,
            SummonedTrait,
            Hungry,
            Tickles,
            Yummy,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PetVocabularyWordEnum PetVocabularyWord;
    }
}

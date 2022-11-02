namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x89419CA1628D820B, NameHash = 0xDCBFB26222DD9DE6)]
    public class GcPetVocabularyWords : NMSTemplate
    {
        // size: 0xF
        public enum PetVocabularyWordEnum {
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
            Yummy
        }
        /* 0x0 */ public PetVocabularyWordEnum PetVocabularyWord;
    }
}

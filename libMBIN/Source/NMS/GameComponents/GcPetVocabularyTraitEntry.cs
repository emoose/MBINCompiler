using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA055504BF90A3AA6, NameHash = 0xD1AA1B644B5DE736)]
    public class GcPetVocabularyTraitEntry : NMSTemplate
    {
        /* 0x00 */ public GcCreaturePetTraits Trait;
        /* 0x08 */ public NMSString0x20A Positive;
        /* 0x28 */ public NMSString0x20A Negative;
    }
}

using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x314DBE043AC75F77, NameHash = 0x9CAD8AC4)]
    public class GcPetEggTraitModifierOverrideData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ProductID;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 SubstanceID;
        [NMS(Index = 4)]
        /* 0x20 */ public int BaseValueOverride;
        [NMS(Index = 2)]
        /* 0x24 */ public GcCreaturePetTraits Trait;
        [NMS(Index = 3)]
        /* 0x28 */ public bool IncreasesTrait;
    }
}

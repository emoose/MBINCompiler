using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x27A88BDEEE5ED818, NameHash = 0x55F9EF59F3B21D8)]
    public class GcCreaturePetTraitRanges : NMSTemplate
    {
        [NMS(Size = 0x3, EnumType = typeof(GcCreaturePetTraits.PetTraitEnum))]
        /* 0x0 */ public GcCreaturePetTraitRange[] TraitRanges;
    }
}

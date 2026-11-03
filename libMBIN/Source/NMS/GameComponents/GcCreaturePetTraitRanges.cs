using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x44081C3F4481DAB9, NameHash = 0x52960A16)]
    public class GcCreaturePetTraitRanges : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x3, EnumType = typeof(GcCreaturePetTraits.PetTraitEnum))]
        /* 0x0 */ public GcCreaturePetTraitRange[] TraitRanges;
    }
}

using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC0C793FFA12CE763, NameHash = 0x55F9EF59F3B21D8)]
    public class GcCreaturePetTraitRanges : NMSTemplate
    {
        // size: 0x3
        public enum TraitRangesEnum {
            Helpfulness,
            Aggression,
            Independence
        }
        [NMS(Size = 0x3, EnumType = typeof(TraitRangesEnum))]
        /* 0x0 */ public GcCreaturePetTraitRange[] TraitRanges;
    }
}

using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0xB90FB4F173367E1B, NameHash = 0x055F9EF59F3B21D8)]
    public class GcCreaturePetTraitRanges : NMSTemplate
    {
        [NMS(Size = 0x3, EnumType = typeof(GcCreaturePetTraits.PetTraitsEnum))]
        public GcCreaturePetTraitRange[] TraitRanges;
    }
}

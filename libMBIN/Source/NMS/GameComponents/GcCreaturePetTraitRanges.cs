using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0xE8D57E7EBF9DE772, NameHash = 0x55F9EF59F3B21D8)]
    public class GcCreaturePetTraitRanges : NMSTemplate
    {
        /* 0x0 */ public List<GcCreaturePetTraitRange> TraitRanges;
    }
}

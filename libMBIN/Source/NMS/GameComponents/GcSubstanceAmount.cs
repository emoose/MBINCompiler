using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x30, GUID = 0x0000000000000000, NameHash = 0x87586DC48C5F162B)]
    public class GcSubstanceAmount : NMSTemplate
    {
        /* 0x00 */ public int AmountMin;
        /* 0x04 */ public int AmountMax;
        [NMS(Size = 0x10)]
        /* 0x08 */ public string Specific;
        [NMS(Size = 0x10)]
        /* 0x18 */ public string SpecificSecondary;
        /* 0x28 */ public GcRealitySubstanceCategory Category;
        /* 0x2C */ public GcRarity Rarity;
    }
}

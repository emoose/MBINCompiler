using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2FFC1ED59FABDEE1, NameHash = 0x390E6B7795024BAB)]
    public class GcSubstanceTable : NMSTemplate
    {
        /* 0x00 */ public List<GcRealitySubstanceData> Table;
        /* 0x10 */ public List<GcRealityCraftingRecipeData> Crafting;
    }
}

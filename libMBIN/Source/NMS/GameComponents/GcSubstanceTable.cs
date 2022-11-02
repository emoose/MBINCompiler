using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x727564DAA350B1B5, NameHash = 0x390E6B7795024BAB)]
    public class GcSubstanceTable : NMSTemplate
    {
        /* 0x00 */ public List<GcRealitySubstanceData> Table;
        /* 0x10 */ public List<GcRealityCraftingRecipeData> Crafting;
    }
}

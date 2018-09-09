using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0CA9782C4E180BB)]
    public class GcSubstanceTable : NMSTemplate
    {
        public List<GcRealitySubstanceData> Table;
        public List<GcRealityCraftingRecipeData> Crafting;
    }
}

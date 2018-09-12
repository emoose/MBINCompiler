using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x50, GUID = 0x0FD3B29318714667E)]
    public class GcCostTable : NMSTemplate
    {
        public List<GcCostTableEntry> SimpleInteractionTable;
        public List<GcCostTableEntry> InteractionTable;
        public List<GcCostTableEntry> ItemCostsTable;
        public List<GcCostTableEntry> AtlasPathCosts;
        public List<GcCostTableEntry> UnusedCostsTable;
    }
}

using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x50, GUID = 0xFD3B29318714667E)]
    public class GcCostTable : NMSTemplate
    {
        public List<GcCostTableEntry> SimpleInteractionTable;
        public List<GcCostTableEntry> InteractionTable;
        public List<GcCostTableEntry> ItemCostsTable;
        public List<GcCostTableEntry> AtlasPathCosts;
        public List<GcCostTableEntry> UnusedCostsTable;
    }
}

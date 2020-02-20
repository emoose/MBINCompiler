using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x50, GUID = 0x506BCAC7DB4FD1CB, NameHash = 0x6E62CCB542C4E505)]
    public class GcCostTable : NMSTemplate
    {
        public List<GcCostTableEntry> SimpleInteractionTable;
        public List<GcCostTableEntry> InteractionTable;
        public List<GcCostTableEntry> ItemCostsTable;
        public List<GcCostTableEntry> AtlasPathCosts;
        public List<GcCostTableEntry> UnusedCostsTable;
    }
}

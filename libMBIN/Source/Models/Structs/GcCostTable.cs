using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcCostTable : NMSTemplate
    {
        public List<GcCostTableEntry> SimpleInteractionTable;
        public List<GcCostTableEntry> InteractionTable;
    }
}

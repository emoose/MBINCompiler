using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcCostTable : NMSTemplate
    {
        public List<GcCostTableEntry> SimpleInteractionTable;
        public List<GcCostTableEntry> InteractionTable;
    }
}

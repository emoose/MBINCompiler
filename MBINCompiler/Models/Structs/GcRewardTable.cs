using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcRewardTable : NMSTemplate
    {
        public List<GcRewardTableEntry> Table;
        public List<GcGenericRewardTableEntry> GenericTable;
        public List<GcGenericRewardTableEntry> InteractionTable;
        public List<GcGenericRewardTableEntry> EntitlementTable;
        public List<NMSString0x10> TechRewardOrder;
        public List<NMSString0x10> ProductRewardOrder;
    }
}

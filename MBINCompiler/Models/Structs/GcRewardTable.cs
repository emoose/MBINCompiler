using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcRewardTable
    {
        public List<GcRewardTableEntry> Table;
        public List<GcGenericRewardTableEntry> GenericTable;
        public List<GcGenericRewardTableEntry> InteractionTable;
        public List<GcGenericRewardTableEntry> EntitlementTable;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string TechRewardOrder;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string ProductRewardOrder;
    }
}

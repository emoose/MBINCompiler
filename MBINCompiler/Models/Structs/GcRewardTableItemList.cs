using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcRewardTableItemList : NMSTemplate
    {
        public bool EntitlementLinked;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
        public string EntitlementId;
        public GcRewardTableChoice RewardChoice; // enum
        public List<GcRewardTableItem> List;
    }
}

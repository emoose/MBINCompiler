using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcRewardTableItemList
    {
        public bool EntitlementLinked;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string EntitlementId;

        public string[] RewardChoice() {
            return new[] { "GiveAll", "Select", "TryEach" };
        }

        public List<GcRewardTableItem> List;
    }
}

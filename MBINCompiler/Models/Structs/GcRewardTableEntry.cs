using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcRewardTableEntry : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Id;
        public GcRewardTableCategory Common; // This actually is a GcRewardTableCategory[3], values are GcRarity
        public GcRewardTableCategory Uncommon;
        public GcRewardTableCategory Rare;
    }
}

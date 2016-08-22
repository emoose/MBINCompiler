using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcRewardTableItem
    {
        public float PercentageChance;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string LabelID;
    }
}

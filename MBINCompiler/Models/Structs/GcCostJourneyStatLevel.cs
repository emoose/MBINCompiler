using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcCostJourneyStatLevel : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string StatName;
        public int RequiredLevel;
    }
}

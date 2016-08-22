using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcCostTableEntry : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Id;
        public NMSTemplate Entry;
    }
}

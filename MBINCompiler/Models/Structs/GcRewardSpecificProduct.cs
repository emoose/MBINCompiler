using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcRewardSpecificProduct : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Id;
        public int AmountMin;
        public int AmountMax;
    }
}

using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcRewardAction : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Reward;
    }
}

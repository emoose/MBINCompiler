using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcRewardDamage : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string PlayerDamage;
    }
}

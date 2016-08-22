using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcCreatureHealthData : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string HurtAnim;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string DeathAnim;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string DeathEffect;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string HurtAudio;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string DeathAudio;
    }
}

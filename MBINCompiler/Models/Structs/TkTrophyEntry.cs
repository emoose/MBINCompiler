using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class TkTrophyEntry : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string TrophyId;
        public int Ps4Id;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x40)]
        public string PCId;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [NMSAttribute(Ignore = true)]
        public byte[] Padding54;
    }
}

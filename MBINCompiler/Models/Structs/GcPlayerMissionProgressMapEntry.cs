using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcPlayerMissionProgressMapEntry : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Mission;
        public int MinProgress;
        public int MaxProgress;
        public int NewProgress;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] Padding1C;
    }
}

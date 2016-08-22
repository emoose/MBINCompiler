using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcJourneyMilestoneData : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string JourneyMilestoneId;
        public int PointsToUnlock;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] Padding14;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
        public string JourneyMilestoneTitle;
    }
}

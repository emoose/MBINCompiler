using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcAISpaceshipPreloadCacheData : NMSTemplate
    {
        public GcAISpaceshipRoles ShipRole;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [NMSAttribute(Ignore = true)]
        public byte[] Padding4;

        public GcSeed Seed;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x100)]
        public string AltId;
    }
}

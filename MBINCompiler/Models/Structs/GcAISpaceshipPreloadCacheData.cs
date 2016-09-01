using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcAISpaceshipPreloadCacheData : NMSTemplate
    {
        public GcAISpaceshipRoles ShipRole;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding4;

        public GcSeed Seed;
        [NMS(Size = 0x100)]
        public string AltId;
    }
}

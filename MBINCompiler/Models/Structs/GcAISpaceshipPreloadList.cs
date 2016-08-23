using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcAISpaceshipPreloadList : NMSTemplate
    {
        public GcRealityCommonFactions Faction;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] Padding4;

        public List<GcAISpaceshipPreloadCacheData> Cache;
    }
}

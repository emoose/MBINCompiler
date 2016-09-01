using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcAISpaceshipPreloadList : NMSTemplate
    {
        public GcRealityCommonFactions Faction;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding4;

        public List<GcAISpaceshipPreloadCacheData> Cache;
    }
}

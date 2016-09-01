using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcStatsGroup : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;

        public TkTextureResource Icon;

        public List<GcStatsEntry> StatIds;
    }
}

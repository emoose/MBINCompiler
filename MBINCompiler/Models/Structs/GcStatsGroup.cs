using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcStatsGroup : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;

        public TkTextureResource Icon;

        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding94;

        public List<GcStatsEntry> StatIds;
    }
}

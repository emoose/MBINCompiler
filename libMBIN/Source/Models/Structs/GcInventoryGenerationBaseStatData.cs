using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcInventoryGenerationBaseStatData : NMSTemplate     // size: 0x40
    {
        [NMS(Size = 0x4, EnumValue = new[] { "C", "B", "A", "S" })]
        public GcInventoryGenerationBaseStatClassData[] BaseStatsPerClass;

    }
}

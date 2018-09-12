using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0EE43876427F39D95)]
    public class GcInventoryGenerationBaseStatData : NMSTemplate     // size: 0x40
    {
        [NMS(Size = 0x4, EnumValue = new[] { "C", "B", "A", "S" })]
        public GcInventoryGenerationBaseStatClassData[] BaseStatsPerClass;

    }
}

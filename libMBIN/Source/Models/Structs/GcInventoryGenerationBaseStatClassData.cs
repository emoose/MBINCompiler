using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x3F821EFA320B5781)]
    public class GcInventoryGenerationBaseStatClassData : NMSTemplate     // size: 0x10
    {
        public List<GcInventoryGenerationBaseStatDataEntry> BaseStats;
    }
}

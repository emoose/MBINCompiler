using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0DDE56711938E1BC7)]
    public class GcInventoryLayoutGenerationDataEntry : NMSTemplate     // size: 0x10
    {
        public int MinSlots;            // 1
        public int MaxSlots;            // 5
        public int MinExtraTech;        // 1
        public int MaxExtraTech;        // 3
    }
}

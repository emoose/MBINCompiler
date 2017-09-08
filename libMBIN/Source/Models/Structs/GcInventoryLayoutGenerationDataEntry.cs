using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcInventoryLayoutGenerationDataEntry : NMSTemplate     // size: 0x10
    {
        public int MinSlots;            // 1
        public int MaxSlots;            // 5
        public int MinExtraTech;        // 1
        public int MaxExtraTech;        // 3
    }
}

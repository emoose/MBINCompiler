using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcInventoryCostData : NMSTemplate     // size: 0xF0
    {
        [NMS(Size = 0x6, EnumValue = new[] { "Freighter", "Dropship", "Fighter", "Scientific", "Shuttle", "PlayerFreighter" })]
        public GcInventoryCostDataEntry[] InventoryCostData;

    }
}

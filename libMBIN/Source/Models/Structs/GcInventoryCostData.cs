using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcInventoryCostData : NMSTemplate     // size: 0x118
    {
        [NMS(Size = 0x7, EnumValue = new[] { "Freighter", "Dropship", "Fighter", "Scientific", "Shuttle", "PlayerFreighter", "Royal" })]
        public GcInventoryCostDataEntry[] InventoryCostData;

    }
}

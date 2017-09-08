using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcInventoryBaseStat : NMSTemplate      // size: 0x30
    {
        [NMS(Size = 0x10)]
        public string BaseStatID;
        [NMS(Size = 0x10)]
        public string LocID;
        public List<GcInventoryBaseStatBonus> StatBonus;
    }
}

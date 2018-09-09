using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x3C395590D46FB92D)]
    public class GcInventoryBaseStat : NMSTemplate      // size: 0x30
    {
        [NMS(Size = 0x10)]
        public string BaseStatID;
        [NMS(Size = 0x10)]
        public string LocID;
        public List<GcInventoryBaseStatBonus> StatBonus;
    }
}

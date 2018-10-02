using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0x1B2C54550056695)]
    public class GcInventoryBaseStat : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string BaseStatID;
        [NMS(Size = 0x10)]
        public string LocID;
        public List<GcInventoryBaseStatBonus> StatBonus;
    }
}

using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0x4A8C5FA4CFCF2918)]
    public class GcInventoryBaseStat : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string BaseStatID;
        [NMS(Size = 0x10)]
        public string LocID;
        public List<GcInventoryBaseStatBonus> StatBonus;
    }
}

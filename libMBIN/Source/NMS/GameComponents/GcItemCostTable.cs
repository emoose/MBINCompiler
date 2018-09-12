using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0EC55A7DD450FE529)]
    public class GcItemCostTable : NMSTemplate        // size: 0x10
    {
        public List<GcItemCostData> Items;
    }
}

using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x69358F476B7A6AB9, NameHash = 0xF3A6F2D8DFF9DF48)]
    public class GcItemCostTable : NMSTemplate
    {
        /* 0x0 */ public List<GcItemCostData> Items;
    }
}

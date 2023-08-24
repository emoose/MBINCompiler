using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x637D77EC9C82F0E8, NameHash = 0x20D1A01C0454CD5B)]
    public class GcCostItemFromListOfValue : NMSTemplate
    {
        /* 0x00 */ public int UnitValue;
        /* 0x04 */ public bool UseDefaultAmount;
        /* 0x08 */ public List<NMSString0x10> ItemList;
        /* 0x18 */ public NMSString0x20A CostText;
    }
}

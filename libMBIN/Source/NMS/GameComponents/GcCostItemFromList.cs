using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3CFA999F9B2E42A4, NameHash = 0xD9C971EFC16BB550)]
    public class GcCostItemFromList : NMSTemplate
    {
        /* 0x00 */ public int Amount;
        /* 0x08 */ public List<NMSString0x10> ItemList;
        /* 0x18 */ public int Index;
    }
}

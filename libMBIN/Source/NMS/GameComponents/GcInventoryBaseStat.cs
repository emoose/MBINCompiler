using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8F941504516BA58F, NameHash = 0x88CEC164B6BD4ACC)]
    public class GcInventoryBaseStat : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 BaseStatID;
        /* 0x10 */ public NMSString0x10 LocID;
        /* 0x20 */ public List<GcInventoryBaseStatBonus> StatBonus;
    }
}

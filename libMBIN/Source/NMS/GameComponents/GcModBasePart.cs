using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x6C0, GUID = 0x5F6B88A9CACFEE0A, NameHash = 0x6A104C45E1F1638D)]
    public class GcModBasePart : NMSTemplate
    {
        [NMS(Size = 0x40)]
        /* 0x000 */ public string ID;
        /* 0x040 */ public GcProductData ProductData;
        /* 0x440 */ public GcBaseBuildingEntry PartData;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x6B8 */ public byte[] EndPadding;
    }
}

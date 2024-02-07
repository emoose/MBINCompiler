using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE2BE017BD772861E, NameHash = 0x6A104C45E1F1638D)]
    public class GcModBasePart : NMSTemplate
    {
        /* 0x000 */ public NMSString0x40 ID;
        /* 0x040 */ public GcProductData ProductData;
        /* 0x470 */ public GcBaseBuildingEntry PartData;
    }
}

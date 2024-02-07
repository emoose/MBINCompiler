using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC5F5913EB239C1CF, NameHash = 0xCF538100E4D1C218)]
    public class GcRewardTableCategory : NMSTemplate
    {
        [NMS(Size = 0x3, EnumType = typeof(GcSizeIndicator.SizeIndicatorEnum))]
        /* 0x0 */ public GcRewardTableItemList[] Sizes;
    }
}

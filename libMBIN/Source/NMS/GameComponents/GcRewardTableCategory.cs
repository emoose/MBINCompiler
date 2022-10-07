using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE71AE7672337254C, NameHash = 0xCF538100E4D1C218)]
    public class GcRewardTableCategory : NMSTemplate
    {
        // size: 0x3
        public enum SizesEnum {
            Small,
            Medium,
            Large
        }
        [NMS(Size = 0x3, EnumType = typeof(SizesEnum))]
        /* 0x0 */ public GcRewardTableItemList[] Sizes;
    }
}

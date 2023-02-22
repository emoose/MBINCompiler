namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8BE6A0FD938188A4, NameHash = 0x77128F31CC435E5F)]
    public class GcWonderCategoryConfig : NMSTemplate
    {
        // size: 0x2
        public enum WonderCategoryComparisonTypeEnum {
            Max,
            Min,
        }
        /* 0x00 */ public WonderCategoryComparisonTypeEnum WonderCategoryComparisonType;
        /* 0x04 */ public float ThresholdValue;
        /* 0x08 */ public NMSString0x20A LocID;
        /* 0x28 */ public NMSString0x10 StatID;
    }
}

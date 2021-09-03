using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x4, GUID = 0xF9CCCBD06A0F56FB, NameHash = 0x2412AB95A81851E8, Broken = true)]
    public class TkBlackboardComparisonTypeEnum : NMSTemplate
    {
        // size: 0x6
        public enum ComparisonTypeEnum { Equal, NotEqual, GreaterThan, GreaterThanEqual, LessThan, LessThanEqual }
        public ComparisonTypeEnum ComparisonType;
    }
}

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xF515DBCBD42950AD, NameHash = 0x469C6DA)]
    public class TkBlackboardComparisonTypeEnum : NMSTemplate
    {
        // size: 0x6
        public enum ComparisonTypeEnum : uint {
            Equal,
            NotEqual,
            GreaterThan,
            GreaterThanEqual,
            LessThan,
            LessThanEqual,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ComparisonTypeEnum ComparisonType;
    }
}

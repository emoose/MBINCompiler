namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA7B0203D7C546BAD, NameHash = 0x5A1A175F)]
    public class GcMonth : NMSTemplate
    {
        // size: 0xC
        public enum MonthEnum : uint {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MonthEnum Month;
    }
}

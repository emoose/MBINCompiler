namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x957A4A0C9EE64372, NameHash = 0x498BE03D1C172203)]
    public class GcMonth : NMSTemplate
    {
        // size: 0xC
        public enum MonthEnum {
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
        /* 0x0 */ public MonthEnum Month;
    }
}

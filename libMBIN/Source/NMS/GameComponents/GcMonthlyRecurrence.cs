namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5B1B16D4B4499F1D, NameHash = 0x86AE9524)]
    public class GcMonthlyRecurrence : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public int RecurrenceDay;
        [NMS(Index = 1)]
        /* 0x4 */ public int RecurrenceHour;
        [NMS(Index = 0)]
        /* 0x8 */ public int RecurrenceMinute;
        [NMS(Index = 3)]
        /* 0xC */ public NMSString0x80 DebugText;
    }
}

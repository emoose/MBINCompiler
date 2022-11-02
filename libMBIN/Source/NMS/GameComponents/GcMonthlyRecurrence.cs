namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDC96A2A12BCBBB37, NameHash = 0x5CB869EED69B0A9)]
    public class GcMonthlyRecurrence : NMSTemplate
    {
        /* 0x0 */ public int RecurrenceMinute;
        /* 0x4 */ public int RecurrenceHour;
        /* 0x8 */ public int RecurrenceDay;
        /* 0xC */ public NMSString0x80 DebugText;
    }
}

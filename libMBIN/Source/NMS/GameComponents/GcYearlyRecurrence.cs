using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x83D2C4892CEFB3A3, NameHash = 0x252EDF07EC993BBF)]
    public class GcYearlyRecurrence : NMSTemplate
    {
        /* 0x00 */ public int RecurrenceMinute;
        /* 0x04 */ public int RecurrenceHour;
        /* 0x08 */ public int RecurrenceDay;
        /* 0x0C */ public GcMonth RecurrenceMonth;
        /* 0x10 */ public NMSString0x80 DebugText;
    }
}

using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5A0AC35023DE4745, NameHash = 0xD125D2C7)]
    public class GcWeeklyRecurrence : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public GcDay RecurrenceDay;
        [NMS(Index = 1)]
        /* 0x4 */ public int RecurrenceHour;
        [NMS(Index = 0)]
        /* 0x8 */ public int RecurrenceMinute;
        [NMS(Index = 3)]
        /* 0xC */ public NMSString0x80 DebugText;
    }
}

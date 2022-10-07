using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE475AF3D8A81BB1F, NameHash = 0xB686CC9F04962DFA)]
    public class GcWeeklyRecurrence : NMSTemplate
    {
        /* 0x0 */ public int RecurrenceMinute;
        /* 0x4 */ public int RecurrenceHour;
        /* 0x8 */ public GcDay RecurrenceDay;
        /* 0xC */ public NMSString0x80 DebugText;
    }
}

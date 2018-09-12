namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x90, GUID = 0x83D2C4892CEFB3A3)]
    public class GcYearlyRecurrence : NMSTemplate
    {
        public int RecurrenceMinute;
        public int RecurrenceHour;
        public int RecurrenceDay;
        public GcMonth RecurrenceMonth;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}

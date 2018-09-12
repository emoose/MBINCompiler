namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x8C, GUID = 0x0E475AF3D8A81BB1F)]
    public class GcWeeklyRecurrence : NMSTemplate
    {
        public int RecurrenceMinute;
        public int RecurrenceHour;
        public GcDay RecurrenceDay;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}

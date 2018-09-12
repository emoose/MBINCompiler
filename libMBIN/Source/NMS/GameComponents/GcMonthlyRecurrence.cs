namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x8C, GUID = 0x0D310F208B79E9905)]
    public class GcMonthlyRecurrence : NMSTemplate
    {
        public int RecurrenceMinute;
        public int RecurrenceHour;
        public int RecurrenceDay;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}

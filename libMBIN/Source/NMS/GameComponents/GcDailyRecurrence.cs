using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x88, GUID = 0x9C0682DB63DCCEDE)]
    public class GcDailyRecurrence : NMSTemplate
    {
        public int RecurrenceMinute;
        public int RecurrenceHour;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x8AF7F1C3674147C5)]
    public class GcDay : NMSTemplate
    {
		public enum DayEnum { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
		public DayEnum Day;
    }
}

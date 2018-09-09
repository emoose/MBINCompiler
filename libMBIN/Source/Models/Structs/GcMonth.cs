namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x925B3E4BFE31CAB9)]
    public class GcMonth : NMSTemplate
    {
		public enum MonthEnum { January, February, March, April, May, June, July, August, September, October, November, December }
		public MonthEnum Month;
    }
}

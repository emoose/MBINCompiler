using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x84C13BF671FD2DBE)]
    public class GcDate : NMSTemplate
    {
        public int Minute;
        public int Hour;
        public int Day;
        public GcMonth Month;
        public int Year;
    }
}

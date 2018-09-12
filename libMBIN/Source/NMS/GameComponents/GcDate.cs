using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
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

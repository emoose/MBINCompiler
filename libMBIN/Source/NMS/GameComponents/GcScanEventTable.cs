using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x70C967A0DF23A326)]
    public class GcScanEventTable : NMSTemplate
    {
        public List<GcScanEventData> Events;
    }
}

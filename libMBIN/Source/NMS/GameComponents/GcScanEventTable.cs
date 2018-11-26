using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x9987FBD45541267F)]
    public class GcScanEventTable : NMSTemplate
    {
        public List<GcScanEventData> Events;
    }
}

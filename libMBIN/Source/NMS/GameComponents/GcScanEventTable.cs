using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x532941704438897B)]
    public class GcScanEventTable : NMSTemplate
    {
        public List<GcScanEventData> Events;
    }
}

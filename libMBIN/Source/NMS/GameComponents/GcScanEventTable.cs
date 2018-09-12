using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x532941704438897B)]
    public class GcScanEventTable : NMSTemplate
    {
        public List<GcScanEventData> Events;
    }
}

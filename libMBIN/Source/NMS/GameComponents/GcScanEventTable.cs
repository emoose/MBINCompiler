using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x76B5E710861C0A31, Broken = true)]
    public class GcScanEventTable : NMSTemplate
    {
        public List<GcScanEventData> Events;
    }
}

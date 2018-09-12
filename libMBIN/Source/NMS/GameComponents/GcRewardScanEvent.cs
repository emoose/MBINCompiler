using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4905B2344858BDB3)]
    public class GcRewardScanEvent : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Event;
		public enum ScanEventTableEnum { Space, Planet, Missions, Tutorial }
		public ScanEventTableEnum ScanEventTable;
    }
}

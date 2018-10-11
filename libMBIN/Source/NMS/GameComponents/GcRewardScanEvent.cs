using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Alignment = 0x8, Size = 0x28, GUID = 0x4905B2344858BDB3)]
    public class GcRewardScanEvent : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Event;
		public enum ScanEventTableEnum { Space, Planet, Missions, Tutorial }
		public ScanEventTableEnum ScanEventTable;
        public bool DoAerialScan;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}

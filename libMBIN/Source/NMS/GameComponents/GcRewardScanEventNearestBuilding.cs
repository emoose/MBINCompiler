using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xFB4C5A9F89C74F2D)]
    public class GcRewardScanEventNearestBuilding : NMSTemplate
    {
        public bool DoAerialScan;
        public bool IncludeVisited;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0xE7D8F6DF60098845, NameHash = 0x54AAB4996FB2487B)]
    public class GcRewardAdvancePortalState : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string PortalScanEvent;
    }
}

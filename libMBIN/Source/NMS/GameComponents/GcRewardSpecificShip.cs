using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x54ED68F2ED9A997D, Broken = true)]
    public class GcRewardSpecificShip : NMSTemplate
    {
        public GcResourceElement ShipResource;
        public GcInventoryLayout ShipLayout;
        public GcInventoryContainer ShipInventory;
    }
}

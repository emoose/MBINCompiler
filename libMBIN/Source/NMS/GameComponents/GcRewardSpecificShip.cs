using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0C61E7DBD879C83AE)]
    public class GcRewardSpecificShip : NMSTemplate
    {
        public GcResourceElement ShipResource;
        public GcInventoryLayout ShipLayout;
        public GcInventoryContainer ShipInventory;
    }
}

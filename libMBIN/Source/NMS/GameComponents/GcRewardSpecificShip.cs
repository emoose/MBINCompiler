using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x428, GUID = 0xC48C630109CB3A82, NameHash = 0x977CF58471E48CD1)]
    public class GcRewardSpecificShip : NMSTemplate
    {
        public GcResourceElement ShipResource;
        public GcInventoryLayout ShipLayout;
        public GcInventoryContainer ShipInventory;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x45134A0129932783, NameHash = 0x0B0C58666F58DF1C)]
    public class GcRewardRepairWholeInventory : NMSTemplate
    {
        public enum InventoryToRepairEnum { Personal, PersonalTech, Ship, ShipTech, Freighter, Vehicle, AttachedAbandonedShip }
        public InventoryToRepairEnum InventoryToRepair;
    }
}

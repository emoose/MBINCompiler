namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEE3B2E5A9112AB35, NameHash = 0xB0C58666F58DF1C)]
    public class GcRewardRepairWholeInventory : NMSTemplate
    {
        // size: 0x8
        public enum InventoryToRepairEnum {
            Personal,
            PersonalTech,
            Ship,
            ShipTech,
            Freighter,
            Vehicle,
            AttachedAbandonedShip,
            Weapon,
        }
        /* 0x0 */ public InventoryToRepairEnum InventoryToRepair;
    }
}

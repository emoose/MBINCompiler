namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8B12A7765BF54C2D, NameHash = 0xB0C58666F58DF1C)]
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

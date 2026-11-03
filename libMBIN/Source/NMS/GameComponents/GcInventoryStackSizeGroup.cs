namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x239226C2999AEBD1, NameHash = 0x55730CCA)]
    public class GcInventoryStackSizeGroup : NMSTemplate
    {
        // size: 0xD
        public enum InventoryStackSizeGroupEnum : uint {
            Default,
            Personal,
            PersonalCargo,
            Ship,
            ShipCargo,
            Freighter,
            FreighterCargo,
            Vehicle,
            Chest,
            BaseCapsule,
            MaintenanceObject,
            UIPopup,
            SeasonTransfer,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public InventoryStackSizeGroupEnum InventoryStackSizeGroup;
    }
}

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9C754924B696DACA, NameHash = 0x489841A427B2161E)]
    public class GcInventoryStackSizeGroup : NMSTemplate
    {
        // size: 0xC
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
        }
        /* 0x0 */ public InventoryStackSizeGroupEnum InventoryStackSizeGroup;
    }
}

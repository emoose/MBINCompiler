namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF93B0C364E7CD6F2, NameHash = 0xF6CA47F9F51F553F)]
    public class GcCostInstalledTech : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public float MinChargePercent;
        /* 0x14 */ public bool BurnCharge;
        // size: 0x6
        public enum InventoryToCheckEnum : uint {
            All,
            Suit,
            Ship,
            Weapon,
            Freighter,
            Buggy,
        }
        /* 0x18 */ public InventoryToCheckEnum InventoryToCheck;
    }
}

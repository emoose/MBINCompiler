namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAD945A13D96E16B2, NameHash = 0x15BF5AB9B072AD3)]
    public class GcRewardFillInventoryWithBrokenSlots : NMSTemplate
    {
        // size: 0x7
        public enum InventoryToBreakEnum : uint {
            Ship,
            ShipTech,
            Freighter,
            FreighterTech,
            Vehicle,
            VehicleTech,
            Weapon,
        }
        /* 0x00 */ public InventoryToBreakEnum InventoryToBreak;
        /* 0x04 */ public float FractionOfInventoryToBreak;
        /* 0x08 */ public NMSString0x20 CustomTechFormat;
        /* 0x28 */ public int CustomTechCount;
        /* 0x2C */ public int CustomTechOffset;
    }
}

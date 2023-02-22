using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAB070DA8379B54B1, NameHash = 0xF112AB8FC14A734A)]
    public class GcMissionConditionInventorySlots : NMSTemplate
    {
        // size: 0x4
        public enum InventoryTestEnum {
            Current,
            Personal,
            Ship,
            Vehicle,
        }
        /* 0x0 */ public InventoryTestEnum InventoryTest;
        /* 0x4 */ public int SlotsFree;
        /* 0x8 */ public TkEqualityEnum Test;
        /* 0xC */ public bool TestAllSlotsUnlocked;
        /* 0xD */ public bool TestOnlyMainInventory;
    }
}

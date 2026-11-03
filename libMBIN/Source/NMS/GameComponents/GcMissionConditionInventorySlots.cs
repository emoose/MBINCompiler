using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x618A582DF2C62B69, NameHash = 0x7CC294EF)]
    public class GcMissionConditionInventorySlots : NMSTemplate
    {
        // size: 0x6
        public enum InventoryTestEnum : uint {
            Current,
            Personal,
            Ship,
            Vehicle,
            Weapon,
            CorvetteStorage,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public InventoryTestEnum InventoryTest;
        [NMS(Index = 1)]
        /* 0x4 */ public int SlotsFree;
        [NMS(Index = 2)]
        /* 0x8 */ public TkEqualityEnum Test;
        [NMS(Index = 4)]
        /* 0xC */ public bool TestAllSlotsUnlocked;
        [NMS(Index = 3)]
        /* 0xD */ public bool TestAnySlotOccupied;
        [NMS(Index = 5)]
        /* 0xE */ public bool TestOnlyMainInventory;
    }
}

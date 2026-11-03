using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x94261A9CA7355FF5, NameHash = 0xA8ECA)]
    public class GcWeaponInventoryMaxUpgradeCapacity : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x0 */ public int[] MaxInventoryCapacity;
    }
}

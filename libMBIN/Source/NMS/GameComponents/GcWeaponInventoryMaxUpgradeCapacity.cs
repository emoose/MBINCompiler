namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCD09BA8B338BF3A3, NameHash = 0xC1BA164E8D33C80A)]
    public class GcWeaponInventoryMaxUpgradeCapacity : NMSTemplate
    {
        [NMS(Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x0 */ public int[] MaxInventoryCapacity;
    }
}

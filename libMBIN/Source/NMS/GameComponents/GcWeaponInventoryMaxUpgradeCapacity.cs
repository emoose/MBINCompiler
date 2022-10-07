namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x26B1923F6B885761, NameHash = 0xC1BA164E8D33C80A)]
    public class GcWeaponInventoryMaxUpgradeCapacity : NMSTemplate
    {
        // size: 0x4
        public enum MaxInventoryCapacityEnum {
            C,
            B,
            A,
            S
        }
        [NMS(Size = 0x4, EnumType = typeof(MaxInventoryCapacityEnum))]
        /* 0x0 */ public int[] MaxInventoryCapacity;
    }
}

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9CCE7F992A936F32, NameHash = 0xC51C8A0A49F892DC)]
    public class GcShipInventoryMaxUpgradeCapacity : NMSTemplate
    {
        // size: 0x4
        public enum MaxInventoryCapacityEnum {
            C,
            B,
            A,
            S
        }
        [NMS(Size = 0x4, EnumType = typeof(MaxInventoryCapacityEnum))]
        /* 0x00 */ public int[] MaxInventoryCapacity;
        // size: 0x4
        public enum MaxTechInventoryCapacityEnum {
            C,
            B,
            A,
            S
        }
        [NMS(Size = 0x4, EnumType = typeof(MaxTechInventoryCapacityEnum))]
        /* 0x10 */ public int[] MaxTechInventoryCapacity;
        // size: 0x4
        public enum MaxCargoInventoryCapacityEnum {
            C,
            B,
            A,
            S
        }
        [NMS(Size = 0x4, EnumType = typeof(MaxCargoInventoryCapacityEnum))]
        /* 0x20 */ public int[] MaxCargoInventoryCapacity;
    }
}

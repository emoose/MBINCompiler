namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD42BD8870A05E97F, NameHash = 0x52B0589631E97AC5)]
    public class GcCustomisationComponentData : NMSTemplate
    {
        // size: 0x17
        public enum CustomisationDataTypeEnum : uint {
            Player,
            Vehicle,
            Weapon,
            Ship_01,
            Ship_02,
            Ship_03,
            Ship_04,
            Ship_05,
            Ship_06,
            Vehicle_Bike,
            Vehicle_Truck,
            Vehicle_WheeledBike,
            Vehicle_Hovercraft,
            Vehicle_Submarine,
            Vehicle_Mech,
            Freighter,
            Pet,
            Ship_07,
            Ship_08,
            Ship_09,
            Ship_10,
            Ship_11,
            Ship_12,
        }
        /* 0x0 */ public CustomisationDataTypeEnum CustomisationDataType;
    }
}

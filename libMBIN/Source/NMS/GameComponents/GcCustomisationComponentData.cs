namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4D5483F7E184421E, NameHash = 0x185DE011)]
    public class GcCustomisationComponentData : NMSTemplate
    {
        // size: 0x1A
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
            PirateFreighter,
            Skiff,
            FishingRod,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CustomisationDataTypeEnum CustomisationDataType;
    }
}

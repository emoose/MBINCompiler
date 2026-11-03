namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3625E5E5C470CB54, NameHash = 0xECA62875)]
    public class GcVehicleType : NMSTemplate
    {
        // size: 0x7
        public enum VehicleTypeEnum : uint {
            Buggy,
            Bike,
            Truck,
            WheeledBike,
            Hovercraft,
            Submarine,
            Mech,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public VehicleTypeEnum VehicleType;
    }
}

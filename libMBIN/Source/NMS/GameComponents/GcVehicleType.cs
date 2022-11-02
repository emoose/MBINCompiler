namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAE5CAF6D50A17900, NameHash = 0x46812D05ED43A48D)]
    public class GcVehicleType : NMSTemplate
    {
        // size: 0x7
        public enum VehicleTypeEnum {
            Buggy,
            Bike,
            Truck,
            WheeledBike,
            Hovercraft,
            Submarine,
            Mech
        }
        /* 0x0 */ public VehicleTypeEnum VehicleType;
    }
}

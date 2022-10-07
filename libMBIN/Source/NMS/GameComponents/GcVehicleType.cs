namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD3947F166802A50B, NameHash = 0x46812D05ED43A48D)]
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

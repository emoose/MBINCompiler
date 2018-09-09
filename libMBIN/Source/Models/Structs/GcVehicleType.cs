namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0E314902608C1D464)]
    public class GcVehicleType : NMSTemplate
    {
		public enum VehicleTypeEnum { Buggy, Bike, Truck }
		public VehicleTypeEnum VehicleType;
    }
}

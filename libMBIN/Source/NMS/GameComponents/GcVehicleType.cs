using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xE314902608C1D464)]
    public class GcVehicleType : NMSTemplate
    {
		public enum VehicleTypeEnum { Buggy, Bike, Truck }
		public VehicleTypeEnum VehicleType;
    }
}

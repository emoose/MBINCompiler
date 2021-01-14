using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0xD3947F166802A50B, NameHash = 0x46812D05ED43A48D)]
    public class GcVehicleType : NMSTemplate
    {
		public enum VehicleTypeEnum { Buggy, Bike, Truck, WheeledBike, Hovercraft, Submarine, Mech }
		public VehicleTypeEnum VehicleType;
    }
}

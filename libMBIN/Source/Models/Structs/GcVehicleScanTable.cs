using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x522533AC131BE64B)]
    public class GcVehicleScanTable : NMSTemplate
    {
        public List<GcVehicleScanTableEntry> VehicleScanTable;
    }
}

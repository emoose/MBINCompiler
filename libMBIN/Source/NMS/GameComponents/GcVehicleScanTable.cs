using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x522533AC131BE64B)]
    public class GcVehicleScanTable : NMSTemplate
    {
        public List<GcVehicleScanTableEntry> VehicleScanTable;
    }
}

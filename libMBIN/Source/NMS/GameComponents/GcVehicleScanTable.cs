using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4972EF79C80F1876, NameHash = 0x78967207D9C549AA)]
    public class GcVehicleScanTable : NMSTemplate
    {
        /* 0x0 */ public List<GcVehicleScanTableEntry> VehicleScanTable;
    }
}

using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD23AF7E056C3A481, NameHash = 0x65A159FE)]
    public class GcVehicleScanTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcVehicleScanTableEntry> VehicleScanTable;
    }
}

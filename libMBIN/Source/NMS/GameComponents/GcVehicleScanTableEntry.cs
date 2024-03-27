using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x757E6C85353294DA, NameHash = 0xBAC942D350F478B1)]
    public class GcVehicleScanTableEntry : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x20A> ScanList;
        /* 0x10 */ public NMSString0x20A Name;
        /* 0x30 */ public NMSString0x10 RequiredTech;
        /* 0x40 */ public TkTextureResource Icon;
    }
}

using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcVehicleScanTableEntry : NMSTemplate
    {
        
        /* 0x00 */ public List<NMSString0x10> ScanList;
        [NMS(Size = 0x20)]
        /* 0x20 */ public string Name;
        [NMS(Size = 0x10)]
        /* 0x30 */ public string RequiredTech;
        /* 0x40 */ public TkModelResource Icon;
    }
}
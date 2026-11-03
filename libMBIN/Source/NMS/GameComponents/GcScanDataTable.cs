using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5A04A8C4F1F4B690, NameHash = 0xF50272A)]
    public class GcScanDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcScanDataTableEntry> ScanData;
    }
}

using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x876ED58FE72C5861, NameHash = 0xCC36BB347C3B3DC3)]
    public class GcScanDataTableEntry : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public GcScanData ScanData;
    }
}

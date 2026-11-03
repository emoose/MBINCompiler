using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA9787C20B223766F, NameHash = 0x770F2B4B)]
    public class GcScanDataTableEntry : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcScanData ScanData;
        [NMS(Index = 0)]
        /* 0x30 */ public NMSString0x10 ID;
    }
}

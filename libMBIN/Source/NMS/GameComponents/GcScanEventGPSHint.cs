namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD04B789D2D082C7C, NameHash = 0x77DD38B0)]
    public class GcScanEventGPSHint : NMSTemplate
    {
        // size: 0x8
        public enum ScanEventGPSHintEnum : uint {
            None,
            Accurate,
            OffsetNarrow,
            OffsetMid,
            OffsetWide,
            Obfuscated,
            PartObfuscated,
            BuilderCorruption,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ScanEventGPSHintEnum ScanEventGPSHint;
    }
}

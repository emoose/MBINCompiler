namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB7423885A025C67F, NameHash = 0x5582642D1376644E)]
    public class GcScanEventGPSHint : NMSTemplate
    {
        // size: 0x7
        public enum ScanEventGPSHintEnum {
            None,
            Accurate,
            OffsetNarrow,
            OffsetMid,
            OffsetWide,
            Obfuscated,
            PartObfuscated
        }
        /* 0x0 */ public ScanEventGPSHintEnum ScanEventGPSHint;
    }
}

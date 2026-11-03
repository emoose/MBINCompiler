namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x15D7ABA9C6837E28, NameHash = 0xE3D84E86)]
    public class GcScannerRechargeDifficultyOption : NMSTemplate
    {
        // size: 0x4
        public enum ScannerRechargeDifficultyEnum : uint {
            VeryFast,
            Fast,
            Normal,
            Slow,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ScannerRechargeDifficultyEnum ScannerRechargeDifficulty;
    }
}

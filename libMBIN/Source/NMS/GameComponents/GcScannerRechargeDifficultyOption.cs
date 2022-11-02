namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x605CEF56BB06DFA7, NameHash = 0x5980B3D90F168F60)]
    public class GcScannerRechargeDifficultyOption : NMSTemplate
    {
        // size: 0x4
        public enum ScannerRechargeDifficultyEnum {
            VeryFast,
            Fast,
            Normal,
            Slow
        }
        /* 0x0 */ public ScannerRechargeDifficultyEnum ScannerRechargeDifficulty;
    }
}

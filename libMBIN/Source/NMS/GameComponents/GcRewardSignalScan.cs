namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB353ABC6B8FA855D, NameHash = 0x241A36BA)]
    public class GcRewardSignalScan : NMSTemplate
    {
        // size: 0x8
        public enum SignalScanTypeEnum : uint {
            None,
            DropPod,
            Shelter,
            Search,
            Relic,
            Industrial,
            Alien,
            CrashedFreighter,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SignalScanTypeEnum SignalScanType;
    }
}

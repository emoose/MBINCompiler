namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE09C7A48C557D807, NameHash = 0x77560873BF71CDAB)]
    public class GcStatsValueTypes : NMSTemplate
    {
        // size: 0x4
        public enum StatsValueEnum {
            DistanceJetpacked,
            DistanceWalked,
            DistanceWarped,
            DamageSustained,
        }
        /* 0x0 */ public StatsValueEnum StatsValue;
    }
}

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x26885B9B57AC27F0, NameHash = 0x32707F0D00335D4F)]
    public class GcStatsOneShotTypes : NMSTemplate
    {
        // size: 0x4
        public enum StatsOneShotEnum : uint {
            ShipLanded,
            ShipLaunched,
            ShipWarped,
            WeaponFired,
        }
        /* 0x0 */ public StatsOneShotEnum StatsOneShot;
    }
}

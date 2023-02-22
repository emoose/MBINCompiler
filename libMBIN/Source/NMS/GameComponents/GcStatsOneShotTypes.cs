namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD938FFD11F8DDB8F, NameHash = 0x32707F0D00335D4F)]
    public class GcStatsOneShotTypes : NMSTemplate
    {
        // size: 0x4
        public enum StatsOneShotEnum {
            ShipLanded,
            ShipLaunched,
            ShipWarped,
            WeaponFired,
        }
        /* 0x0 */ public StatsOneShotEnum StatsOneShot;
    }
}

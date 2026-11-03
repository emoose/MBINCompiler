namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2F921B77000F5386, NameHash = 0xA50EBF75)]
    public class GcSentinelTypes : NMSTemplate
    {
        // size: 0xE
        public enum SentinelTypeEnum : uint {
            PatrolDrone,
            CombatDrone,
            MedicDrone,
            SummonerDrone,
            CorruptedDrone,
            Quad,
            SpiderQuad,
            SpiderQuadMini,
            Mech,
            Walker,
            FriendlyDrone,
            StoneMech,
            StoneFloater,
            SwarmDrone,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SentinelTypeEnum SentinelType;
    }
}

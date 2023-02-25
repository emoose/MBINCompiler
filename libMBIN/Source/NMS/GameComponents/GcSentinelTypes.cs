namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3F0158EC0BC49377, NameHash = 0x4C87DB0C59434DB3)]
    public class GcSentinelTypes : NMSTemplate
    {
        // size: 0x9
        public enum SentinelTypeEnum : uint {
            PatrolDrone,
            CombatDrone,
            MedicDrone,
            SummonerDrone,
            CorruptedDrone,
            Quad,
            Mech,
            Walker,
            FriendlyDrone,
        }
        /* 0x0 */ public SentinelTypeEnum SentinelType;
    }
}

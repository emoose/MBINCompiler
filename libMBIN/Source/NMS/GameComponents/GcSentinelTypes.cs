namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCA055E2101CCF0AC, NameHash = 0x4C87DB0C59434DB3)]
    public class GcSentinelTypes : NMSTemplate
    {
        // size: 0x9
        public enum SentinelTypeEnum {
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

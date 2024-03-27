namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA96B50DDF3B522E4, NameHash = 0x69E9FB65CE773F84)]
    public class GcSettlementConstructionLevel : NMSTemplate
    {
        // size: 0x6
        public enum SettlementConstructionLevelEnum : uint {
            Start,
            GroundStorey,
            RegularStorey,
            Roof,
            Decoration,
            Other,
        }
        /* 0x0 */ public SettlementConstructionLevelEnum SettlementConstructionLevel;
    }
}

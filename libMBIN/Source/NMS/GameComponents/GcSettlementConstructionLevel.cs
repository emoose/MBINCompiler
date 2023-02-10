namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x215FF7E57CB47488, NameHash = 0x69E9FB65CE773F84)]
    public class GcSettlementConstructionLevel : NMSTemplate
    {
        // size: 0x6
        public enum SettlementConstructionLevelEnum {
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

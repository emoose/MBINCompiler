namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x501952C68E6164B8, NameHash = 0xF1094533)]
    public class GcSettlementConstructionLevel : NMSTemplate
    {
        // size: 0x9
        public enum SettlementConstructionLevelEnum : uint {
            Start,
            GroundStorey,
            RegularStorey,
            Roof,
            Decoration,
            Upgrade1,
            Upgrade2,
            Upgrade3,
            Other,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SettlementConstructionLevelEnum SettlementConstructionLevel;
    }
}

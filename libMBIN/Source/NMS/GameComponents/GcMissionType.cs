namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x764185355E2FCC4B, NameHash = 0x881C97F393A2FB50)]
    public class GcMissionType : NMSTemplate
    {
        // size: 0xB
        public enum MissionTypeEnum : uint {
            SpaceCombat,
            GroundCombat,
            Research,
            MissingPerson,
            Repair,
            Cargo,
            Piracy,
            Photo,
            Feeding,
            Planting,
            Construction,
        }
        /* 0x0 */ public MissionTypeEnum MissionType;
    }
}

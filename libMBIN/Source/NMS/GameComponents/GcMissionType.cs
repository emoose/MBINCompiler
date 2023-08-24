namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAD8155E8E885B03, NameHash = 0x881C97F393A2FB50)]
    public class GcMissionType : NMSTemplate
    {
        // size: 0xE
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
            LocalCorrupted,
            LocalCorruptedCombat,
            LocalSalvage,
        }
        /* 0x0 */ public MissionTypeEnum MissionType;
    }
}

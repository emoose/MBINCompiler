namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x741217ED3F96DBAD, NameHash = 0x881C97F393A2FB50)]
    public class GcMissionType : NMSTemplate
    {
        // size: 0xB
        public enum MissionTypeEnum {
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

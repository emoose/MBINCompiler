namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1BD155E6F18D55B, NameHash = 0x881C97F393A2FB50)]
    public class GcMissionType : NMSTemplate
    {
        // size: 0x15
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
            LocalBiomePlants,
            LocalExtreme,
            LocalBones,
            LocalInfested,
            LocalPlanetaryPirates,
            LocalPredators,
            LocalSentinels,
        }
        /* 0x0 */ public MissionTypeEnum MissionType;
    }
}

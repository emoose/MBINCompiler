using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6B88307C9D36D6E4, NameHash = 0xC9E2EEA2B81DBE00)]
    public class GcBuildingFilenameList : NMSTemplate
    {
        // size: 0x34
        public enum BuildingFilesEnum {
            None,
            TerrainResource,
            Shelter,
            Abandoned,
            Terminal,
            Shop,
            Outpost,
            Waypoint,
            Beacon,
            RadioTower,
            Observatory,
            Depot,
            Factory,
            Harvester,
            Plaque,
            Monolith,
            Portal,
            Ruin,
            Debris,
            DamagedMachine,
            DistressSignal,
            LandingPad,
            Base,
            MissionTower,
            CrashedFreighter,
            GraveInCave,
            StoryGlitch,
            TreasureRuins,
            GameStartSpawn,
            WaterCrashedFreighter,
            WaterTreasureRuins,
            WaterAbandoned,
            WaterDistressSignal,
            NPCDistressSignal,
            NPCDebris,
            LargeBuilding,
            Settlement_Hub,
            Settlement_LandingZone,
            Settlement_Bar,
            Settlement_Tower,
            Settlement_Market,
            Settlement_Small,
            Settlement_SmallIndustrial,
            Settlement_Medium,
            Settlement_Large,
            Settlement_Monument,
            Settlement_SheriffsOffice,
            Settlement_Double,
            Settlement_Farm,
            Settlement_Factory,
            Settlement_Clump,
            DroneHive
        }
        [NMS(Size = 0x34, EnumType = typeof(BuildingFilesEnum))]
        /* 0x0 */ public GcBuildingFilename[] BuildingFiles;
    }
}

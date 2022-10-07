using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x996CC86A78C028FB, NameHash = 0x9808AB95D152F880)]
    public class GcBuildingDefinitionTable : NMSTemplate
    {
        // size: 0x8
        public enum BuildingFilesEnum {
            Traders,
            Warriors,
            Explorers,
            Robots,
            Atlas,
            Diplomats,
            Exotics,
            None
        }
        [NMS(Size = 0x8, EnumType = typeof(BuildingFilesEnum))]
        /* 0x00000 */ public GcBuildingFilenameList[] BuildingFiles;
        // size: 0x34
        public enum BuildingPlacementEnum {
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
        [NMS(Size = 0x34, EnumType = typeof(BuildingPlacementEnum))]
        /* 0x4E000 */ public GcBuildingDefinitionData[] BuildingPlacement;
        /* 0x4F6C0 */ public List<GcBuildingClusterLayout> ClusterLayouts;
    }
}

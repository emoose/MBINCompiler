using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x3A758, GUID = 0x2880E385D1BB265C)]
    public class GcBuildingDefinitionTable : NMSTemplate
    {
        [NMS(Size = 7, EnumValue = new[]{ "Traders", "Warriors", "Explorers", "Robots", "Atlas", "Diplomats", "None" })]
        /* 0x00000 */ public GcBuildingFilenameList[] BuildingFiles;

        // enum: GcBuildingClassification
        [NMS(Size = 0x21, EnumValue = new[] {
                "None", "TerrainResource", "Shelter", "Abandoned", "Terminal", "Shop", "Outpost", "Waypoint",
                "Beacon", "RadioTower", "Observatory", "Depot", "Factory", "Harvester", "Plaque", "Monolith",
                "Portal", "Ruin", "Debris", "DamagedMachine", "DistressSignal", "LandingPad", "Base", "MissionTower",
                "CrashedFreighter", "GraveInCave", "StoryGlitch", "TreasureRuins", "GameStartSpawn", "WaterCrashedFreighter",
                "WaterTreasureRuins", "WaterAbandoned", "WaterDistressSignal"
            })]
        /* 0x39C00 */ public GcBuildingDefinitionData[] BuildingPlacement;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8400, GUID = 0x4DF76B86F24FAEC)]
    public class GcBuildingFilenameList : NMSTemplate
    {
        [NMS(Size = 0x21, EnumValue = new[] {
                "None", "TerrainResource", "Shelter", "Abandoned", "Terminal", "Shop", "Outpost", "Waypoint",
                "Beacon", "RadioTower", "Observatory", "Depot", "Factory", "Harvester", "Plaque", "Monolith",
                "Portal", "Ruin", "Debris", "DamagedMachine", "DistressSignal", "LandingPad", "Base", "MissionTower",
                "CrashedFreighter", "GraveInCave", "StoryGlitch", "TreasureRuins", "GameStartSpawn", "WaterCrashedFreighter",
                "WaterTreasureRuins", "WaterAbandoned", "WaterDistressSignal"
            })]
        public GcBuildingFilename[] BuildingFiles;
    }
}

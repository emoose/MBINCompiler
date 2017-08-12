namespace MBINCompiler.Models.Structs
{
    public class GcBuildingFilenameList : NMSTemplate // 0x3600 bytes
    {
        [NMS(Size = 0x1B, EnumValue = new string[0x1B] {
                "None", "TerrainResource", "Shelter", "Abandoned", "Terminal", "Shop", "Outpost", "Waypoint",
                "Beacon", "RadioTower", "Observatory", "Depot", "Factory", "Harvester", "Plaque", "Monolith",
                "Portal", "Ruin", "Debris", "DamagedMachine", "DistressSignal", "LandingPad", "Base", "MissionTower",
                "CrashedFreighter", "GraveInCave", "StoryGlitch"
            })]
        public GcBuildingFilename[] BuildingFiles;
    }
}

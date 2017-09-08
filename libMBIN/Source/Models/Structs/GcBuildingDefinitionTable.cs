namespace MBINCompiler.Models.Structs
{
    public class GcBuildingDefinitionTable : NMSTemplate        // size: 0x183B0
    {
        [NMS(Size = 5)]
        /* 0x00000 */ public GcBuildingDensity[] BuildingProbabilities;
        [NMS(Size = 7)]
        /* 0x00064 */ public GcBuildingFilenameList[] BuildingFiles;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x17A64 */ public byte[] Padding17A64;
        [NMS(Size = 0x1B, EnumValue = new string[0x1B] {
                "None", "TerrainResource", "Shelter", "Abandoned", "Terminal", "Shop", "Outpost", "Waypoint",
                "Beacon", "RadioTower", "Observatory", "Depot", "Factory", "Harvester", "Plaque", "Monolith",
                "Portal", "Ruin", "Debris", "DamagedMachine", "DistressSignal", "LandingPad", "Base", "MissionTower",
                "CrashedFreighter", "GraveInCave", "StoryGlitch"
            })]
        /* 0x17A68 */ public GcBuildingDefinitionData[] BuildingPlacement;
    }
}

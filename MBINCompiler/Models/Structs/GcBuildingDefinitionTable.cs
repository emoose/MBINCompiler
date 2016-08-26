namespace MBINCompiler.Models.Structs
{
    public class GcBuildingDefinitionTable : NMSTemplate
    {
        [NMS(Size = 6)]
        public GcBuildingDensity[] BuildingProbabilities;
        [NMS(Size = 6)]
        public GcBuildingFilenameList[] BuildingFiles;
        [NMS(Size = 0x16)]
        public GcBuildingDefinitionData[] BuildingPlacement;
    }
}

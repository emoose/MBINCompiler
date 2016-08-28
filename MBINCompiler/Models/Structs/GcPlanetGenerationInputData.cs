namespace MBINCompiler.Models.Structs
{
    public class GcPlanetGenerationInputData : NMSTemplate
    {
        public GcSeed Seed;
        public GcGalaxyStarTypes StarType;
        public GcPlanetClass PlanetClass;
        [NMS(Size = 0x10)]
        public string CommonSubstance;
        [NMS(Size = 0x10)]
        public string RareSubstance;
        public GcPlanetSize PlanetSize;
        public GcBiomeType BiomeType;
    }
}

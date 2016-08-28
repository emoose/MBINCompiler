namespace MBINCompiler.Models.Structs
{
    public class GcAsteroidGeneratorAssignment : NMSTemplate // 0x48 bytes
    {
        public int PlanetIndex;
        public GcSolarSystemLocatorChoice Locator;
        public GcSeed Seed;
        public int AsteroidCount;
    }
}

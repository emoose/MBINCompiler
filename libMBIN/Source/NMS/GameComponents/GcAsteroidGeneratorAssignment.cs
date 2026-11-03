using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6FB00B1D0B020BD5, NameHash = 0x2EC0DFAA)]
    public class GcAsteroidGeneratorAssignment : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public GcSeed Seed;
        [NMS(Index = 1)]
        /* 0x10 */ public GcSolarSystemLocatorChoice Locator;
        [NMS(Index = 3)]
        /* 0x3C */ public int AsteroidCount;
        [NMS(Index = 0, MxmlName = "Planet Index")]
        /* 0x40 */ public int PlanetIndex;
    }
}

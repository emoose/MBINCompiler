using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1A8, GUID = 0x2844AA8687B3F034, NameHash = 0xEDE680300A536215)]
    public class GcGalaxyStarAttributesData : NMSTemplate
    {
        /* 0x000 */ public GcGalaxyStarTypes Type;
        /* 0x004 */ public GcGalaxyStarAnomaly Anomaly;
        /* 0x008 */ public int NumberOfPlanets;
        /* 0x00C */ public int NumberOfPrimePlanets;
        [NMS(Size = 0x10)]
        /* 0x010 */ public GcPlanetSize[] PlanetSizes;
        [NMS(Size = 0x10)]
        /* 0x050 */ public int[] PlanetParentIndices;
        [NMS(Size = 0x10)]
        /* 0x090 */ public GcSeed[] PlanetSeeds;
        /* 0x190 */ public GcPlanetTradingData TradingData;
        /* 0x198 */ public GcPlayerConflictData ConflictData;
        /* 0x19C */ public GcAlienRace Race;
        /* 0x1A0 */ public bool AbandonedSystem;
        /* 0x1A1 */ public bool IsSystemSafe;
    }
}

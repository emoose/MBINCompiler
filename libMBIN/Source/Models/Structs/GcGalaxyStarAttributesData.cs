namespace libMBIN.Models.Structs
{
    public class GcGalaxyStarAttributesData : NMSTemplate // size = 0x1A8
    {
        /* 0x000 */ public GcGalaxyStarTypes Type;
        /* 0x004 */ public GcGalaxyStarAnomaly Anomaly;
        /* 0x008 */ public int NumberOfPlanets;
        [NMS(Size = 0x10)]
        /* 0x00C */ public GcPlanetSize[] PlanetSizes;
        [NMS(Size = 0x10)]
        /* 0x04C */ public int[] PlanetParentIndices;
        [NMS(Size = 0x10)]
        /* 0x090 */ public GcSeed[] PlanetSeeds;
        /* 0x190 */ public GcPlanetTradingData TradingData;
        /* 0x198 */ public GcPlayerConflictData ConflictData;
        /* 0x19C */ public GcAlienRace Race;
        /* 0x1A0 */ public bool AbandonedSystem;
        /* 0x1A1 */ public bool IsSystemSafe;
        [NMS(Size =  0x6, Ignore = true)]
        public byte[] EndPadding;
    }
}

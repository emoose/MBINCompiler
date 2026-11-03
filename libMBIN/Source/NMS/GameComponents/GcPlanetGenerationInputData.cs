using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x620190E7A4C7FAF9, NameHash = 0x2F445358)]
    public class GcPlanetGenerationInputData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x10 CommonSubstance;
        [NMS(Index = 4)]
        /* 0x10 */ public NMSString0x10 RareSubstance;
        [NMS(Index = 0)]
        /* 0x20 */ public GcSeed Seed;
        [NMS(Index = 6)]
        /* 0x30 */ public GcBiomeType Biome;
        [NMS(Index = 7)]
        /* 0x34 */ public GcBiomeSubType BiomeSubType;
        [NMS(Index = 2)]
        /* 0x38 */ public GcPlanetClass Class;
        [NMS(Index = 16)]
        /* 0x3C */ public int PlanetIndex;
        [NMS(Index = 5)]
        /* 0x40 */ public GcPlanetSize PlanetSize;
        [NMS(Index = 15)]
        /* 0x44 */ public int RealityIndex;
        [NMS(Index = 1)]
        /* 0x48 */ public GcGalaxyStarTypes Star;
        [NMS(Index = 9)]
        /* 0x4C */ public bool ForceContinents;
        [NMS(Index = 8)]
        /* 0x4D */ public bool HasRings;
        [NMS(Index = 11)]
        /* 0x4E */ public bool InAbandonedSystem;
        [NMS(Index = 10)]
        /* 0x4F */ public bool InEmptySystem;
        [NMS(Index = 12)]
        /* 0x50 */ public bool InGasGiantSystem;
        [NMS(Index = 13)]
        /* 0x51 */ public bool InPirateSystem;
        [NMS(Index = 14)]
        /* 0x52 */ public bool Prime;
    }
}

using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3E7E92BF1F020E63, NameHash = 0x9CE4FFF3)]
    public class GcScanEventSolarSystemLookup : NMSTemplate
    {
        [NMS(Index = 38)]
        /* 0x00 */ public NMSString0x20A SamePlanetAsEvent;
        [NMS(Index = 40)]
        /* 0x20 */ public List<NMSString0x20A> ExcludePlanetsWithEvents;
        [NMS(Index = 32)]
        /* 0x30 */ public NMSString0x10 NeedsResourceHint;
        [NMS(Index = 37)]
        /* 0x40 */ public NMSString0x10 NeedsSpecificCreature;
        [NMS(Index = 41)]
        /* 0x50 */ public List<NMSString0x10> PreferPlanetWhereStatIsZero;
        [NMS(Index = 42)]
        /* 0x60 */ public NMSString0x10 SystemNeedsResourceHint;
        [NMS(Index = 7)]
        /* 0x70 */ public GcPlanetTradingData TradingData;
        [NMS(Index = 52)]
        /* 0x78 */ public int MinPlanets;
        [NMS(Index = 28)]
        /* 0x7C */ public GcBiomeType NeedsBiomeType;
        [NMS(Index = 39)]
        /* 0x80 */ public int SamePlanetAsSeasonParty;
        [NMS(Index = 6)]
        /* 0x84 */ public GcGalaxyStarTypes StarType;
        [NMS(Index = 4)]
        /* 0x88 */ public GcGalaxyStarAnomaly UseAnomaly;
        [NMS(Index = 29)]
        /* 0x8C */ public GcBiomeSubType UseBiomeSubType;
        [NMS(Index = 5)]
        /* 0x90 */ public GcPlayerConflictData UseConflict;
        [NMS(Index = 3)]
        /* 0x94 */ public GcAlienRace UseRace;
        [NMS(Index = 11)]
        /* 0x98 */ public bool AllowedToBePurpleWithoutAccess;
        [NMS(Index = 8)]
        /* 0x99 */ public bool AllowUnsafeMatches;
        [NMS(Index = 13)]
        /* 0x9A */ public bool AlwaysAvailableInPirateStations;
        [NMS(Index = 24)]
        /* 0x9B */ public bool AnyBiomeNotWeirdOrDead;
        [NMS(Index = 26)]
        /* 0x9C */ public bool AnyInfestedBiome;
        [NMS(Index = 25)]
        /* 0x9D */ public bool AnyRGBBiome;
        [NMS(Index = 31)]
        /* 0x9E */ public bool NeedsAbandonedSystem;
        [NMS(Index = 27)]
        /* 0x9F */ public bool NeedsBiome;
        [NMS(Index = 18)]
        /* 0xA0 */ public bool NeedsCorruptSentinelPlanet;
        [NMS(Index = 15)]
        /* 0xA1 */ public bool NeedsDeepWaterPlanet;
        [NMS(Index = 30)]
        /* 0xA2 */ public bool NeedsEmptySystem;
        [NMS(Index = 22)]
        /* 0xA3 */ public bool NeedsExtremeHazardPlanet;
        [NMS(Index = 19)]
        /* 0xA4 */ public bool NeedsExtremeSentinelPlanet;
        [NMS(Index = 21)]
        /* 0xA5 */ public bool NeedsExtremeWeatherPlanet;
        [NMS(Index = 16)]
        /* 0xA6 */ public bool NeedsPrimePlanet;
        [NMS(Index = 17)]
        /* 0xA7 */ public bool NeedsSentinels;
        [NMS(Index = 14)]
        /* 0xA8 */ public bool NeedsWaterPlanet;
        [NMS(Index = 10)]
        /* 0xA9 */ public bool NeverAllowAbandoned;
        [NMS(Index = 9)]
        /* 0xAA */ public bool NeverAllowEmpty;
        [NMS(Index = 20)]
        /* 0xAB */ public bool NeverAllowExtremeSentinelPlanet;
        [NMS(Index = 23)]
        /* 0xAC */ public bool NeverAllowExtremeWeatherPlanet;
        [NMS(Index = 51)]
        /* 0xAD */ public bool NeverAllowGasGiantSystem;
        [NMS(Index = 12)]
        /* 0xAE */ public bool RequireUndiscovered;
        [NMS(Index = 33)]
        /* 0xAF */ public bool SuitableForCreatureDiscovery;
        [NMS(Index = 36)]
        /* 0xB0 */ public bool SuitableForCreatureTaming;
        [NMS(Index = 35)]
        /* 0xB1 */ public bool SuitableForRobotCreatureDiscovery;
        [NMS(Index = 34)]
        /* 0xB2 */ public bool SuitableForWeirdCreatureDiscovery;
        [NMS(Index = 47)]
        /* 0xB3 */ public bool SystemNeedsCorruptSentinelPlanet;
        [NMS(Index = 48)]
        /* 0xB4 */ public bool SystemNeedsExtremeStormPlanet;
        [NMS(Index = 49)]
        /* 0xB5 */ public bool SystemNeedsGasGiant;
        [NMS(Index = 45)]
        /* 0xB6 */ public bool SystemNeedsInfestedPlanet;
        [NMS(Index = 50)]
        /* 0xB7 */ public bool SystemNeedsNonGasGiant;
        [NMS(Index = 46)]
        /* 0xB8 */ public bool SystemNeedsRelicPlanet;
        [NMS(Index = 43)]
        /* 0xB9 */ public bool SystemNeedsWater;
        [NMS(Index = 44)]
        /* 0xBA */ public bool SystemNeedsWeirdPlanet;
        [NMS(Index = 0)]
        /* 0xBB */ public bool UseStarType;
        [NMS(Index = 2)]
        /* 0xBC */ public bool UseTrading;
        [NMS(Index = 1)]
        /* 0xBD */ public bool UseWealth;
    }
}

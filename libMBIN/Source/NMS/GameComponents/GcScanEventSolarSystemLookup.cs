using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA5E6163960C68336, NameHash = 0xE523CFAD6AFB4BB6)]
    public class GcScanEventSolarSystemLookup : NMSTemplate
    {
        /* 0x00 */ public bool UseStarType;
        /* 0x01 */ public bool UseWealth;
        /* 0x02 */ public bool UseTrading;
        /* 0x04 */ public GcAlienRace UseRace;
        /* 0x08 */ public GcGalaxyStarAnomaly UseAnomaly;
        /* 0x0C */ public GcPlayerConflictData UseConflict;
        /* 0x10 */ public GcGalaxyStarTypes StarType;
        /* 0x14 */ public GcPlanetTradingData TradingData;
        /* 0x1C */ public bool AllowUnsafeMatches;
        /* 0x1D */ public bool NeverAllowEmpty;
        /* 0x1E */ public bool NeverAllowAbandoned;
        /* 0x1F */ public bool RequireUndiscovered;
        /* 0x20 */ public bool NeedsWaterPlanet;
        /* 0x21 */ public bool NeedsPrimePlanet;
        /* 0x22 */ public bool NeedsSentinels;
        /* 0x23 */ public bool NeedsCorruptSentinelPlanet;
        /* 0x24 */ public bool NeedsExtremeSentinelPlanet;
        /* 0x25 */ public bool NeverAllowExtremeSentinelPlanet;
        /* 0x26 */ public bool NeedsExtremeWeatherPlanet;
        /* 0x27 */ public bool NeedsExtremeHazardPlanet;
        /* 0x28 */ public bool AnyBiomeNotWeirdOrDead;
        /* 0x29 */ public bool AnyRGBBiome;
        /* 0x2A */ public bool AnyInfestedBiome;
        /* 0x2B */ public bool NeedsBiome;
        /* 0x2C */ public GcBiomeType NeedsBiomeType;
        /* 0x30 */ public GcBiomeSubType UseBiomeSubType;
        /* 0x34 */ public bool NeedsEmptySystem;
        /* 0x35 */ public bool NeedsAbandonedSystem;
        /* 0x38 */ public NMSString0x10 NeedsResourceHint;
        /* 0x48 */ public bool SuitableForCreatureDiscovery;
        /* 0x49 */ public bool SuitableForWeirdCreatureDiscovery;
        /* 0x4A */ public bool SuitableForCreatureTaming;
        /* 0x50 */ public NMSString0x20A SamePlanetAsEvent;
        /* 0x70 */ public int SamePlanetAsSeasonParty;
    }
}

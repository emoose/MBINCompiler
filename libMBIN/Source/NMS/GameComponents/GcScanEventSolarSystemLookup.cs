using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Alignment = 0x4, Size = 0x60, GUID = 0x20371E4A6795DF08, SubGUID = 0xE523CFAD6AFB4BB6)]
    public class GcScanEventSolarSystemLookup : NMSTemplate
    {
        /* 0x00 */ public bool UseStarType;
        /* 0x01 */ public bool UseWealth;
        /* 0x02 */ public bool Usetrading;
        /* 0x04 */ public GcAlienRace Userace;
        /* 0x08 */ public GcGalaxyStarAnomaly UseAnomaly;
        /* 0x0C */ public GcPlayerConflictData UseConflict;
        /* 0x10 */ public GcGalaxyStarTypes StarType;
        /* 0x14 */ public GcPlanetTradingData TradingData;
        /* 0x1C */ public bool NeedsWaterPlanet;
        /* 0x1D */ public bool NeedsExtremeSentinelPlanet;
        /* 0x1E */ public bool NeedsBiome;
        /* 0x1F */ public bool AnyRGBBiome;
        /* 0x20 */ public GcBiomeType NeedsBiomeType;
        /* 0x24 */ public bool NeedsEmptySystem;
        /* 0x25 */ public bool NeedsAbandonedSystem;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x26 */ public byte[] Padding26;
        [NMS(Size = 0x10)]
        /* 0x28 */ public string NeedsResourceHint;
        /* 0x38 */ public bool NeedsHighCreatureLevel;
        /* 0x39 */ public bool AllowUnsafeMatches;
        /* 0x3A */ public bool NeverAllowEmpty;
        [NMS(Size = 0x5, Ignore = true)]
        /* 0x3B */ public byte[] Padding3B;
        [NMS(Size = 0x20)]
        /* 0x40 */ public string SamePlanetAsEvent;
    }
}

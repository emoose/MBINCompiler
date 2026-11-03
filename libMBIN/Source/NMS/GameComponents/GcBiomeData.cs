using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC9DF94B23FE3CB44, NameHash = 0x79FEF5EB)]
    public class GcBiomeData : NMSTemplate
    {
        [NMS(Index = 14)]
        /* 0x000 */ public GcBiomeCloudSettings CloudSettings;
        [NMS(Index = 17)]
        /* 0x060 */ public NMSString0x20A FloraLifeLocID;
        [NMS(Index = 3)]
        /* 0x080 */ public GcFilename ColourPaletteFile;
        [NMS(Index = 10)]
        /* 0x090 */ public List<GcExternalObjectListOptions> ExternalObjectLists;
        [NMS(Index = 16)]
        /* 0x0A0 */ public List<GcScreenFilterOption> FilterOptions;
        [NMS(Index = 4)]
        /* 0x0B0 */ public GcFilename LegacyColourPaletteFile;
        [NMS(Index = 1)]
        /* 0x0C0 */ public GcFilename OverlayFile;
        [NMS(Index = 0)]
        /* 0x0D0 */ public GcFilename TextureFile;
        [NMS(Index = 2)]
        /* 0x0E0 */ public GcFilename TileTypesFile;
        [NMS(Index = 11, Size = 0x5, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x0F0 */ public GcWeatherWeightings[] WeatherOptions;
        [NMS(Index = 15)]
        /* 0x244 */ public GcTerrainControls Terrain;
        [NMS(Index = 9)]
        /* 0x2BC */ public GcPlanetWaterData Water;
        [NMS(Index = 5)]
        /* 0x2CC */ public GcMiningSubstanceData MiningSubstance1;
        [NMS(Index = 6)]
        /* 0x2D8 */ public GcMiningSubstanceData MiningSubstance2;
        [NMS(Index = 7)]
        /* 0x2E4 */ public GcMiningSubstanceData MiningSubstance3;
        [NMS(Index = 12)]
        /* 0x2F0 */ public Vector2f WeatherChangeTime;
        [NMS(Index = 13)]
        /* 0x2F8 */ public float DarknessVariation;
        [NMS(Index = 8)]
        /* 0x2FC */ public float FuelMultiplier;
    }
}

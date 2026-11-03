using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6B12323D9E0DB253, NameHash = 0x595E8A2E)]
    public class GcEnvironmentProperties : NMSTemplate
    {
        [NMS(Index = 14, Size = 0x5, EnumType = typeof(GcPlanetSize.PlanetSizeEnum))]
        /* 0x00 */ public float[] SkyHeight;
        [NMS(Index = 13)]
        /* 0x14 */ public float AsteroidFadeHeightMax;
        [NMS(Index = 12)]
        /* 0x18 */ public float AsteroidFadeHeightMin;
        [NMS(Index = 25)]
        /* 0x1C */ public float AtmosphereEndHeight;
        [NMS(Index = 24)]
        /* 0x20 */ public float AtmosphereStartHeight;
        [NMS(Index = 3)]
        /* 0x24 */ public float CloudHeightMax;
        [NMS(Index = 2)]
        /* 0x28 */ public float CloudHeightMin;
        [NMS(Index = 1)]
        /* 0x2C */ public float FlightFogBlend;
        [NMS(Index = 0)]
        /* 0x30 */ public float FlightFogHeight;
        [NMS(Index = 5)]
        /* 0x34 */ public float HeavyAirHeightMax;
        [NMS(Index = 4)]
        /* 0x38 */ public float HeavyAirHeightMin;
        [NMS(Index = 16)]
        /* 0x3C */ public float HorizonBlendHeight;
        [NMS(Index = 17)]
        /* 0x40 */ public float HorizonBlendLength;
        [NMS(Index = 7)]
        /* 0x44 */ public float PlanetLodSwitch0;
        [NMS(Index = 8)]
        /* 0x48 */ public float PlanetLodSwitch0Elevation;
        [NMS(Index = 9)]
        /* 0x4C */ public float PlanetLodSwitch1;
        [NMS(Index = 10)]
        /* 0x50 */ public float PlanetLodSwitch2;
        [NMS(Index = 11)]
        /* 0x54 */ public float PlanetLodSwitch3;
        [NMS(Index = 6)]
        /* 0x58 */ public float PlanetObjectSwitch;
        [NMS(Index = 15)]
        /* 0x5C */ public float SkyAtmosphereHeight;
        [NMS(Index = 19)]
        /* 0x60 */ public float SkyColourBlendLength;
        [NMS(Index = 18)]
        /* 0x64 */ public float SkyColourHeight;
        [NMS(Index = 21)]
        /* 0x68 */ public float SkyPositionBlendLength;
        [NMS(Index = 20)]
        /* 0x6C */ public float SkyPositionHeight;
        [NMS(Index = 23)]
        /* 0x70 */ public float SolarSystemLUTBlendLength;
        [NMS(Index = 22)]
        /* 0x74 */ public float SolarSystemLUTHeight;
        [NMS(Index = 26)]
        /* 0x78 */ public float StratosphereHeight;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x680, GUID = 0xD45B7E06B62E9950)]
    public class GcEnvironmentGlobals : NMSTemplate
    {
        [NMS(Size = 0x4)]
        /* 0x000 */ public TkLODSettingsData[] LODSettings;
        /* 0x1D0 */ public Vector2f SpaceBuildingTemperature;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x1D8 */ public byte[] Padding1D8;
        /* 0x1E0 */ public GcCloudProperties CloudProperties;
        /* 0x2D0 */ public float SenseProbingValueSmoothingTime;
        /* 0x2D4 */ public float SenseProbingValueSmoothingTimeSlow;
        /* 0x2D8 */ public float MaxElevation;
        /* 0x2DC */ public float SphereLodTextureScale;
        /* 0x2E0 */ public bool ForceAddUnderwaterProps;
        /* 0x2E1 */ public bool ForceAddCaveProps;
        /* 0x2E4 */ public float DistortionStep;
        /* 0x2E8 */ public float HDeform;
        /* 0x2EC */ public float SDeform;
        /* 0x2F0 */ public float VDeform;
        /* 0x2F4 */ public float LocationStableTime;
        /* 0x2F8 */ public float InterestStableTime;
        /* 0x2FC */ public float TemperatureSmoothTime;
        /* 0x300 */ public float SunFactorMin;
        /* 0x304 */ public float ExposureSurfaceContrib;
        /* 0x308 */ public float ExposureSurfaceDistMax;
        /* 0x30C */ public float ExposureGroundFactorAddMul;
        /* 0x310 */ public Vector2f ExposureHeightBracket;
        /* 0x318 */ public float DailyTempChangePercent;
        /* 0x31C */ public float SpaceTemperature;
        /* 0x320 */ public float AbandonedFreighterMinTemperature;
        /* 0x324 */ public float AbandonedFreighterMaxTemperature;
        /* 0x328 */ public float ShipTemperature;
        /* 0x32C */ public float SpaceRadiation;
        /* 0x330 */ public float ShipRadiation;
        /* 0x334 */ public float SpaceToxicity;
        /* 0x338 */ public float ShipToxicity;
        /* 0x33C */ public bool MatchPlantPalettes;
        /* 0x340 */ public float DuplicateColourThreshold;
        public enum SwitchTypeEnum { None, Debug, Enabled };
        /* 0x344 */ public SwitchTypeEnum SwitchType;
        /* 0x348 */ public float GrassNormalUpright;
        /* 0x34C */ public float GrassNormalOffset;
        /* 0x350 */ public float GrassNormalSpherify;
        /* 0x354 */ public float GrassNormalMap;
        /* 0x358 */ public float MinPlacementBlendValue;
        /* 0x35C */ public float MinPlacementBlendValuePatch;
        /* 0x360 */ public float MaxPlacementBlendValuePatch;
        /* 0x364 */ public float MinPlacementObjectScale;
        /* 0x368 */ public float SpaceStationStateBoundingBoxScaler;
        /* 0x36C */ public float AtmosphereSpaceRadius;
        /* 0x370 */ public float SpawnLowerAtmosphereRadiusMultiplier;
        /* 0x374 */ public float TerrainFadeTime;
        /* 0x378 */ public float TerrainFadeTimeInShip;
        /* 0x37C */ public float CreatureFadeTime;
        /* 0x380 */ public float FloraFadeTimeMin;
        /* 0x384 */ public float FloraFadeTimeMax;
        /* 0x388 */ public float PlanetUnwrapMin;
        /* 0x38C */ public float PlanetUnwrapMax;
        /* 0x390 */ public float TerrainFlattenMin;
        /* 0x394 */ public float TerrainFlattenMax;
        /* 0x398 */ public float FogHeightMin;
        /* 0x39C */ public float FogHeightMax;
        /* 0x3A0 */ public float HeightFogHeightMin;
        /* 0x3A4 */ public float HeightFogHeightMax;
        /* 0x3A8 */ public float WaterFogHeightMin;
        /* 0x3AC */ public float WaterFogHeightMax;
        /* 0x3B0 */ public float WaterAlphaHeightMin;
        /* 0x3B4 */ public float WaterAlphaHeightMax;
        /* 0x3B8 */ public float CloudHeightMin;
        /* 0x3BC */ public float CloudHeightMax;
        /* 0x3C0 */ public float DoFHeightMin;
        /* 0x3C4 */ public float DoFHeightMax;
        /* 0x3C8 */ public float SunClampHeightMin;
        /* 0x3CC */ public float SunClampHeightMax;
        /* 0x3D0 */ public float HeavyAirFadeDistance;
        /* 0x3D4 */ public float HeavyAirHeightMin;
        /* 0x3D8 */ public float HeavyAirHeightMax;
        /* 0x3DC */ public float HeavyAirFadeInTime;
        /* 0x3E0 */ public float HeavyAirFadeOutTime;
        /* 0x3E4 */ public float PlanetObjectSwitch;
        /* 0x3E8 */ public float PlanetLodSwitch0;
        /* 0x3EC */ public float PlanetLodSwitch0Elevation;
        /* 0x3F0 */ public float PlanetLodSwitch1;
        /* 0x3F4 */ public float PlanetLodSwitch2;
        /* 0x3F8 */ public float PlanetLodSwitch3;
        /* 0x3FC */ public float PlanetFlipDistance;
        /* 0x400 */ public float PlanetEffectEndDistance;
        /* 0x404 */ public float AsteroidFadeHeightMin;
        /* 0x408 */ public float AsteroidFadeHeightMax;
        /* 0x40C */ public float AsteroidScale;
        /* 0x410 */ public float SmallAsteroidScale;
        /* 0x414 */ public float AsteroidMinRotate;
        /* 0x418 */ public float AsteroidMaxRotate;
        /* 0x41C */ public float MinWaterReflections;
        [NMS(Size = 0x4)]
        /* 0x420 */ public float[] SpacePlanetFogStrength;
        [NMS(Size = 0x4)]
        /* 0x430 */ public float[] SkyHeight;
        [NMS(Size = 0x4)]
        /* 0x440 */ public float[] SkyBlendLength;
        /* 0x450 */ public float SkyAtmospherePower;
        /* 0x454 */ public float SkyAtmosphereHeight;
        [NMS(Size = 0x4)]
        /* 0x458 */ public float[] SkyAtmosphereBlendLength;
        /* 0x468 */ public float HorizonBlendHeight;
        /* 0x46C */ public float HorizonBlendLength;
        [NMS(Size = 0x4)]
        /* 0x470 */ public float[] FarBlendHeight;
        /* 0x480 */ public float FarBlendLength;
        /* 0x484 */ public float SkyColourHeight;
        /* 0x488 */ public float SkyColourBlendLength;
        /* 0x48C */ public float SkyPositionHeight;
        /* 0x490 */ public float SkyPositionBlendLength;
        /* 0x494 */ public float IndoorColourBlendTime;
        /* 0x4A0 */ public Colour IndoorAmbientColour;
        /* 0x4B0 */ public float LightDirectionHeight;
        /* 0x4B4 */ public float LightDirectionBlend;
        /* 0x4B8 */ public float LightColourHeight;
        /* 0x4BC */ public float LightColourBlend;
        /* 0x4C0 */ public float FlightFogHeight;
        /* 0x4C4 */ public float FlightFogBlend;
        /* 0x4C8 */ public float SolarSystemLUTHeight;
        /* 0x4CC */ public float SolarSystemLUTBlendLength;
        /* 0x4D0 */ public float ObjectSpawnFirstRadius;
        /* 0x4D4 */ public float ObjectSpawnFirstDotCheck;
        /* 0x4D8 */ public float ObjectSpawnDetailRadius;
        /* 0x4DC */ public float InteractionRadius;
        /* 0x4E0 */ public bool EnableWind;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x4E1 */ public byte[] Padding4E1;
        [NMS(Size = 0x3)]
        /* 0x4E8 */ public TkShearWindData[] ShearWindSettings;
        /* 0x668 */ public int HotspotsLOD;
        /* 0x66C */ public float RegionHotspotProbability;
        /* 0x670 */ public float MaxHotspotOffsetDistance;
        /* 0x674 */ public float MinHotspotFalloffDistance;
        /* 0x678 */ public float MaxHotspotFalloffDistance;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x67C */ public byte[] EndPadding;
    }
}

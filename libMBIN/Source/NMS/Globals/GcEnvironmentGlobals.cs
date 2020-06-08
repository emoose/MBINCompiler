using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x660, GUID = 0xF90DDBBA746CAAB4)]
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
        /* 0x320 */ public float ShipTemperature;
        /* 0x324 */ public float SpaceRadiation;
        /* 0x328 */ public float ShipRadiation;
        /* 0x32C */ public float SpaceToxicity;
        /* 0x330 */ public float ShipToxicity;
        /* 0x334 */ public bool MatchPlantPalettes;
        /* 0x338 */ public float DuplicateColourThreshold;
        public enum SwitchTypeEnum { None, Debug, Enabled };
        /* 0x33C */ public SwitchTypeEnum SwitchType;
        /* 0x340 */ public float GrassNormalUpright;
        /* 0x344 */ public float GrassNormalOffset;
        /* 0x348 */ public float GrassNormalSpherify;
        /* 0x34C */ public float GrassNormalMap;
        /* 0x350 */ public float MinPlacementBlendValue;
        /* 0x354 */ public float MinPlacementBlendValuePatch;
        /* 0x358 */ public float MaxPlacementBlendValuePatch;
        /* 0x35C */ public float MinPlacementObjectScale;
        /* 0x360 */ public float SpaceStationStateBoundingBoxScaler;
        /* 0x364 */ public float AtmosphereSpaceRadius;
        /* 0x368 */ public float SpawnLowerAtmosphereRadiusMultiplier;
        /* 0x36C */ public float TerrainFadeTime;
        /* 0x370 */ public float TerrainFadeTimeInShip;
        /* 0x374 */ public float CreatureFadeTime;
        /* 0x378 */ public float FloraFadeTimeMin;
        /* 0x37C */ public float FloraFadeTimeMax;
        /* 0x380 */ public float PlanetUnwrapMin;
        /* 0x384 */ public float PlanetUnwrapMax;
        /* 0x388 */ public float TerrainFlattenMin;
        /* 0x38C */ public float TerrainFlattenMax;
        /* 0x390 */ public float FogHeightMin;
        /* 0x394 */ public float FogHeightMax;
        /* 0x398 */ public float HeightFogHeightMin;
        /* 0x39C */ public float HeightFogHeightMax;
        /* 0x3A0 */ public float WaterFogHeightMin;
        /* 0x3A4 */ public float WaterFogHeightMax;
        /* 0x3A8 */ public float WaterAlphaHeightMin;
        /* 0x3AC */ public float WaterAlphaHeightMax;
        /* 0x3B0 */ public float CloudHeightMin;
        /* 0x3B4 */ public float CloudHeightMax;
        /* 0x3B8 */ public float DoFHeightMin;
        /* 0x3BC */ public float DoFHeightMax;
        /* 0x3C0 */ public float SunClampHeightMin;
        /* 0x3C4 */ public float SunClampHeightMax;
        /* 0x3C8 */ public float HeavyAirFadeDistance;
        /* 0x3CC */ public float HeavyAirHeightMin;
        /* 0x3D0 */ public float HeavyAirHeightMax;
        /* 0x3D4 */ public float HeavyAirFadeInTime;
        /* 0x3D8 */ public float HeavyAirFadeOutTime;
        /* 0x3DC */ public float PlanetObjectSwitch;
        /* 0x3E0 */ public float PlanetLodSwitch0;
        /* 0x3E4 */ public float PlanetLodSwitch0Elevation;
        /* 0x3E8 */ public float PlanetLodSwitch1;
        /* 0x3EC */ public float PlanetLodSwitch2;
        /* 0x3F0 */ public float PlanetLodSwitch3;
        /* 0x3F4 */ public float PlanetFlipDistance;
        /* 0x3F8 */ public float PlanetEffectEndDistance;
        /* 0x3FC */ public float AsteroidFadeHeightMin;
        /* 0x400 */ public float AsteroidFadeHeightMax;
        /* 0x404 */ public float AsteroidScale;
        /* 0x408 */ public float SmallAsteroidScale;
        /* 0x40C */ public float AsteroidMinRotate;
        /* 0x410 */ public float AsteroidMaxRotate;
        /* 0x414 */ public float MinWaterReflections;
        [NMS(Size = 0x4)]
        /* 0x418 */ public float[] SpacePlanetFogStrength;
        [NMS(Size = 0x4)]
        /* 0x428 */ public float[] SkyHeight;
        [NMS(Size = 0x4)]
        /* 0x438 */ public float[] SkyBlendLength;
        /* 0x448 */ public float SkyAtmospherePower;
        /* 0x44C */ public float SkyAtmosphereHeight;
        [NMS(Size = 0x4)]
        /* 0x450 */ public float[] SkyAtmosphereBlendLength;
        /* 0x460 */ public float HorizonBlendHeight;
        /* 0x464 */ public float HorizonBlendLength;
        [NMS(Size = 0x4)]
        /* 0x468 */ public float[] FarBlendHeight;
        /* 0x478 */ public float FarBlendLength;
        /* 0x47C */ public float SkyColourHeight;
        /* 0x480 */ public float SkyColourBlendLength;
        /* 0x484 */ public float SkyPositionHeight;
        /* 0x488 */ public float SkyPositionBlendLength;
        /* 0x48C */ public float LightDirectionHeight;
        /* 0x490 */ public float LightDirectionBlend;
        /* 0x494 */ public float LightColourHeight;
        /* 0x498 */ public float LightColourBlend;
        /* 0x49C */ public float FlightFogHeight;
        /* 0x4A0 */ public float FlightFogBlend;
        /* 0x4A4 */ public float SolarSystemLUTHeight;
        /* 0x4A8 */ public float SolarSystemLUTBlendLength;
        /* 0x4AC */ public float ObjectSpawnFirstRadius;
        /* 0x4B0 */ public float ObjectSpawnFirstDotCheck;
        /* 0x4B4 */ public float ObjectSpawnDetailRadius;
        /* 0x4B8 */ public float InteractionRadius;
        /* 0x4BC */ public bool EnableWind;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x4BD */ public byte[] Padding4BD;
        [NMS(Size = 0x3)]
        /* 0x4C0 */ public TkShearWindData[] ShearWindSettings;
        /* 0x640 */ public int HotspotsLOD;
        /* 0x644 */ public float RegionHotspotProbability;
        /* 0x648 */ public float MaxHotspotOffsetDistance;
        /* 0x64C */ public float MinHotspotFalloffDistance;
        /* 0x650 */ public float MaxHotspotFalloffDistance;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x654 */ public byte[] EndPadding;
    }
}

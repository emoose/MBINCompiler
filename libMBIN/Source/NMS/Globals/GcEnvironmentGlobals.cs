using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x600, GUID = 0x67E7C814AA64BCF5, NameHash = 0x1E09DD001FDA82F8)]
    public class GcEnvironmentGlobals : NMSTemplate
    {
        [NMS(Size = 0x4)]
        /* 0x000 */ public TkLODSettingsData[] LODSettings;
        /* 0x230 */ public Vector2f SpaceBuildingTemperature;
        /* 0x240 */ public GcCloudProperties CloudProperties;
        /* 0x320 */ public float SenseProbingValueSmoothingTime;
        /* 0x324 */ public float SenseProbingValueSmoothingTimeMed;
        /* 0x328 */ public float SenseProbingValueSmoothingTimeSlow;
        /* 0x32C */ public float IndoorsLightingWeightAround;
        /* 0x330 */ public float IndoorsLightingWeightOverhead;
        /* 0x334 */ public float IndoorsLightingWeightTowardsSun;
        /* 0x338 */ public float IndoorsLightingWeightGround;
        /* 0x33C */ public float IndoorsLightingTransitionTime;
        /* 0x340 */ public float IndoorsLightingThreshold;
        /* 0x344 */ public float IndoorsLightingPlanetMax;
        /* 0x348 */ public float IndoorsLightingAbandonedFreighterMax;
        /* 0x34C */ public float IndoorsLightingNexusMax;
        /* 0x350 */ public float MaxElevation;
        /* 0x354 */ public float SphereLodTextureScale;
        /* 0x358 */ public bool ForceAddUnderwaterProps;
        /* 0x359 */ public bool ForceAddCaveProps;
        /* 0x35C */ public float DistortionStep;
        /* 0x360 */ public float HDeform;
        /* 0x364 */ public float SDeform;
        /* 0x368 */ public float VDeform;
        /* 0x36C */ public float LocationStableTime;
        /* 0x370 */ public float InterestStableTime;
        /* 0x374 */ public float TemperatureSmoothTime;
        /* 0x378 */ public float SunFactorMin;
        /* 0x37C */ public float ExposureSurfaceContrib;
        /* 0x380 */ public float ExposureSurfaceDistMax;
        /* 0x384 */ public float ExposureGroundFactorAddMul;
        /* 0x388 */ public Vector2f ExposureHeightBracket;
        /* 0x390 */ public float DailyTempChangePercent;
        /* 0x394 */ public float SpaceTemperature;
        /* 0x398 */ public float AbandonedFreighterMinTemperature;
        /* 0x39C */ public float AbandonedFreighterMaxTemperature;
        /* 0x3A0 */ public float ShipTemperature;
        /* 0x3A4 */ public float SpaceRadiation;
        /* 0x3A8 */ public float ShipRadiation;
        /* 0x3AC */ public float SpaceToxicity;
        /* 0x3B0 */ public float ShipToxicity;
        /* 0x3B4 */ public bool MatchPlantPalettes;
        /* 0x3B8 */ public float DuplicateColourThreshold;
        // size: 0x3
        public enum SwitchTypeEnum { None, Debug, Enabled }
        /* 0x3BC */ public SwitchTypeEnum SwitchType;
        /* 0x3C0 */ public float GrassNormalUpright;
        /* 0x3C4 */ public float GrassNormalOffset;
        /* 0x3C8 */ public float GrassNormalSpherify;
        /* 0x3CC */ public float GrassNormalMap;
        /* 0x3D0 */ public float MinPlacementBlendValue;
        /* 0x3D4 */ public float MinPlacementBlendValuePatch;
        /* 0x3D8 */ public float MaxPlacementBlendValuePatch;
        /* 0x3DC */ public float MinPlacementObjectScale;
        /* 0x3E0 */ public float SpaceStationStateBoundingBoxScaler;
        /* 0x3E4 */ public float AtmosphereSpaceRadius;
        /* 0x3E8 */ public float SpawnLowerAtmosphereRadiusMultiplier;
        /* 0x3EC */ public float TerrainFadeTime;
        /* 0x3F0 */ public float TerrainFadeTimeInShip;
        /* 0x3F4 */ public float CreatureFadeTime;
        /* 0x3F8 */ public float FloraFadeTimeMin;
        /* 0x3FC */ public float FloraFadeTimeMax;
        /* 0x400 */ public float PlanetUnwrapMin;
        /* 0x404 */ public float PlanetUnwrapMax;
        /* 0x408 */ public float TerrainFlattenMin;
        /* 0x40C */ public float TerrainFlattenMax;
        /* 0x410 */ public float HeightFogHeightMin;
        /* 0x414 */ public float WaterFogHeightMax;
        /* 0x418 */ public float WaterAlphaHeightMin;
        /* 0x41C */ public float WaterAlphaHeightMax;
        /* 0x420 */ public float DoFHeightMin;
        /* 0x424 */ public float DoFHeightMax;
        /* 0x428 */ public float SunClampHeightMin;
        /* 0x42C */ public float SunClampHeightMax;
        /* 0x430 */ public float HeavyAirFadeDistance;
        /* 0x434 */ public float HeavyAirFadeInTime;
        /* 0x438 */ public float HeavyAirFadeOutTime;
        /* 0x43C */ public float PlanetFlipDistance;
        /* 0x440 */ public float PlanetEffectEndDistance;
        /* 0x444 */ public float AsteroidFadeHeightMin;
        /* 0x448 */ public float AsteroidFadeHeightMax;
        /* 0x44C */ public float AsteroidScale;
        /* 0x450 */ public float SmallAsteroidScale;
        /* 0x454 */ public float AsteroidMinRotate;
        /* 0x458 */ public float AsteroidMaxRotate;
        /* 0x45C */ public float MinWaterReflections;
        /* 0x460 */ public List<float> SpacePlanetFogStrength;
        /* 0x470 */ public List<float> SkyBlendLength;
        /* 0x480 */ public float SkyAtmospherePower;
        /* 0x488 */ public List<float> SkyAtmosphereBlendLength;
        /* 0x498 */ public List<float> FarBlendHeight;
        /* 0x4A8 */ public float FarBlendLength;
        /* 0x4AC */ public float IndoorColourBlendTime;
        /* 0x4B0 */ public Colour IndoorAmbientColour;
        /* 0x4C0 */ public float LightDirectionHeight;
        /* 0x4C4 */ public float LightDirectionBlend;
        /* 0x4C8 */ public float LightColourHeight;
        /* 0x4CC */ public float LightColourBlend;
        /* 0x4D0 */ public float ObjectSpawnFirstRadius;
        /* 0x4D4 */ public float ObjectSpawnFirstDotCheck;
        /* 0x4D8 */ public float ObjectSpawnDetailRadius;
        /* 0x4DC */ public float InteractionRadius;
        /* 0x4E0 */ public bool EnableWind;
        /* 0x4E8 */ public List<TkShearWindData> ShearWindSettings;
        /* 0x4F8 */ public int HotspotsLOD;
        /* 0x4FC */ public float RegionHotspotProbability;
        /* 0x500 */ public float MaxHotspotOffsetDistance;
        /* 0x504 */ public float MinHotspotFalloffDistance;
        /* 0x508 */ public float MaxHotspotFalloffDistance;
        /* 0x50C */ public GcEnvironmentProperties EnvironmentProperties;
        /* 0x584 */ public GcEnvironmentProperties EnvironmentPrimeProperties;
    }
}

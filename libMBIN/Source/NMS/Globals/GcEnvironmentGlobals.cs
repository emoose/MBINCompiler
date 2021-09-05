using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x5A0, GUID = 0xC6032F86FBBBB082, NameHash = 0x1E09DD001FDA82F8)]
    public class GcEnvironmentGlobals : NMSTemplate
    {
        [NMS(Size = 0x4)]
        /* 0x000 */ public TkLODSettingsData[] LODSettings;
        /* 0x1D0 */ public Vector2f SpaceBuildingTemperature;
        /* 0x1E0 */ public GcCloudProperties CloudProperties;
        /* 0x2C0 */ public float SenseProbingValueSmoothingTime;
        /* 0x2C4 */ public float SenseProbingValueSmoothingTimeMed;
        /* 0x2C8 */ public float SenseProbingValueSmoothingTimeSlow;
        /* 0x2CC */ public float IndoorsLightingWeightAround;
        /* 0x2D0 */ public float IndoorsLightingWeightOverhead;
        /* 0x2D4 */ public float IndoorsLightingWeightTowardsSun;
        /* 0x2D8 */ public float IndoorsLightingWeightGround;
        /* 0x2DC */ public float IndoorsLightingTransitionTime;
        /* 0x2E0 */ public float IndoorsLightingThreshold;
        /* 0x2E4 */ public float IndoorsLightingPlanetMax;
        /* 0x2E8 */ public float IndoorsLightingAbandonedFreighterMax;
        /* 0x2EC */ public float IndoorsLightingNexusMax;
        /* 0x2F0 */ public float MaxElevation;
        /* 0x2F4 */ public float SphereLodTextureScale;
        /* 0x2F8 */ public bool ForceAddUnderwaterProps;
        /* 0x2F9 */ public bool ForceAddCaveProps;
        /* 0x2FC */ public float DistortionStep;
        /* 0x300 */ public float HDeform;
        /* 0x304 */ public float SDeform;
        /* 0x308 */ public float VDeform;
        /* 0x30C */ public float LocationStableTime;
        /* 0x310 */ public float InterestStableTime;
        /* 0x314 */ public float TemperatureSmoothTime;
        /* 0x318 */ public float SunFactorMin;
        /* 0x31C */ public float ExposureSurfaceContrib;
        /* 0x320 */ public float ExposureSurfaceDistMax;
        /* 0x324 */ public float ExposureGroundFactorAddMul;
        /* 0x328 */ public Vector2f ExposureHeightBracket;
        /* 0x330 */ public float DailyTempChangePercent;
        /* 0x334 */ public float SpaceTemperature;
        /* 0x338 */ public float AbandonedFreighterMinTemperature;
        /* 0x33C */ public float AbandonedFreighterMaxTemperature;
        /* 0x340 */ public float ShipTemperature;
        /* 0x344 */ public float SpaceRadiation;
        /* 0x348 */ public float ShipRadiation;
        /* 0x34C */ public float SpaceToxicity;
        /* 0x350 */ public float ShipToxicity;
        /* 0x354 */ public bool MatchPlantPalettes;
        /* 0x358 */ public float DuplicateColourThreshold;
        // size: 0x3
        public enum SwitchTypeEnum { None, Debug, Enabled }
        /* 0x35C */ public SwitchTypeEnum SwitchType;
        /* 0x360 */ public float GrassNormalUpright;
        /* 0x364 */ public float GrassNormalOffset;
        /* 0x368 */ public float GrassNormalSpherify;
        /* 0x36C */ public float GrassNormalMap;
        /* 0x370 */ public float MinPlacementBlendValue;
        /* 0x374 */ public float MinPlacementBlendValuePatch;
        /* 0x378 */ public float MaxPlacementBlendValuePatch;
        /* 0x37C */ public float MinPlacementObjectScale;
        /* 0x380 */ public float SpaceStationStateBoundingBoxScaler;
        /* 0x384 */ public float AtmosphereSpaceRadius;
        /* 0x388 */ public float SpawnLowerAtmosphereRadiusMultiplier;
        /* 0x38C */ public float TerrainFadeTime;
        /* 0x390 */ public float TerrainFadeTimeInShip;
        /* 0x394 */ public float CreatureFadeTime;
        /* 0x398 */ public float FloraFadeTimeMin;
        /* 0x39C */ public float FloraFadeTimeMax;
        /* 0x3A0 */ public float PlanetUnwrapMin;
        /* 0x3A4 */ public float PlanetUnwrapMax;
        /* 0x3A8 */ public float TerrainFlattenMin;
        /* 0x3AC */ public float TerrainFlattenMax;
        /* 0x3B0 */ public float HeightFogHeightMin;
        /* 0x3B4 */ public float WaterFogHeightMax;
        /* 0x3B8 */ public float WaterAlphaHeightMin;
        /* 0x3BC */ public float WaterAlphaHeightMax;
        /* 0x3C0 */ public float DoFHeightMin;
        /* 0x3C4 */ public float DoFHeightMax;
        /* 0x3C8 */ public float SunClampHeightMin;
        /* 0x3CC */ public float SunClampHeightMax;
        /* 0x3D0 */ public float HeavyAirFadeDistance;
        /* 0x3D4 */ public float HeavyAirFadeInTime;
        /* 0x3D8 */ public float HeavyAirFadeOutTime;
        /* 0x3DC */ public float PlanetFlipDistance;
        /* 0x3E0 */ public float PlanetEffectEndDistance;
        /* 0x3E4 */ public float AsteroidFadeHeightMin;
        /* 0x3E8 */ public float AsteroidFadeHeightMax;
        /* 0x3EC */ public float AsteroidScale;
        /* 0x3F0 */ public float SmallAsteroidScale;
        /* 0x3F4 */ public float AsteroidMinRotate;
        /* 0x3F8 */ public float AsteroidMaxRotate;
        /* 0x3FC */ public float MinWaterReflections;
        /* 0x400 */ public List<float> SpacePlanetFogStrength;
        /* 0x410 */ public List<float> SkyBlendLength;
        /* 0x420 */ public float SkyAtmospherePower;
        /* 0x428 */ public List<float> SkyAtmosphereBlendLength;
        /* 0x438 */ public List<float> FarBlendHeight;
        /* 0x448 */ public float FarBlendLength;
        /* 0x44C */ public float IndoorColourBlendTime;
        /* 0x450 */ public Colour IndoorAmbientColour;
        /* 0x460 */ public float LightDirectionHeight;
        /* 0x464 */ public float LightDirectionBlend;
        /* 0x468 */ public float LightColourHeight;
        /* 0x46C */ public float LightColourBlend;
        /* 0x470 */ public float ObjectSpawnFirstRadius;
        /* 0x474 */ public float ObjectSpawnFirstDotCheck;
        /* 0x478 */ public float ObjectSpawnDetailRadius;
        /* 0x47C */ public float InteractionRadius;
        /* 0x480 */ public bool EnableWind;
        /* 0x488 */ public List<TkShearWindData> ShearWindSettings;
        /* 0x498 */ public int HotspotsLOD;
        /* 0x49C */ public float RegionHotspotProbability;
        /* 0x4A0 */ public float MaxHotspotOffsetDistance;
        /* 0x4A4 */ public float MinHotspotFalloffDistance;
        /* 0x4A8 */ public float MaxHotspotFalloffDistance;
        /* 0x4AC */ public GcEnvironmentProperties EnvironmentProperties;
        /* 0x524 */ public GcEnvironmentProperties EnvironmentPrimeProperties;
    }
}

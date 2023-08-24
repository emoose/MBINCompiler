using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x21AD9EF12868E2FD, NameHash = 0x71CAF682B6986E6E)]
    public class GcGameplayGlobals : NMSTemplate
    {
        /* 0x0000 */ public float TurretAITargetingDistanceFactor;
        /* 0x0004 */ public float TurretAITargetingPitchAngleFactor;
        /* 0x0008 */ public float TurretAITargetingYawAngleFactor;
        /* 0x000C */ public float TurretAITargetingLastHitFactor;
        /* 0x0010 */ public float TurretAITargetingFocusPlayerFactor;
        [NMS(Size = 0x1, EnumType = typeof(GcModularCustomisationResourceType.ModularCustomisationResourceTypeEnum))]
        /* 0x0020 */ public GcModularCustomisationConfig[] ModularCustomisationConfigs;
        /* 0x0240 */ public float ScanToRevealDelayOverride;
        /* 0x0244 */ public bool ScanToRevealIgnoreRequirements;
        /* 0x0245 */ public bool ScanToRevealNPCsAlwaysTriggersCameraEvent;
        /* 0x0248 */ public float NPCWaitWhenRevealedTime;
        /* 0x0250 */ public GcDifficultyConfig DifficultyConfig;
        /* 0x28E8 */ public float ScanToRevealVFXBaseScalingSize;
        /* 0x28F0 */ public NMSString0x10 PirateMissionPrimaryReward;
        /* 0x2900 */ public NMSString0x10 PirateMissionSecondReward;
        /* 0x2910 */ public NMSString0x10 BuildersWordReward;
        [NMS(Size = 0x3, EnumType = typeof(GcMissionDifficulty.MissionDifficultyEnum))]
        /* 0x2920 */ public float[] MissionSubstanceDifficultyMultipliers;
        /* 0x292C */ public bool UseSecondaryBiomeSubstances;
        /* 0x292D */ public bool TechMustBeInTechInventory;
        /* 0x292E */ public bool DebugPrintShootables;
        /* 0x2930 */ public float SpecialTechSlotBonus;
        /* 0x2934 */ public int RocketLockerFuelUse;
        /* 0x2938 */ public bool EnableTechPackaging;
        /* 0x293C */ public float CargoShieldStrength;
        /* 0x2940 */ public float TechDamageChanceShieldedMax;
        /* 0x2944 */ public float TechDamageChanceShieldLevelMin;
        /* 0x2948 */ public float TechDamageChanceShieldLevelMax;
        /* 0x294C */ public float TechDamageChanceToSelectPrimary;
        /* 0x2950 */ public float PirateRaidAccelerator;
        /* 0x2954 */ public float PirateGroundAccelerator;
        /* 0x2958 */ public float PirateGroundInventoryAccelerator;
        /* 0x295C */ public float PoliceAcceleratorStationLockOn;
        /* 0x2960 */ public float PoliceAcceleratorPulseExtra;
        /* 0x2964 */ public int PoliceAcceleratorSmugglingItemsMax;
        /* 0x2968 */ public float PoliceAcceleratorSmugglingMulMax;
        /* 0x296C */ public float PoliceAcceleratorNoCargoWealthy;
        /* 0x2970 */ public float PoliceAcceleratorNoCargoNormal;
        /* 0x2974 */ public float PoliceAcceleratorNoCargoSkipScanOdds;
        /* 0x2978 */ public float ShipInterestAcceleratorInAsteroidField;
        /* 0x297C */ public float InfestedPlanetDeepSpaceFlybyMultiplier;
        /* 0x2980 */ public float ShipMiningMul;
        /* 0x2984 */ public float SmugglerSellingMarkup;
        /* 0x2988 */ public float IllegalTechProductTradingMod;
        /* 0x298C */ public float CombatLevelBestWeaponBias;
        /* 0x2990 */ public float CombatLevelBaseValueBoltcaster;
        /* 0x2994 */ public float CombatLevelBaseValueShotgun;
        /* 0x2998 */ public float CombatLevelBaseValueRailgun;
        /* 0x299C */ public float CombatLevelBaseValueSMG;
        /* 0x29A0 */ public float CombatLevelBaseValueCannon;
        /* 0x29A4 */ public float CombatLevelBaseValueGrenade;
        /* 0x29A8 */ public float CombatLevelSClassValue;
        /* 0x29B0 */ public NMSString0x10 NexusRecipeCostType;
        /* 0x29C0 */ public int NexusRecipeCostNaniteMultiplier;
        /* 0x29C4 */ public float ShipScanPlanetRechargeMultiplier;
        /* 0x29C8 */ public float ShipScanSpaceRechargeMultiplier;
        /* 0x29D0 */ public NMSString0x10 FreeSuitSlotID;
        /* 0x29E0 */ public float InitialLocationProtectionRadiusMultiplier;
        /* 0x29E4 */ public float PartyPlanetSearchDistance;
        /* 0x29E8 */ public float UnderwaterLightningDamageDistanceMultiplier;
        /* 0x29EC */ public int MaxActiveWeatherHazardGifts;
        /* 0x29F0 */ public float WeatherHazardGiftMaxDistance;
        /* 0x29F4 */ public float WeatherHazardGiftLifeTime;
        /* 0x29F8 */ public GcTechnologyCategory TechnologyOverrideForSmuggler;
        /* 0x29FC */ public float MaxMeteorSurfaceAngle;
        /* 0x2A00 */ public float StormGravityChangeTime;
        /* 0x2A04 */ public float StormBonusJetpackMod;
        /* 0x2A08 */ public float StormBonusSprintMod;
        /* 0x2A0C */ public float StormBonusMiningHeatMod;
        /* 0x2A10 */ public float StormBonusMiningAmountMod;
        /* 0x2A14 */ public GcPlayerHazardType StormBonusJetpackWeather;
        /* 0x2A18 */ public GcPlayerHazardType StormBonusSprintWeather;
        /* 0x2A1C */ public GcPlayerHazardType StormBonusMiningHeatWeather;
        /* 0x2A20 */ public GcPlayerHazardType StormBonusMiningAmountWeather;
        /* 0x2A24 */ public float AlienPodThreshold2;
        /* 0x2A28 */ public float AlienPodThreshold1;
        /* 0x2A30 */ public Colour BulletTraceLineColour;
        /* 0x2A40 */ public float BulletTraceLineWidth;
        /* 0x2A44 */ public float ShipBulletTraceLineWidth;
        /* 0x2A48 */ public float VehicleAllIconScanTime;
        /* 0x2A4C */ public int GPSRandomChangeTimeWide;
        /* 0x2A50 */ public int GPSRandomChangeTimeMid;
        /* 0x2A54 */ public int GPSRandomChangeTimeNarrow;
        /* 0x2A58 */ public float SalvageValueAsProds;
        /* 0x2A5C */ public int SalvageSubstanceValueThreshold;
        [NMS(Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x2A60 */ public NMSString0x10[] SalvageRewardsShuttle;
        [NMS(Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x2AA0 */ public NMSString0x10[] SalvageRewardsDropship;
        [NMS(Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x2AE0 */ public NMSString0x10[] SalvageRewardsFighter;
        [NMS(Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x2B20 */ public NMSString0x10[] SalvageRewardsScience;
        [NMS(Size = 0x5)]
        /* 0x2B60 */ public NMSString0x10[] SalvageTechList;
        [NMS(Size = 0x5)]
        /* 0x2BB0 */ public NMSString0x10[] SalvageTechListMultiTool;
        /* 0x2C00 */ public List<NMSString0x10> SalvageProdsList;
        /* 0x2C10 */ public List<NMSString0x10> SalvageSubstancesList;
        /* 0x2C20 */ public float TorpedoCooldown;
        /* 0x2C24 */ public int MaxTorpedoesInFlight;
        /* 0x2C28 */ public float TorpedoInitialWait;
        /* 0x2C2C */ public float TorpedoCooldownRandomExtra;
        /* 0x2C30 */ public float TorpedoLaunchWarning;
        /* 0x2C34 */ public float MultidimensionalFadeTime;
        /* 0x2C38 */ public float TeleporterDistanceTravelledMultiplier;
        /* 0x2C40 */ public GcScanEffectData BinocularSelectedEffect;
        /* 0x2C90 */ public Colour BinocularSelectedColour;
        /* 0x2CA0 */ public Colour BinocularSelectedUnknownColour;
        /* 0x2CB0 */ public float CockpitScale;
        /* 0x2CB4 */ public float MaxDistanceForLadderTeleport;
        /* 0x2CB8 */ public float AngleFromBaseComputerWhenTeleporting;
        /* 0x2CBC */ public float DistanceFromBaseComputerWhenTeleporting;
        /* 0x2CC0 */ public float AutoTranslateWordChance;
        /* 0x2CC4 */ public bool MissionSurveySuggestSurveyForNearScannables;
        /* 0x2CC8 */ public float MissionSurveyMaxGuidanceDistance;
        /* 0x2CCC */ public float MissionSurveyMaxGuidanceDistanceWorms;
        /* 0x2CD0 */ public NMSString0x10 MissionSurveyWormID;
        /* 0x2CE0 */ public float MissionSurveyMarkerAutoHideTime;
        /* 0x2CE4 */ public float MissionSurveyScanRangeMultiplier;
        /* 0x2CE8 */ public float MissionSurveyMaxScanAngle;
        /* 0x2CEC */ public float MissionSurveyMaxScanAngleScannableComp;
        /* 0x2CF0 */ public float MissionSurveyBeginScanPercentageScannable;
        /* 0x2CF4 */ public float MissionSurveyBeginScanPercentageEvent;
        /* 0x2CF8 */ public float MissionSurveyScanSpeed;
        /* 0x2CFC */ public float MissionSurveyScanSpeedScannableComp;
        /* 0x2D00 */ public float MissionSurveyRevealWithoutScanDistance;
        /* 0x2D04 */ public float MissionSurveyAutoScanDistance;
        /* 0x2D08 */ public float MissionSurveyAutoScanFlattenRadiusMul;
        /* 0x2D0C */ public float MissionSurveySonarMinPulseSpeed;
        /* 0x2D10 */ public float MissionSurveySonarMaxPulseSpeed;
        /* 0x2D14 */ public float MissionSurveySonarPulseSpeedBandCount;
        /* 0x2D18 */ public float MissionSurveyMaxAngleOffset;
        /* 0x2D1C */ public float MissionSurveyMaxSignalConeAngle;
        /* 0x2D20 */ public float MissionSurveyInShipArrivedDistance;
        /* 0x2D24 */ public float SurveyBeginScanPercentage;
        /* 0x2D28 */ public float SurveyScanMinSpeed;
        /* 0x2D2C */ public float SurveyScanMaxSpeed;
        /* 0x2D30 */ public float SurveySonarPulseSpeedBandCount;
        /* 0x2D34 */ public float SurveySonarMinPulseSpeed;
        /* 0x2D38 */ public float SurveySonarMaxPulseSpeed;
        /* 0x2D3C */ public float SurveySonarMiddleRangeMin;
        /* 0x2D40 */ public float SurveySonarMiddleRangeMax;
        /* 0x2D44 */ public float SurveyMaxDistance;
        /* 0x2D48 */ public int CreaturesToBaitForTutorial;
        /* 0x2D4C */ public int CreaturesToFeedForTutorial;
        /* 0x2D50 */ public bool DisableGalaxyMapInQuickMenu;
        /* 0x2D51 */ public bool DisableNexusInQuickMenu;
        /* 0x2D52 */ public bool EnableTeleporters;
        /* 0x2D53 */ public bool AllowSpaceScanEvents;
        /* 0x2D54 */ public bool CanMoveTechnology;
        /* 0x2D58 */ public float NormalModeHeatBonus;
        /* 0x2D5C */ public float BaseLaserHeatTime;
        /* 0x2D60 */ public float HeatAlertTime;
        /* 0x2D64 */ public float HeatDamageBoost;
        /* 0x2D68 */ public float HeatWidthBoost;
        /* 0x2D6C */ public float HeatWidthBoostAlt;
        /* 0x2D70 */ public float OverheatGenerosity;
        /* 0x2D74 */ public float HeatMaxPowerPoint;
        /* 0x2D78 */ public float OverheatDecay;
        /* 0x2D7C */ public TkCurveType OverheatCurve;
        /* 0x2D7D */ public bool UseOverheatColour;
        /* 0x2D80 */ public Colour OverHeatColour;
        /* 0x2D90 */ public Colour OverHeatBarColour;
        /* 0x2DA0 */ public TkCurveType OverheatColourCurveShip;
        /* 0x2DA1 */ public TkCurveType OverheatColourCurve;
        /* 0x2DA4 */ public int RefinerProductsMadeInTime;
        /* 0x2DA8 */ public int RefinerSubsMadeInTime;
        /* 0x2DAC */ public int RefinerProductsMadeInTimeSurvival;
        /* 0x2DB0 */ public int RefinerSubsMadeInTimeSurvival;
        /* 0x2DB8 */ public List<NMSString0x10> HyperdriveAccess;
        /* 0x2DC8 */ public List<NMSString0x10> FreighterHyperdriveAccess;
        /* 0x2DD8 */ public float SeasonalMessageModuleAttractDistanceMul;
        /* 0x2DDC */ public float HmdInteractionRangeMinRange;
        /* 0x2DE0 */ public float HmdInteractionRangeMinDistance;
        /* 0x2DE4 */ public float HmdInteractionRangeMultiplier;
        /* 0x2DE8 */ public bool InstallTechWithInteraction;
        /* 0x2DE9 */ public bool FreighterRequiresRGBHyperdriveUpgrades;
        /* 0x2DEA */ public bool DisableAnomalyAmbientSpawn;
        /* 0x2DEB */ public bool AllowDeconstruct;
        /* 0x2DEC */ public bool AllowBinocularMarker;
        /* 0x2DED */ public bool EveryMaintenanceIsBroken;
        /* 0x2DEE */ public bool SpawnResourceBlobsOnPartDelete;
        /* 0x2DEF */ public bool EnableShootHitEffect;
        /* 0x2DF0 */ public int MaxNumSameGroupTech;
        /* 0x2DF4 */ public float ShootableArmourHighlightHitTime;
        /* 0x2DF8 */ public float ShootableAggroMinStartTime;
        /* 0x2DFC */ public float ShootableAggroForgetTime;
        /* 0x2E00 */ public Colour RefinerColour1A;
        /* 0x2E10 */ public Colour RefinerColour1B;
        /* 0x2E20 */ public Colour RefinerColour1C;
        /* 0x2E30 */ public Colour RefinerColour1D;
        /* 0x2E40 */ public float AtmosphereEntryTime;
        /* 0x2E44 */ public float AtmosphereEntryFadeTimeFactor;
        /* 0x2E48 */ public float AtmosphereEntryOffset;
        /* 0x2E4C */ public TkCurveType AtmosphereEntryCurve;
        /* 0x2E50 */ public float AtmosphereEntryErrorTime;
        /* 0x2E54 */ public int AsteroidScanMaxShown;
        /* 0x2E58 */ public float AsteroidScanTime;
        /* 0x2E5C */ public float AsteroidScanRange;
        /* 0x2E60 */ public float TerrainResourceScanTime;
        /* 0x2E64 */ public float TerrainResourceScanRange;
        /* 0x2E68 */ public float TerrainResourceCompassRange;
        /* 0x2E6C */ public bool BinocsDisplayUnknownCreatures;
        /* 0x2E70 */ public float BinocularScanTargetMinHeight;
        /* 0x2E74 */ public float BinocularScanTargetHeightRange;
        /* 0x2E78 */ public float BinocTimeBeforeScan;
        /* 0x2E7C */ public float BinocMinScanTime;
        /* 0x2E80 */ public float BinocScanTime;
        /* 0x2E84 */ public float BinocCreatureScanTime;
        /* 0x2E88 */ public TkCurveType BinocularScanTargetHeightCurve;
        /* 0x2E8C */ public float BinocularScanTargetInitialFadeTime;
        /* 0x2E90 */ public float BinocularScanTargetScaler;
        /* 0x2E94 */ public float BinocularScanTargetLineWidth;
        /* 0x2E98 */ public float BinocularScanTargetFadeTime;
        /* 0x2EA0 */ public Colour BinocularScanTargetColour;
        /* 0x2EB0 */ public GcScanEffectData BinocularScanEffect;
        /* 0x2F00 */ public float ScannerIconsClumpRadius;
        /* 0x2F04 */ public float ScannableComponentMarkerOffset;
        /* 0x2F08 */ public float ScannableComponentPlaceMarkerOffset;
        /* 0x2F0C */ public float MissionEventAllowResetDistance;
        /* 0x2F10 */ public float AllRecipesKnownNanitesMin;
        /* 0x2F14 */ public float AllRecipesKnownNanitesMax;
        /* 0x2F18 */ public float MaxPossibleShipDamagePotential;
        /* 0x2F1C */ public float BuildingPlayerBaseIconOffset;
        /* 0x2F20 */ public float CriticalHitMultiplier;
        /* 0x2F24 */ public float HitEffectMinTime;
        /* 0x2F28 */ public float GrabPlayerCooldownTime;
        /* 0x2F2C */ public float TapInteractionIncreaseAmount;
        /* 0x2F30 */ public float TapInteractionDecay;
        /* 0x2F40 */ public GcScanEffectData DeconstructEffect;
        /* 0x2F90 */ public GcScanEffectData HitEffect;
        /* 0x2FE0 */ public GcScanEffectData HitEffectCritical;
        /* 0x3030 */ public float CommunicatorSpawnOffset;
        /* 0x3034 */ public float CommunicatorSpawnHeightOffset;
        /* 0x3040 */ public Vector3f CommunicatorShipSpawnOffset;
        /* 0x3050 */ public float CommunicatorSpawnScale;
        /* 0x3054 */ public float CommunicatorSpawnRotation;
        /* 0x3058 */ public float CommunicatorCargoScanDroneScale;
        /* 0x305C */ public float CommunicatorCargoScanDroneScaleFallback;
        /* 0x3060 */ public float CommunicatorCargoScanDroneUpOffset;
        /* 0x3064 */ public float CommunicatorCargoScanDroneUpOffsetFallback;
        /* 0x3068 */ public float CommunicatorCargoScanDroneAtOffsetFallback;
        /* 0x306C */ public float CommunicatorCargoScanDronePitch;
        /* 0x3070 */ public float CommunicatorCargoScanDroneRoll;
        /* 0x3074 */ public float CommunicatorCargoScanDroneYaw;
        /* 0x3078 */ public float CommunicatorFadeTime;
        /* 0x3080 */ public List<GcScanEffectData> CommunicatorEffectTable;
        /* 0x3090 */ public int MaxNumMissionsFromMissionGiver;
        /* 0x3094 */ public float InteractionMinTimeBeforeHighlightedOptionSelection;
        /* 0x3098 */ public float InteractionMinTimeBetweenStickOptionHighlights;
        /* 0x309C */ public float InteractionStickOptionStrength;
        /* 0x30A0 */ public float InteractionMessageModuleDisplayTime;
        /* 0x30A4 */ public float InteractionAttractTime;
        /* 0x30A8 */ public float InteractionDescriptionTextTime;
        /* 0x30AC */ public float InteractionMinTimeForResponseText;
        /* 0x30B0 */ public bool InteractionOverride;
        /* 0x30B4 */ public GcInteractionType InteractionOverrideFrom;
        /* 0x30B8 */ public GcInteractionType InteractionOverrideTo;
        /* 0x30BC */ public float DestroyEffectHeight;
        /* 0x30C0 */ public float DestroyEffectMaxScale;
        /* 0x30C4 */ public float EventTargetSpeed;
        /* 0x30C8 */ public int SpecialMiningAmount;
        /* 0x30CC */ public float SpecialMiningTime;
        /* 0x30D0 */ public int HardModeTechDamageMidNum;
        /* 0x30D4 */ public int HardModeTechDamageMidPercent;
        /* 0x30D8 */ public int HardModeTechDamageHighPercent;
        /* 0x30DC */ public int EarlyPiratesToBeKilled;
        /* 0x30E0 */ public int PlanetPirateFlybyMaxRepeatCounter;
        /* 0x30E4 */ public int PirateInterestOverride;
        /* 0x30E8 */ public float PirateInterestDistance;
        /* 0x30EC */ public float PirateInterestDistanceMPMission;
        [NMS(Size = 0x3)]
        /* 0x30F0 */ public int[] PirateInterestLevels;
        [NMS(Size = 0x3)]
        /* 0x30FC */ public int[] PirateInterestLevelsSurvival;
        /* 0x3108 */ public int PoliceInterestOverride;
        /* 0x310C */ public float PoliceInterestDistance;
        /* 0x3110 */ public float PoliceInterestDistanceMPMission;
        [NMS(Size = 0x3)]
        /* 0x3114 */ public int[] PoliceInterestLevels;
        [NMS(Size = 0x3)]
        /* 0x3120 */ public int[] PoliceInterestLevelsSurvival;
        /* 0x312C */ public float SpaceCombatRadius;
        /* 0x3130 */ public int WarpsBetweenBattles;
        /* 0x3134 */ public float HoursBetweenBattles;
        /* 0x3138 */ public float SpaceBattleRadius;
        /* 0x313C */ public float SpaceBattleAnyHostileShipsRadius;
        /* 0x3140 */ public float FreighterBattleRadius;
        /* 0x3144 */ public int PirateFreighterFrigateCountForReinforce;
        /* 0x3148 */ public float PirateFreighterWarpChargeTimeToAddPerBrokenEngine;
        /* 0x314C */ public float PirateFreighterWarpChargeTime;
        /* 0x3150 */ public float PirateFreighterBeginFleeHealthFraction;
        /* 0x3154 */ public int SpaceBattleMaxTorpedosTargetingLeaderShip;
        /* 0x3158 */ public int SpaceBattleMaxTorpedosTargetingNonLeaderShip;
        /* 0x315C */ public float PirateFreighterRewardDelayTime;
        /* 0x3160 */ public float PirateFreighterRewardMessageDelayTime;
        /* 0x3164 */ public float PirateFreighterRewardDelayTimeEscaped;
        /* 0x3168 */ public float PirateFreighterRewardMessageDelayTimeEscaped;
        /* 0x316C */ public float FreighterFuelRodHealthFraction;
        /* 0x3170 */ public float FreighterCargoPodHealthFraction;
        [NMS(Size = 0x4, EnumType = typeof(GcPlayerConflictData.ConflictLevelEnum))]
        /* 0x3174 */ public float[] ChanceOfPirateFreighterBattleOnWarpToSystem;
        /* 0x3184 */ public float MissileMaxTurnAngle;
        /* 0x3188 */ public float MissileLockTime;
        /* 0x318C */ public float MissileReloadTime;
        /* 0x3190 */ public float MissileRotateMin;
        /* 0x3194 */ public float MissileRotateMax;
        /* 0x3198 */ public float MissileMaxSpeed;
        /* 0x319C */ public float MissileForceMin;
        /* 0x31A0 */ public float MissileForceMax;
        /* 0x31A4 */ public float MissileBrakeForceMin;
        /* 0x31A8 */ public float MissileBrakeForceMax;
        /* 0x31AC */ public float MissileThreatTime;
        /* 0x31B0 */ public float MissileBrakeTime;
        /* 0x31B4 */ public float MissileHitRadius;
        /* 0x31B8 */ public float MissileOffset;
        /* 0x31BC */ public float MissileMinCircleTime;
        /* 0x31C0 */ public float MissileApproachTime;
        /* 0x31C4 */ public float MissileRotateSpeed;
        /* 0x31C8 */ public float ScanStartTimeDelayMinDist;
        /* 0x31CC */ public float ScanStartTimeDelayRange;
        /* 0x31D0 */ public float ScanStartTimeDistanceDelayTime;
        /* 0x31D4 */ public float ScanStickyDecay;
        /* 0x31D8 */ public float CreatureScanStickyDecay;
        /* 0x31DC */ public float CreatureScanAngle;
        /* 0x31E0 */ public float CreatureMinScanTime;
        /* 0x31E4 */ public float ScanAngle;
        /* 0x31E8 */ public float NewDiscoveryDisplayTime;
        /* 0x31EC */ public bool FailToFindBuildings;
        /* 0x31F0 */ public float WaterLandingDamageMultiplier;
        /* 0x31F4 */ public int CritDamage;
        /* 0x31F8 */ public float CritScale;
        /* 0x31FC */ public int NumMissionsPerSolarSystem;
        /* 0x3200 */ public float EmergencyBuildingScanEventDistance;
        /* 0x3204 */ public float EmergencyBuildingScanEventTime;
        /* 0x3208 */ public float ProjectileLightIntensity;
        /* 0x320C */ public float AggressiveSentinelProbability;
        /* 0x3210 */ public float AggressiveSentinelProbabilitySurvival;
        /* 0x3214 */ public float LowSentinelProbability;
        /* 0x3218 */ public float LowSentinelProbabilitySurvival;
        /* 0x321C */ public float NonAggressiveLushSurvivalProbabability;
        /* 0x3220 */ public int MaxDronesLow;
        /* 0x3224 */ public int MaxDronesLowSurvival;
        /* 0x3228 */ public int MaxDronesNormal;
        /* 0x322C */ public int MaxDronesNormalSurvival;
        /* 0x3230 */ public int MaxDronesAggressive;
        /* 0x3234 */ public int MaxDronesAggressiveSurvival;
        /* 0x3238 */ public GcExperienceTimers SentinelTimersLow;
        /* 0x3258 */ public GcExperienceTimers SentinelTimersNormal;
        /* 0x3278 */ public int FreighterStartPecent;
        /* 0x327C */ public GcExperienceTimers FreighterTimers;
        /* 0x329C */ public GcExperienceTimers PlanetPirateTimers;
        /* 0x32BC */ public GcExperienceTimers SpacePirateTimers;
        /* 0x32E0 */ public List<float> PirateEarlySpawnChances;
        /* 0x32F0 */ public float PirateEarlySpawnTime;
        /* 0x32F4 */ public GcExperienceTimers FlybyTimers;
        /* 0x3314 */ public GcExperienceTimers SpaceFlybyTimers;
        /* 0x3334 */ public GcExperienceTimers PoliceTimers;
        [NMS(Size = 0x7, EnumType = typeof(GcProceduralTechnologyData.QualityEnum))]
        /* 0x3354 */ public int[] FreighterTechQualityWeightings;
        /* 0x3370 */ public int SentinelsHigh;
        /* 0x3374 */ public int SentinelsLow;
        /* 0x3378 */ public float AsteroidHitForce;
        /* 0x337C */ public float AsteroidTorqueForce;
        /* 0x3380 */ public float AsteroidCarveRadius;
        /* 0x3384 */ public int DeathMoneyPenalty;
        /* 0x3388 */ public int MaxResourceCrystalBlobSize;
        /* 0x338C */ public float BuildingBeamDistance;
        /* 0x3390 */ public float WaypointScanTime;
        /* 0x3394 */ public int RareSubstanceEffectiveness;
        /* 0x3398 */ public int CommonProductEffectiveness;
        /* 0x339C */ public int RareProductEffectiveness;
        /* 0x33A0 */ public int AsteroidResourceReducer;
        /* 0x33A4 */ public int TunnelStatReducer;
        /* 0x33A8 */ public float VoxelAsteroidResourceChance;
        /* 0x33AC */ public int ResourceReducer;
        /* 0x33B0 */ public int ResourceMinAmount;
        /* 0x33B4 */ public int ResourceMaxAmount;
        /* 0x33B8 */ public int ResourceCommonReducer;
        /* 0x33BC */ public int ResourceCommonMinAmount;
        /* 0x33C0 */ public int ResourceCommonMaxAmount;
        /* 0x33C4 */ public int ResourceDirtReducer;
        /* 0x33C8 */ public int ResourceDirtMinAmount;
        /* 0x33CC */ public int ResourceDirtMaxAmount;
        /* 0x33D0 */ public NMSString0x10 ResourceDirtSubstanceID;
        /* 0x33E0 */ public NMSString0x10 SandwormTerrainResource;
        /* 0x33F0 */ public NMSString0x10 BioShipTerrainResource;
        /* 0x3400 */ public NMSString0x20 RobotResource;
        /* 0x3420 */ public NMSString0x20 DepotResource;
        /* 0x3440 */ public float DockNodeBuyRadius;
        /* 0x3444 */ public float BeaconInteractRange;
        /* 0x3448 */ public float ShipInteractRadius;
        /* 0x344C */ public GcResourceCollectEffect AsteroidResourceCollect;
        /* 0x3480 */ public float ScanAngleCutoff;
        /* 0x3488 */ public NMSString0x10 ToolScan;
        /* 0x3498 */ public NMSString0x10 ToolScanHardMode;
        /* 0x34A8 */ public NMSString0x10 WaypointScan;
        /* 0x34B8 */ public NMSString0x10 BeaconScan;
        /* 0x34C8 */ public NMSString0x10 RadioTowerScan;
        /* 0x34D8 */ public NMSString0x10 ObservatoryScan;
        /* 0x34E8 */ public NMSString0x10 DistressSignalScan;
        /* 0x34F8 */ public NMSString0x10 DebugScanPlanet;
        /* 0x3508 */ public NMSString0x10 DebugScanSpace;
        /* 0x3518 */ public NMSString0x10 ShipScan;
        /* 0x3528 */ public NMSString0x10 VisualScan;
        /* 0x3538 */ public float ZoomFindBuildingRange;
        /* 0x353C */ public float TimeToDisplayScanResults;
        /* 0x3540 */ public float HoverTimeToScan;
        /* 0x3544 */ public float HoverTimeToScanCreatures;
        /* 0x3548 */ public int HoverVisiblePointsNeeded;
        /* 0x3550 */ public List<GcZoomData> ZoomLevels;
        /* 0x3560 */ public GcScanEffectData PassiveScanEffect;
        /* 0x35B0 */ public GcScanEffectData BuildingScanEffect;
        /* 0x3600 */ public GcScanEffectData TargetShipScanEffect;
        /* 0x3650 */ public GcScanEffectData HUDShipScanEffect;
        /* 0x36A0 */ public GcScanEffectData CreatureScanEffect;
        /* 0x36F0 */ public GcScanEffectData ObjectsScanEffect;
        /* 0x3740 */ public GcScanEffectData VRGhostScanEffect;
        /* 0x3790 */ public GcScanEffectData BlankScanEffect;
        /* 0x37E0 */ public GcScanEffectData BaseBuildingValidScanEffect;
        /* 0x3830 */ public GcScanEffectData BaseBuildingPreviewSelectionScanEffect;
        /* 0x3880 */ public GcScanEffectData BaseBuildingSelectionScanEffect;
        /* 0x38D0 */ public GcScanEffectData BaseBuildingDeleteScanEffect;
        /* 0x3920 */ public GcScanEffectData BaseBuildingGhostScanEffect;
        /* 0x3970 */ public GcScanEffectData BaseBuildingSpawnStaticEffect;
        /* 0x39C0 */ public GcScanEffectData BaseBuildingVisionScanEffect;
        /* 0x3A10 */ public GcScanEffectData BaseBuildingErrorInsideScanEffect;
        /* 0x3A60 */ public GcScanEffectData BaseBuildingErrorCollisionScanEffect;
        /* 0x3AB0 */ public GcScanEffectData BaseBuildingErrorImpossibleScanEffect;
        /* 0x3B00 */ public GcScanEffectData BaseBuildingErrorUnaffordableScanEffect;
        /* 0x3B50 */ public GcScanEffectData BaseBuildingErrorAboveWaterScanEffect;
        /* 0x3BA0 */ public GcScanEffectData BaseBuildingErrorBelowWaterScanEffect;
        /* 0x3BF0 */ public GcScanEffectData BaseBuildingRemotePlayerValidScanEffect;
        /* 0x3C40 */ public GcScanEffectData BaseBuildingRemotePlayerSelectionScanEffect;
        /* 0x3C90 */ public float BaseBuildingRemotePlayerErrorAlphaScanEffect;
        /* 0x3C94 */ public bool UseDebugScan;
        /* 0x3C95 */ public bool DebugScanForceBuilding;
        /* 0x3C98 */ public GcBuildingClassification DebugScanForceBuildingType;
        /* 0x3C9C */ public float ShipScanOffset;
        /* 0x3CA0 */ public float ShipScanOffsetGap;
        /* 0x3CA4 */ public TkCurveType ShipScanCurve;
        /* 0x3CA8 */ public float ScannerMarkerFadeTime;
        /* 0x3CAC */ public float ScannerSmallMarkerFadeTime;
        /* 0x3CB0 */ public float ScannerPhysicsProbeAABBSize;
        /* 0x3CB4 */ public float ScannerAnalyzeFXRate;
        /* 0x3CB8 */ public float ScannerSubstanceTimePerTrigger;
        /* 0x3CBC */ public float ScannerTuningA;
        /* 0x3CC0 */ public float ScannerTuningB;
        /* 0x3CC4 */ public float ScannerTuningC;
        /* 0x3CC8 */ public float ScannerTuningD;
        /* 0x3CCC */ public float ScannerTuningResourceOffset1;
        /* 0x3CD0 */ public float ScannerTuningResourceOffset2;
        /* 0x3CD4 */ public float ScannerTuningSmoothStepAmount;
        /* 0x3CD8 */ public float ScannerTuningTrailingEdge;
        /* 0x3CDC */ public bool Autolevel;
        /* 0x3CE0 */ public Colour ScannerColour1;
        /* 0x3CF0 */ public Colour ScannerColour2;
        /* 0x3D00 */ public float HUDStoreFlashTime;
        /* 0x3D04 */ public float ExcitingViewAngle;
        /* 0x3D08 */ public float ExcitingViewRange;
        /* 0x3D0C */ public float ExcitingNearRange;
        /* 0x3D10 */ public float ProjectileSpeedBoost;
        /* 0x3D14 */ public float LineWidth;
        /* 0x3D18 */ public float LockOffFactor;
        /* 0x3D1C */ public float OffscreenFadeDistance;
        /* 0x3D20 */ public float OffscreenMinDot;
        /* 0x3D24 */ public bool HUDUpdateFromData;
        /* 0x3D28 */ public float HUDLockOnAudioTime;
        /* 0x3D2C */ public float HUDArrowPrimaryScaler;
        /* 0x3D30 */ public Vector2f HUDDamageSize;
        /* 0x3D38 */ public Vector2f HUDDamageSplatSize;
        /* 0x3D40 */ public Colour HUDDamageSplatShieldColour;
        /* 0x3D50 */ public Colour HUDDamageSplatPainColour;
        /* 0x3D60 */ public float HUDDamageOffset;
        /* 0x3D64 */ public float HUDDamageScaler;
        /* 0x3D68 */ public float HUDDamageRadius;
        /* 0x3D70 */ public GcShipHUDTargetData HUDTarget;
        /* 0x41A0 */ public float HUDLabelTime;
        /* 0x41A4 */ public float HUDLabelAngle;
        /* 0x41A8 */ public float HUDLabelAngleOffset;
        /* 0x41AC */ public float HUDLabelOffsetX;
        /* 0x41B0 */ public float HUDLabelOffsetY;
        /* 0x41B4 */ public float HUDLabelOffsetZ;
        /* 0x41B8 */ public float HUDLabelScale;
        /* 0x41BC */ public bool PlayHitEffectsOnZeroDamage;
        /* 0x41C0 */ public float MaxSpawnTime;
        /* 0x41C4 */ public NMSString0x80 ResourceParticleFile;
        /* 0x4244 */ public float ResourceParticleSpeed;
        /* 0x4248 */ public float ResourceParticleSpread;
        /* 0x424C */ public int ResourceParticleMaxNum;
        /* 0x4250 */ public int ResourceParticleMinNum;
        /* 0x4254 */ public float MapHeight;
        /* 0x4258 */ public float MapOffset;
        /* 0x425C */ public float MapTargetOffset;
        /* 0x4260 */ public float MapFOV;
        /* 0x4264 */ public float MapRadius;
        /* 0x4268 */ public float HUDScaleAdd;
        /* 0x426C */ public float HUDScaleRadius;
        /* 0x4270 */ public float HUDScaleMin;
        /* 0x4274 */ public float HUDScaleMinAim;
        /* 0x4278 */ public float HUDScaleMax;
        /* 0x427C */ public float HUDScaleFarTarget;
        /* 0x4280 */ public float HUDReticuleMoveBack;
        /* 0x4284 */ public float HUDReticuleMoveAim;
        /* 0x4288 */ public float MouseSensitivity;
        /* 0x428C */ public float MouseSensitivityShip;
        /* 0x4290 */ public float MouseSensitivityVehicle;
        /* 0x4294 */ public float PainTime;
        /* 0x4298 */ public TkCurveType PainCurve;
        /* 0x42A0 */ public Colour PainColour;
        /* 0x42B0 */ public float GunOffsetX;
        /* 0x42B4 */ public float GunOffsetY;
        /* 0x42B8 */ public float GunOffsetZ;
        /* 0x42BC */ public float GunOffsetAggressiveX;
        /* 0x42C0 */ public float GunOffsetAggressiveY;
        /* 0x42C4 */ public float GunOffsetAggressiveZ;
        /* 0x42C8 */ public float GunDownAngle;
        /* 0x42CC */ public float GunUpAngle;
        /* 0x42D0 */ public float BarrelOffset;
        /* 0x42D4 */ public float HitOffset;
        /* 0x42D8 */ public GcTracerData BulletTracer;
        /* 0x42F0 */ public GcTracerData ShipTracer;
        /* 0x4308 */ public NMSString0x10 DefaultAnim;
        /* 0x4318 */ public bool DebugDrawTriggerBoxes;
        /* 0x431C */ public float SpeedReadoutMultiplier;
        /* 0x4320 */ public float SpaceSpeedReadoutMultiplier;
        /* 0x4324 */ public float CombatSpeedReadoutMultiplier;
        /* 0x4328 */ public int TorchCookieIndex;
        /* 0x432C */ public float TorchFoV;
        /* 0x4330 */ public float TorchStrength;
        /* 0x4334 */ public int TorchDimCookieIndex;
        /* 0x4338 */ public float TorchDimFoV;
        /* 0x433C */ public float TorchDimStrength;
        /* 0x4340 */ public float InteractionTorchFoV;
        /* 0x4344 */ public float InteractionTorchStrength;
        /* 0x4348 */ public float UndergroundTorchFoV;
        /* 0x434C */ public float UndergroundTorchFoVFar;
        /* 0x4350 */ public float UndergroundTorchStrength;
        /* 0x4354 */ public float UndergroundTorchStrengthFar;
        /* 0x4358 */ public float TorchOffsetX;
        /* 0x435C */ public float TorchOffsetY;
        /* 0x4360 */ public float TorchOffsetZ;
        /* 0x4364 */ public float TorchOffsetZMin;
        /* 0x4368 */ public float TorchOffsetZSpeedRange;
        /* 0x436C */ public float TorchOffsetZMinSpeed;
        /* 0x4370 */ public float TorchHandOffsetX;
        /* 0x4374 */ public float TorchHandOffsetY;
        /* 0x4378 */ public float TorchHandOffsetZ;
        /* 0x437C */ public bool TorchDisabledInTheDay;
        /* 0x4380 */ public float TorchRotation;
        /* 0x4384 */ public float TorchFollowCameraPitch;
        /* 0x4388 */ public float TorchFollowCameraTime;
        /* 0x4390 */ public Colour TorchColour;
        /* 0x43A0 */ public float PlayerAmbientSpotLightIntensity;
        /* 0x43B0 */ public Colour PlayerAmbientSpotLightColour;
        /* 0x43C0 */ public float PlayerAmbientSpotLightOffsetY;
        /* 0x43C4 */ public float PlayerAmbientSpotLightOffsetZ;
        /* 0x43C8 */ public float SimpleInteractionPickupAngle;
        /* 0x43CC */ public float SimpleInteractionPickupRadius;
        /* 0x43D0 */ public float SimpleInteractionMessageTime;
        /* 0x43D4 */ public float InteractionPickupAngle;
        /* 0x43D8 */ public float InteractionPickupRadius;
        /* 0x43DC */ public float ExplosionRadiusMultiplier;
        /* 0x43E0 */ public float ExplosionForce;
        /* 0x43E4 */ public float ExplosionForceMaxForceRadius;
        /* 0x43E8 */ public float LaserExplosionForceRadius;
        /* 0x43EC */ public float LaserExplosionForce;
        /* 0x43F0 */ public float LaserExplosionForceMaxForceRadius;
        /* 0x43F4 */ public NMSString0x80 InitialDebrisScene;
        /* 0x4474 */ public float BonusSameTypeElementsAdd;
        /* 0x4478 */ public float BonusSameTypeElementsMultiply;
        /* 0x447C */ public float BonusChildTypeElementsAdd;
        /* 0x4480 */ public float BonusChildTypeElementsMultiply;
        /* 0x4484 */ public float InteractionComponentUpdateDistance;
        /* 0x4488 */ public float GoalGapVoxelDist;
        /* 0x448C */ public float BlackHoleJumpVoxelDist;
        /* 0x4490 */ public float BlackHoleJumpVoxelVariation;
        /* 0x4494 */ public float JumpToCenterFuelCost;
        /* 0x4498 */ public int WarpsBetweenMiniStation;
        /* 0x449C */ public float HoursBetweenMiniStation;
        /* 0x44A0 */ public NMSString0x80 LegacyBaseBuildingTable;
        /* 0x4520 */ public NMSString0x80 BaseBuildingTable;
        /* 0x45A0 */ public float BaseBuildingHoverTimeToKnowPart;
        /* 0x45A8 */ public ulong NPCWorkerInteractionCooldown;
        /* 0x45B0 */ public float LightStrength;
        /* 0x45B4 */ public float AirLockDoorRange;
        /* 0x45B8 */ public bool DisableBasePowerHUDOverlay;
        /* 0x45B9 */ public bool KeepAttackingMaxWantedLevel;
        /* 0x45BA */ public bool UseMultiplierBonus;
        /* 0x45BC */ public float ShipDisplayDamageMultiplier;
        /* 0x45C0 */ public bool UseTradingCostTable;
        /* 0x45C1 */ public bool ChangePricesLocally;
        /* 0x45C2 */ public bool ShowPriceMarkupsAsPercentages;
        /* 0x45C4 */ public int ProductItemStockDecayTime;
        /* 0x45C8 */ public int ProductItemStockReplenishTime;
        /* 0x45CC */ public int SubstanceItemStockDecayTime;
        /* 0x45D0 */ public int SubstanceItemStockReplenishTime;
        /* 0x45D4 */ public GcPortalData Portal;
        /* 0x45DC */ public int FourthRaceSpawnPercentage;
        /* 0x45E0 */ public int NonDominantRaceSpawnPercentage;
        /* 0x45E4 */ public int NonDominantRaceSpawnPercentagePirate;
        /* 0x45E8 */ public float CorruptSentinelProbability;
        /* 0x45EC */ public float ViciousSentinelProbability;
        /* 0x45F0 */ public float ViciousStormProbability;
        /* 0x45F4 */ public float ViciousWeatherProbability;
        /* 0x45F8 */ public float ScrapDroneProbability;
        /* 0x45FC */ public float MaxRespawnOnGroundHeight;
        /* 0x4600 */ public float DeadPlanetGravityFactor;
        /* 0x4610 */ public GcScanEffectData ShipSalvageScanEffect;
        /* 0x4660 */ public float SalvageShipPitch;
        /* 0x4664 */ public float SalvageShipHeightOffset;
        /* 0x4668 */ public float SalvageShipExplodeSpeed;
        /* 0x466C */ public float SalvageShipShowShipSpeed;
        /* 0x4670 */ public float SalvageShipShowShipDistance;
        /* 0x4674 */ public float SalvageShipExplodeShipDistance;
        /* 0x4678 */ public float SalvageShipOneRevolutionTime;
        /* 0x467C */ public float SalvageWeaponPitch;
        /* 0x4680 */ public float SalvageWeaponHeightOffset;
        /* 0x4684 */ public float SalvageWeaponScale;
        /* 0x4688 */ public NMSString0x20A CommunicatorFireteamNexusExitDialog;
        /* 0x46A8 */ public NMSString0x20A CommunicatorNexusExitAbandonWarningDialog;
        /* 0x46C8 */ public float BackgroundSpaceEncounterCheckTimer;
        /* 0x46CC */ public float PulseEncounterCheckTimer;
        /* 0x46D0 */ public float PulseEncounterChance;
        /* 0x46D4 */ public float PulseEncounterChanceStandard;
        /* 0x46D8 */ public float PulseEncounterChanceRed;
        /* 0x46DC */ public float PulseEncounterChanceGreen;
        /* 0x46E0 */ public float PulseEncounterChanceBlue;
        /* 0x46E4 */ public float PulseEncounterStopPower;
        /* 0x46E8 */ public float PulseEncounterStopSpeed;
        /* 0x46EC */ public float DerelictPulseEncounterAtmosphericEffectChance;
        [NMS(Size = 0x7)]
        /* 0x46F0 */ public int[] AlienShipEvolveCosts;
        /* 0x470C */ public float SpawnerWeaponRange;
        /* 0x4710 */ public TkModelResource WeaponSpawnObject;
        /* 0x4794 */ public TkModelResource WeaponSpawnAltObject;
        /* 0x4818 */ public bool UseCustomSaveDirectory;
        /* 0x481C */ public Vector2f FrigateFlybyTimer;
        /* 0x4824 */ public int PersonalInventoryMinWidthMax;
        /* 0x4828 */ public int PersonalInventoryMinHeightMax;
        /* 0x482C */ public int PersonalTechInventoryMinWidthMax;
        /* 0x4830 */ public int PersonalTechInventoryMinHeightMax;
        /* 0x4834 */ public int ShipInventoryMinWidthMax;
        /* 0x4838 */ public int ShipInventoryMinHeightMax;
        /* 0x483C */ public int ShipTechInventoryMinWidthMax;
        /* 0x4840 */ public int ShipTechInventoryMinHeightMax;
        /* 0x4844 */ public int VehicleInventoryMinWidthMax;
        /* 0x4848 */ public int VehicleInventoryMinHeightMax;
        /* 0x484C */ public int WeaponInventoryMinWidthMax;
        /* 0x4850 */ public int WeaponInventoryMinHeightMax;
        /* 0x4854 */ public float AtlasGunCurrencyConversion;
    }
}

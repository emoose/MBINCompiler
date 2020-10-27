using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x1DD0, GUID = 0xC7E9C727B6BEBDB1)]
    public class GcGameplayGlobals : NMSTemplate
    {
        /* 0x0000 */ public GcTechnologyCategory TechnologyOverrideForSmuggler;
        /* 0x0004 */ public float MaxMeteorSurfaceAngle;
        /* 0x0008 */ public float StormGravityChangeTime;
        /* 0x000C */ public float StormBonusJetpackMod;
        /* 0x0010 */ public float StormBonusSprintMod;
        /* 0x0014 */ public float StormBonusMiningHeatMod;
        /* 0x0018 */ public float StormBonusMiningAmountMod;
        /* 0x001C */ public GcPlayerHazardType StormBonusJetpackWeather;
        /* 0x0020 */ public GcPlayerHazardType StormBonusSprintWeather;
        /* 0x0024 */ public GcPlayerHazardType StormBonusMiningHeatWeather;
        /* 0x0028 */ public GcPlayerHazardType StormBonusMiningAmountWeather;
        /* 0x002C */ public float AlienPodThreshold2;
        /* 0x0030 */ public float AlienPodThreshold1;  // Yes... these are the order in the exe...
        /* 0x0040 */ public Colour BulletTraceLineColour;
        /* 0x0050 */ public float BulletTraceLineWidth;
        /* 0x0054 */ public float TracerBeamStart;
        /* 0x0058 */ public float TracerBeamEnd;
        /* 0x005C */ public float VehicleAllIconScanTime;
        /* 0x0060 */ public int GPSRandomChangeTimeWide;
        /* 0x0064 */ public int GPSRandomChangeTimeMid;
        /* 0x0068 */ public int GPSRandomChangeTimeNarrow;
        /* 0x006C */ public float SalvageValueAsProds;
        /* 0x0070 */ public int SalvageSubstanceValueThreshold;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0074 */ public byte[] Padding74;
        [NMS(Size = 0x4)]
        /* 0x0078 */ public NMSString0x10[] SalvageRewardsShuttle;
        [NMS(Size = 0x4)]
        /* 0x00B8 */ public NMSString0x10[] SalvageRewardsDropship;
        [NMS(Size = 0x4)]
        /* 0x00F8 */ public NMSString0x10[] SalvageRewardsFighter;
        [NMS(Size = 0x4)]
        /* 0x0138 */ public NMSString0x10[] SalvageRewardsScience;
        [NMS(Size = 0xA)]
        /* 0x0178 */ public NMSString0x10[] SalvageTechList;
        [NMS(Size = 0xC)]
        /* 0x0218 */ public NMSString0x10[] SalvageProdsList;
        [NMS(Size = 0x7)]
        /* 0x02D8 */ public NMSString0x10[] SalvageSubstancesList;
        /* 0x0348 */ public bool AlwaysSpaceBattle;
        /* 0x034C */ public float MultidimensionalFadeTime;
        /* 0x0350 */ public float TeleporterDistanceTravelledMultiplier;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x0354 */ public byte[] Padding354;
        /* 0x0360 */ public GcScanEffectData BinocularSelectedEffect;
        /* 0x03B0 */ public Colour BinocularSelectedColour;
        /* 0x03C0 */ public Colour BinocularSelectedUnknownColour;
        /* 0x03D0 */ public float CockpitScale;
        /* 0x03D4 */ public float MaxDistanceForLadderTeleport;
        /* 0x03D8 */ public float AngleFromBaseComputerWhenTeleporting;
        /* 0x03DC */ public float DistanceFromBaseComputerWhenTeleporting;
        /* 0x03E0 */ public float AutoTranslateWordChance;
        /* 0x03E4 */ public float MissionSurveryDistanceToHideDistanceLabel;
        /* 0x03E8 */ public float MissionSurveyMarkerAutoHideTime;
        /* 0x03EC */ public float MissionSurveyScanRangeMultiplier;
        /* 0x03F0 */ public float MissionSurveyMaxScanAngle;
        /* 0x03F4 */ public float MissionSurveyBeginScanPercentageScannable;
        /* 0x03F8 */ public float MissionSurveyBeginScanPercentageEvent;
        /* 0x03FC */ public float MissionSurveyScanSpeed;
        /* 0x0400 */ public float MissionSurveyAutoScanDistance;
        /* 0x0404 */ public float MissionSurveySonarMinPulseSpeed;
        /* 0x0408 */ public float MissionSurveySonarMaxPulseSpeed;
        /* 0x040C */ public float MissionSurveySonarPulseSpeedBandCount;
        /* 0x0410 */ public float MissionSurveyMaxAngleOffset;
        /* 0x0414 */ public float MissionSurveyMaxSignalConeAngle;
        /* 0x0418 */ public float SurveyBeginScanPercentage;
        /* 0x041C */ public float SurveyScanMinSpeed;
        /* 0x0420 */ public float SurveyScanMaxSpeed;
        /* 0x0424 */ public float SurveySonarPulseSpeedBandCount;
        /* 0x0428 */ public float SurveySonarMinPulseSpeed;
        /* 0x042C */ public float SurveySonarMaxPulseSpeed;
        /* 0x0430 */ public float SurveySonarMiddleRangeMin;
        /* 0x0434 */ public float SurveySonarMiddleRangeMax;
        /* 0x0438 */ public float SurveyMaxDistance;
        /* 0x043C */ public int CreaturesToBaitForTutorial;
        /* 0x0440 */ public int CreaturesToFeedForTutorial;
        /* 0x0444 */ public bool DisableGalaxyMapInQuickMenu;
        /* 0x0445 */ public bool DisableNexusInQuickMenu;
        /* 0x0446 */ public bool EnableTeleporters;
        /* 0x0447 */ public bool AllowSpaceScanEvents;
        /* 0x0448 */ public bool CanMoveTechnology;
        /* 0x044C */ public float NormalModeHeatBonus;
        /* 0x0450 */ public float BaseLaserHeatTime;
        /* 0x0454 */ public float HeatAlertTime;
        /* 0x0458 */ public float HeatAlertTimeSurvival;
        /* 0x045C */ public float HeatDamageBoost;
        /* 0x0460 */ public float HeatWidthBoost;
        /* 0x0464 */ public float HeatWidthBoostAlt;
        /* 0x0468 */ public float OverheatGenerosity;
        /* 0x046C */ public float HeatMaxPowerPoint;
        /* 0x0470 */ public float HeatMaxPowerPointSurvival;
        /* 0x0474 */ public float OverheatDecay;
        /* 0x0478 */ public float OverheatDecaySurvival;
        /* 0x047C */ public TkCurveType OverheatCurve;
        /* 0x0480 */ public TkCurveType OverheatCurveSurvival;
        /* 0x0484 */ public bool UseOverheatColour;
        /* 0x0490 */ public Colour OverHeatColour;
        /* 0x04A0 */ public Colour OverHeatBarColour;
        /* 0x04B0 */ public Colour OverHeatColourSurvival;
        /* 0x04C0 */ public TkCurveType OverheatColourCurve;
        /* 0x04C4 */ public TkCurveType OverheatColourCurveSurvival;
        /* 0x04C8 */ public int RefinerProductsMadeInTime;
        /* 0x04CC */ public int RefinerSubsMadeInTime;
        /* 0x04D0 */ public int RefinerProductsMadeInTimeSurvival;
        /* 0x04D4 */ public int RefinerSubsMadeInTimeSurvival;
        [NMS(Size = 0x3)]
        /* 0x04D8 */ public NMSString0x10[] HyperdriveAccess;
        [NMS(Size = 0x3)]
        /* 0x0508 */ public NMSString0x10[] FreighterHyperdriveAccess;
        /* 0x0538 */ public float HmdInteractionRangeMinRange;
        /* 0x053C */ public float HmdInteractionRangeMinDistance;
        /* 0x0540 */ public float HmdInteractionRangeMultiplier;
        [NMSDescription("Set to False to revert to legacy method of installing technologies and upgrades")]
        /* 0x0544 */ public bool InstallTechWithInteraction;
        /* 0x0545 */ public bool FreighterRequiresRGBHyperdriveUpgrades;
        /* 0x0546 */ public bool DisableAnomalyAmbientSpawn;
        /* 0x0547 */ public bool AllowDeconstruct;
        /* 0x0548 */ public bool AllowBinocularMarker;
        /* 0x0549 */ public bool EveryMaintenanceIsBroken;
        /* 0x054A */ public bool SpawnResourceBlobsOnPartDelete;
        /* 0x054B */ public bool EnableShootHitEffect;
        /* 0x054C */ public int MaxNumSameGroupTech;
        /* 0x0550 */ public float ShootableArmourHighlightHitTime;
        /* 0x0554 */ public float ShootableAggroMinStartTime;
        /* 0x0558 */ public float ShootableAggroForgetTime;
        /* 0x0560 */ public Colour RefinerColour1A;
        /* 0x0570 */ public Colour RefinerColour1B;
        /* 0x0580 */ public Colour RefinerColour1C;
        /* 0x0590 */ public Colour RefinerColour1D;
        /* 0x05A0 */ public float AtmosphereEntryTime;
        /* 0x05A4 */ public float AtmosphereEntryFadeTimeFactor;
        /* 0x05A8 */ public float AtmosphereEntryOffset;
        /* 0x05AC */ public TkCurveType AtmosphereEntryCurve;
        /* 0x05B0 */ public float TerrainResourceScanTime;
        /* 0x05B4 */ public float TerrainResourceScanRange;
        /* 0x05B8 */ public float TerrainResourceCompassRange;
        /* 0x05BC */ public bool BinocsDisplayUnknownCreatures;
        /* 0x05C0 */ public float BinocularScanTargetMinHeight;
        /* 0x05C4 */ public float BinocularScanTargetHeightRange;
        /* 0x05C8 */ public float BinocTimeBeforeScan;
        /* 0x05CC */ public float BinocMinScanTime;
        /* 0x05D0 */ public float BinocScanTime;
        /* 0x05D4 */ public float BinocCreatureScanTime;
        /* 0x05D8 */ public TkCurveType BinocularScanTargetHeightCurve;
        /* 0x05DC */ public float BinocularScanTargetInitialFadeTime;
        /* 0x05E0 */ public float BinocularScanTargetScaler;
        /* 0x05E4 */ public float BinocularScanTargetLineWidth;
        /* 0x05E8 */ public float BinocularScanTargetFadeTime;
        /* 0x05F0 */ public Colour BinocularScanTargetColour;
        /* 0x0600 */ public GcScanEffectData BinocularScanEffect;
        /* 0x0650 */ public float ScannerIconsClumpRadius;
        /* 0x0654 */ public float ScannableComponentMarkerOffset;
        /* 0x0658 */ public float ScannableComponentPlaceMarkerOffset;
        /* 0x065C */ public float MissionEventAllowResetDistance;
        /* 0x0660 */ public float AllRecipesKnownNanitesMin;
        /* 0x0664 */ public float AllRecipesKnownNanitesMax;
        /* 0x0668 */ public float MaxPossibleShipDamagePotential;
        /* 0x066C */ public float BuildingPlayerBaseIconOffset;
        /* 0x0670 */ public float CriticalHitMultiplier;
        /* 0x0674 */ public float HitEffectMinTime;
        /* 0x0678 */ public float GrabPlayerCooldownTime;
        /* 0x067C */ public float TapInteractionIncreaseAmount;
        /* 0x0680 */ public float TapInteractionDecay;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x0684 */ public byte[] Padding684;
        /* 0x0690 */ public GcScanEffectData DeconstructEffect;
        /* 0x06E0 */ public GcScanEffectData HitEffect;
        /* 0x0730 */ public GcScanEffectData HitEffectCritical;
        /* 0x0780 */ public float CommunicatorSpawnOffset;
        /* 0x0784 */ public float CommunicatorSpawnHeightOffset;
        /* 0x0790 */ public Vector3f CommunicatorShipSpawnOffset;
        /* 0x07A0 */ public float CommunicatorSpawnScale;
        /* 0x07A4 */ public float CommunicatorSpawnRotation;
        /* 0x07A8 */ public float CommunicatorFadeTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x07AC */ public byte[] Padding7AC;
        [NMS(Size = 0x2)]
        /* 0x07B0 */ public GcScanEffectData[] CommunicatorEffectTable;
        /* 0x0850 */ public int MaxNumMissionsFromMissionGiver;
        /* 0x0854 */ public float InteractionMessageModuleDisplayTime;
        /* 0x0858 */ public float InteractionAttractTime;
        /* 0x085C */ public float InteractionDescriptionTextTime;
        /* 0x0860 */ public float InteractionMinTimeForResponseText;
        /* 0x0864 */ public bool InteractionOverride;
        /* 0x0868 */ public GcInteractionType InteractionOverrideFrom;
        /* 0x086C */ public GcInteractionType InteractionOverrideTo;
        /* 0x0870 */ public float DestroyEffectHeight;
        /* 0x0874 */ public float DestroyEffectMaxScale;
        /* 0x0878 */ public float EventTargetSpeed;
        /* 0x087C */ public int SpecialMiningAmount;
        /* 0x0880 */ public float SpecialMiningTime;
        /* 0x0884 */ public int HardModeTechDamageMidNum;
        /* 0x0888 */ public int HardModeTechDamageMidPercent;
        /* 0x088C */ public int HardModeTechDamageHighPercent;
        /* 0x0890 */ public int EarlyPiratesToBeKilled;
        /* 0x0894 */ public int PirateInterestOverride;
        /* 0x0898 */ public float PirateInterestDistance;
        [NMS(Size = 0x3)]
        /* 0x089C */ public int[] PirateInterestLevels;
        [NMS(Size = 0x3)]
        /* 0x08A8 */ public int[] PirateInterestLevelsSurvival;
        /* 0x08B4 */ public float SpaceCombatRadius;
        /* 0x08B8 */ public int WarpsBetweenBattles;
        /* 0x08BC */ public float HoursBetweenBattles;
        /* 0x08C0 */ public float SpaceBattleRadius;
        /* 0x08C4 */ public float SpaceBattleAnyHostileShipsRadius;
        /* 0x08C8 */ public float FreighterBattleRadius;
        /* 0x08CC */ public float MissileMaxTurnAngle;
        /* 0x08D0 */ public float MissileLockTime;
        /* 0x08D4 */ public float MissileReloadTime;
        /* 0x08D8 */ public float MissileRotateMin;
        /* 0x08DC */ public float MissileRotateMax;
        /* 0x08E0 */ public float MissileMaxSpeed;
        /* 0x08E4 */ public float MissileForceMin;
        /* 0x08E8 */ public float MissileForceMax;
        /* 0x08EC */ public float MissileBrakeForceMin;
        /* 0x08F0 */ public float MissileBrakeForceMax;
        /* 0x08F4 */ public float MissileThreatTime;
        /* 0x08F8 */ public float MissileBrakeTime;
        /* 0x08FC */ public float MissileHitRadius;
        /* 0x0900 */ public float MissileOffset;
        /* 0x0904 */ public float MissileMinCircleTime;
        /* 0x0908 */ public float MissileApproachTime;
        /* 0x090C */ public float MissileRotateSpeed;
        /* 0x0910 */ public float ScanStartTimeDelayMinDist;
        /* 0x0914 */ public float ScanStartTimeDelayRange;
        /* 0x0918 */ public float ScanStartTimeDistanceDelayTime;
        /* 0x091C */ public float ScanStickyDecay;
        /* 0x0920 */ public float CreatureScanStickyDecay;
        /* 0x0924 */ public float CreatureScanAngle;
        /* 0x0928 */ public float CreatureMinScanTime;
        /* 0x092C */ public float ScanAngle;
        /* 0x0930 */ public float NewDiscoveryDisplayTime;
        /* 0x0934 */ public bool FailToFindBuildings;
        /* 0x0938 */ public float WaterLandingDamageMultiplier;
        /* 0x093C */ public int CritDamage;
        /* 0x0940 */ public float CritScale;
        /* 0x0944 */ public int NumMissionsPerSolarSystem;
        /* 0x0948 */ public float EmergencyBuildingScanEventDistance;
        /* 0x094C */ public float EmergencyBuildingScanEventTime;
        /* 0x0950 */ public float ProjectileLightIntensity;
        /* 0x0954 */ public float AggressiveSentinelProbability;
        /* 0x0958 */ public float AggressiveSentinelProbabilitySurvival;
        /* 0x095C */ public float LowSentinelProbability;
        /* 0x0960 */ public float LowSentinelProbabilitySurvival;
        /* 0x0964 */ public float NonAggressiveLushSurvivalProbabability;
        /* 0x0968 */ public int MaxDronesLow;
        /* 0x096C */ public int MaxDronesLowSurvival;
        /* 0x0970 */ public int MaxDronesNormal;
        /* 0x0974 */ public int MaxDronesNormalSurvival;
        /* 0x0978 */ public int MaxDronesAggressive;
        /* 0x097C */ public int MaxDronesAggressiveSurvival;
        /* 0x0980 */ public GcExperienceTimers SentinelTimersLow;
        /* 0x09A0 */ public GcExperienceTimers SentinelTimersNormal;
        /* 0x09C0 */ public GcExperienceTimers SentinelTimersSurvival;
        /* 0x09E0 */ public int FreighterStartPecent;
        /* 0x09E4 */ public GcExperienceTimers FreighterTimers;
        /* 0x0A04 */ public GcExperienceTimers PirateTimers;
        /* 0x0A24 */ public GcExperienceTimers HardPirateTimers;
        [NMS(Size = 0x3)]
        /* 0x0A44 */ public float[] PirateEarlySpawnChances;
        /* 0x0A50 */ public float PirateEarlySpawnTime;
        /* 0x0A54 */ public GcExperienceTimers FlybyTimers;
        /* 0x0A74 */ public GcExperienceTimers SpaceFlybyTimers;
        [NMS(Size = 0x5)]
        /* 0x0A94 */ public int[] FreighterTechQualityWeightings;
        /* 0x0AA8 */ public int SentinelsHigh;
        /* 0x0AAC */ public int SentinelsLow;
        /* 0x0AB0 */ public float AsteroidHitForce;
        /* 0x0AB4 */ public float AsteroidTorqueForce;
        /* 0x0AB8 */ public float AsteroidCarveRadius;
        /* 0x0ABC */ public int DeathMoneyPenalty;
        /* 0x0AC0 */ public int DeathMoneyPenaltyHardMode;
        /* 0x0AC4 */ public int MaxResourceCrystalBlobSize;
        /* 0x0AC8 */ public float BuildingBeamDistance;
        /* 0x0ACC */ public float WaypointScanTime;
        /* 0x0AD0 */ public int RareSubstanceEffectiveness;
        /* 0x0AD4 */ public int CommonProductEffectiveness;
        /* 0x0AD8 */ public int RareProductEffectiveness;
        /* 0x0ADC */ public int AsteroidResourceReducer;
        /* 0x0AE0 */ public float VoxelAsteroidResourceChance;
        /* 0x0AE4 */ public int ResourceReducer;
        /* 0x0AE8 */ public int ResourceMinAmount;
        /* 0x0AEC */ public int ResourceMaxAmount;
        /* 0x0AF0 */ public int ResourceCommonReducer;
        /* 0x0AF4 */ public int ResourceCommonMinAmount;
        /* 0x0AF8 */ public int ResourceCommonMaxAmount;
        /* 0x0AFC */ public int ResourceDirtReducer;            // Do not set to 0
        /* 0x0B00 */ public int ResourceDirtMinAmount;
        /* 0x0B04 */ public int ResourceDirtMaxAmount;
        [NMS(Size = 0x10)]
        /* 0x0B08 */ public string ResourceDirtSubstanceID;
        [NMS(Size = 0x10)]
        /* 0x0B18 */ public string BioShipTerrainResource;        // "SUNGOLD" -> Liquid Sun substance
        [NMS(Size = 0x20)]
        /* 0x0B28 */ public string RobotResource;
        [NMS(Size = 0x20)]
        /* 0x0B48 */ public string DepotResource;
        /* 0x0B68 */ public float DockNodeBuyRadius;
        /* 0x0B6C */ public float BeaconInteractRange;
        /* 0x0B70 */ public float ShipInteractRadius;
        /* 0x0B74 */ public GcResourceCollectEffect AsteroidResourceCollect;
        /* 0x0BA8 */ public float ScanAngleCutoff;
        /* 0x0BAC */ public GcScanData ToolScan;
        /* 0x0BC0 */ public GcScanData ToolScanHardMode;
        /* 0x0BD4 */ public GcScanData WaypointScan;
        /* 0x0BE8 */ public GcScanData BeaconScan;
        /* 0x0BFC */ public GcScanData RadioTowerScan;
        /* 0x0C10 */ public GcScanData ObservatoryScan;
        /* 0x0C24 */ public GcScanData DistressSignalScan;
        /* 0x0C38 */ public GcScanData DebugScanPlanet;
        /* 0x0C4C */ public GcScanData DebugScanSpace;
        /* 0x0C60 */ public GcScanData ShipScan;
        /* 0x0C74 */ public GcScanData VisualScan;
        /* 0x0C88 */ public float ZoomFindBuildingRange;
        /* 0x0C8C */ public float TimeToDisplayScanResults;
        /* 0x0C90 */ public float HoverTimeToScan;
        /* 0x0C94 */ public float HoverTimeToScanCreatures;
        /* 0x0C98 */ public int HoverVisiblePointsNeeded;
        [NMS(Size = 0x4)]
        /* 0x0C9C */ public GcZoomData[] ZoomLevels;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0D0C */ public byte[] PaddingD0C;
        /* 0x0D10 */ public GcScanEffectData PassiveScanEffect;
        /* 0x0D60 */ public GcScanEffectData BuildingScanEffect;
        /* 0x0DB0 */ public GcScanEffectData TargetShipScanEffect;
        /* 0x0E00 */ public GcScanEffectData HUDShipScanEffect;
        /* 0x0E50 */ public GcScanEffectData CreatureScanEffect;
        /* 0x0EA0 */ public GcScanEffectData ObjectsScanEffect;
        /* 0x0EF0 */ public GcScanEffectData VRGhostScanEffect;
        /* 0x0F40 */ public GcScanEffectData BaseBuildingValidScanEffect;
        /* 0x0F90 */ public GcScanEffectData BaseBuildingPreviewSelectionScanEffect;
        /* 0x0FE0 */ public GcScanEffectData BaseBuildingSelectionScanEffect;
        /* 0x1030 */ public GcScanEffectData BaseBuildingDeleteScanEffect;
        /* 0x1080 */ public GcScanEffectData BaseBuildingGhostScanEffect;
        /* 0x10D0 */ public GcScanEffectData BaseBuildingSpawnStaticEffect;
        /* 0x1120 */ public GcScanEffectData BaseBuildingErrorInsideScanEffect;
        /* 0x1170 */ public GcScanEffectData BaseBuildingErrorCollisionScanEffect;
        /* 0x11C0 */ public GcScanEffectData BaseBuildingErrorImpossibleScanEffect;
        /* 0x1210 */ public GcScanEffectData BaseBuildingErrorUnaffordableScanEffect;
        /* 0x1260 */ public GcScanEffectData BaseBuildingErrorAboveWaterScanEffect;
        /* 0x12B0 */ public GcScanEffectData BaseBuildingErrorBelowWaterScanEffect;
        /* 0x1300 */ public GcScanEffectData BaseBuildingRemotePlayerValidScanEffect;
        /* 0x1350 */ public GcScanEffectData BaseBuildingRemotePlayerSelectionScanEffect;
        /* 0x13A0 */ public float BaseBuildingRemotePlayerErrorAlphaScanEffect;
        /* 0x13A4 */ public bool UseDebugScan;
        /* 0x13A5 */ public bool DebugScanForceBuilding;
        /* 0x13A8 */ public GcBuildingClassification DebugScanForceBuildingType;
        /* 0x13AC */ public float ShipScanOffset;
        /* 0x13B0 */ public float ShipScanOffsetGap;
        /* 0x13B4 */ public TkCurveType ShipScanCurve;
        /* 0x13B8 */ public float ScannerMarkerFadeTime;
        /* 0x13BC */ public float ScannerSmallMarkerFadeTime;
        /* 0x13C0 */ public float ScannerPhysicsProbeAABBSize;
        /* 0x13C4 */ public float ScannerAnalyzeFXRate;
        /* 0x13C8 */ public float ScannerSubstanceTimePerTrigger;
        /* 0x13CC */ public float ScannerTuningA;
        /* 0x13D0 */ public float ScannerTuningB;
        /* 0x13D4 */ public float ScannerTuningC;
        /* 0x13D8 */ public float ScannerTuningD;
        /* 0x13DC */ public float ScannerTuningResourceOffset1;
        /* 0x13E0 */ public float ScannerTuningResourceOffset2;
        /* 0x13E4 */ public float ScannerTuningSmoothStepAmount;
        /* 0x13E8 */ public float ScannerTuningTrailingEdge;
        /* 0x13EC */ public bool Autolevel;
        /* 0x13F0 */ public Colour ScannerColour1;
        /* 0x1400 */ public Colour ScannerColour2;
        /* 0x1410 */ public float HUDStoreFlashTime;
        /* 0x1414 */ public float ExcitingViewAngle;
        /* 0x1418 */ public float ExcitingViewRange;
        /* 0x141C */ public float ExcitingNearRange;
        /* 0x1420 */ public float ProjectileSpeedBoost;
        /* 0x1424 */ public float LineWidth;
        /* 0x1428 */ public float LockOffFactor;
        /* 0x142C */ public float OffscreenFadeDistance;
        /* 0x1430 */ public float OffscreenMinDot;
        /* 0x1434 */ public bool HUDUpdateFromData;
        /* 0x1438 */ public float HUDLockOnAudioTime;
        /* 0x143C */ public float HUDArrowPrimaryScaler;
        /* 0x1440 */ public Vector2f HUDDamageSize;
        /* 0x1448 */ public Vector2f HUDDamageSplatSize;
        /* 0x1450 */ public Colour HUDDamageSplatShieldColour;
        /* 0x1460 */ public Colour HUDDamageSplatPainColour;
        /* 0x1470 */ public float HUDDamageOffset;
        /* 0x1474 */ public float HUDDamageScaler;
        /* 0x1478 */ public float HUDDamageRadius;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x147C */ public byte[] Padding147C;
        /* 0x1480 */ public GcShipHUDTargetData HUDTarget;
        /* 0x18B0 */ public float HUDLabelTime;
        /* 0x18B4 */ public float HUDLabelAngle;
        /* 0x18B8 */ public float HUDLabelAngleOffset;
        /* 0x18BC */ public float HUDLabelOffsetX;
        /* 0x18C0 */ public float HUDLabelOffsetY;
        /* 0x18C4 */ public float HUDLabelOffsetZ;
        /* 0x18C8 */ public float HUDLabelScale;
        /* 0x18CC */ public float MaxSpawnTime;
        [NMS(Size = 0x80)]
        /* 0x18D0 */ public string ResourceParticleFile;
        /* 0x1950 */ public float ResourceParticleSpeed;
        /* 0x1954 */ public float ResourceParticleSpread;
        /* 0x1958 */ public int ResourceParticleMaxNum;
        /* 0x195C */ public int ResourceParticleMinNum;
        /* 0x1960 */ public float MapHeight;
        /* 0x1964 */ public float MapOffset;
        /* 0x1968 */ public float MapTargetOffset;
        /* 0x196C */ public float MapFOV;
        /* 0x1970 */ public float MapRadius;
        /* 0x1974 */ public float HUDScaleAdd;
        /* 0x1978 */ public float HUDScaleRadius;
        /* 0x197C */ public float HUDScaleMin;
        /* 0x1980 */ public float HUDScaleMinAim;
        /* 0x1984 */ public float HUDScaleMax;
        /* 0x1988 */ public float HUDScaleFarTarget;
        /* 0x198C */ public float HUDReticuleMoveBack;
        /* 0x1990 */ public float HUDReticuleMoveAim;
        /* 0x1994 */ public float MouseSensitivity;
        /* 0x1998 */ public float MouseSensitivityShip;
        /* 0x199C */ public float MouseSensitivityVehicle;
        /* 0x19A0 */ public float PainTime;
        /* 0x19A4 */ public TkCurveType PainCurve;
        /* 0x19B0 */ public Colour PainColour;
        /* 0x19C0 */ public float GunOffsetX;
        /* 0x19C4 */ public float GunOffsetY;
        /* 0x19C8 */ public float GunOffsetZ;
        /* 0x19CC */ public float GunDownAngle;
        /* 0x19D0 */ public float GunUpAngle;
        /* 0x19D4 */ public float BarrelOffset;
        /* 0x19D8 */ public float HitOffset;
        /* 0x19DC */ public GcTracerData BulletTracer;
        /* 0x19F4 */ public GcTracerData ShipTracer;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1A0C */ public byte[] Padding1A0C;
        [NMS(Size = 0x10)]
        /* 0x1A10 */ public string DefaultAnim;
        /* 0x1A20 */ public bool DebugDrawTriggerBoxes;
        /* 0x1A24 */ public float SpeedReadoutMultiplier;
        /* 0x1A28 */ public float SpaceSpeedReadoutMultiplier;
        /* 0x1A2C */ public int TorchCookieIndex;
        /* 0x1A30 */ public float TorchFoV;
        /* 0x1A34 */ public float TorchStrength;
        /* 0x1A38 */ public int TorchDimCookieIndex;
        /* 0x1A3C */ public float TorchDimFoV;
        /* 0x1A40 */ public float TorchDimStrength;
        /* 0x1A44 */ public float TorchOffsetX;
        /* 0x1A48 */ public float TorchOffsetY;
        /* 0x1A4C */ public float TorchOffsetZ;
        /* 0x1A50 */ public float TorchHandOffsetX;
        /* 0x1A54 */ public float TorchHandOffsetY;
        /* 0x1A58 */ public float TorchHandOffsetZ;
        /* 0x1A5C */ public bool TorchDisabledInTheDay;
        /* 0x1A60 */ public float TorchRotation;
        /* 0x1A64 */ public float TorchFollowCameraPitch;
        /* 0x1A68 */ public float TorchFollowCameraTime;
        /* 0x1A70 */ public Colour TorchColour;
        /* 0x1A80 */ public float PlayerAmbientSpotLightIntensity;
        /* 0x1A90 */ public Colour PlayerAmbientSpotLightColour;
        /* 0x1AA0 */ public float PlayerAmbientSpotLightOffsetY;
        /* 0x1AA4 */ public float PlayerAmbientSpotLightOffsetZ;
        /* 0x1AA8 */ public float SimpleInteractionPickupAngle;
        /* 0x1AAC */ public float SimpleInteractionPickupRadius;
        /* 0x1AB0 */ public float SimpleInteractionMessageTime;
        /* 0x1AB4 */ public float InteractionPickupAngle;
        /* 0x1AB8 */ public float InteractionPickupRadius;
        /* 0x1ABC */ public float ExplosionRadiusMultiplier;
        /* 0x1AC0 */ public float ExplosionForce;
        /* 0x1AC4 */ public float ExplosionForceMaxForceRadius;
        /* 0x1AC8 */ public float LaserExplosionForceRadius;
        /* 0x1ACC */ public float LaserExplosionForce;
        /* 0x1AD0 */ public float LaserExplosionForceMaxForceRadius;
        [NMS(Size = 0x80)]
        /* 0x1AD4 */ public string InitialDebrisScene;
        /* 0x1B54 */ public float BonusSameTypeElementsAdd;
        /* 0x1B58 */ public float BonusSameTypeElementsMultiply;
        /* 0x1B5C */ public float BonusChildTypeElementsAdd;
        /* 0x1B60 */ public float BonusChildTypeElementsMultiply;
        /* 0x1B64 */ public float InteractionComponentUpdateDistance;
        /* 0x1B68 */ public float GoalGapVoxelDist;
        /* 0x1B6C */ public float BlackHoleJumpVoxelDist;
        /* 0x1B70 */ public float BlackHoleJumpVoxelVariation;
        /* 0x1B74 */ public float JumpToCenterFuelCost;
        /* 0x1B78 */ public int WarpsBetweenMiniStation;
        /* 0x1B7C */ public float HoursBetweenMiniStation;
        [NMS(Size = 0x80)]
        /* 0x1B80 */ public string LegacyBaseBuildingTable;
        [NMS(Size = 0x80)]
        /* 0x1C00 */ public string BaseBuildingTable;
        /* 0x1C80 */ public ulong NPCWorkerInteractionCooldown;
        /* 0x1C88 */ public float LightStrength;
        /* 0x1C8C */ public float AirLockDoorRange;
        /* 0x1C90 */ public bool DisableBasePowerHUDOverlay;
        /* 0x1C91 */ public bool KeepAttackingMaxWantedLevel;
        /* 0x1C92 */ public bool UseMultiplierBonus;
        /* 0x1C94 */ public float ShipDisplayDamageMultiplier;
        /* 0x1C98 */ public float IllegalProductTradingMod;
        /* 0x1C9C */ public bool UseTradingCostTable;
        /* 0x1C9D */ public bool ChangePricesLocally;
        /* 0x1C9E */ public bool ShowPriceMarkupsAsPercentages;
        /* 0x1CA0 */ public int ProductItemStockDecayTime;
        /* 0x1CA4 */ public int ProductItemStockReplenishTime;
        /* 0x1CA8 */ public int SubstanceItemStockDecayTime;
        /* 0x1CAC */ public int SubstanceItemStockReplenishTime;
        /* 0x1CB0 */ public GcPortalData Portal;
        /* 0x1CB8 */ public int FourthRaceSpawnPercentage;
        /* 0x1CBC */ public int NonDominantRaceSpawnPercentage;
        /* 0x1CC0 */ public float ViciousSentinelProbability;
        /* 0x1CC4 */ public float ViciousStormProbability;
        /* 0x1CC8 */ public float ViciousWeatherProbability;
        /* 0x1CCC */ public float ScrapDroneProbability;
        /* 0x1CD0 */ public float MaxRespawnOnGroundHeight;
        /* 0x1CD4 */ public float DeadPlanetGravityFactor;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x1CD8 */ public byte[] Padding1CD8;
        /* 0x1CE0 */ public GcScanEffectData ShipSalvageScanEffect;
        /* 0x1D30 */ public float SalvageShipPitch;
        /* 0x1D34 */ public float SalvageShipHeightOffset;
        /* 0x1D38 */ public float SalvageShipExplodeSpeed;
        /* 0x1D3C */ public float SalvageShipShowShipSpeed;
        /* 0x1D40 */ public float SalvageShipShowShipDistance;
        /* 0x1D44 */ public float SalvageShipExplodeShipDistance;
        /* 0x1D48 */ public float SalvageShipOneRevolutionTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1D4C */ public byte[] Padding1D4C;
        [NMS(Size = 0x20)]
        /* 0x1D50 */ public string CommunicatorFireteamNexusExitDialog;
        [NMS(Size = 0x20)]
        /* 0x1D70 */ public string CommunicatorNexusExitAbandonWarningDialog;
        /* 0x1D90 */ public float PulseEncounterCheckTimer;
        /* 0x1D94 */ public float PulseEncounterChance;
        /* 0x1D98 */ public float PulseEncounterChanceStandard;
        /* 0x1D9C */ public float PulseEncounterChanceRed;
        /* 0x1DA0 */ public float PulseEncounterChanceGreen;
        /* 0x1DA4 */ public float PulseEncounterChanceBlue;
        /* 0x1DA8 */ public float PulseEncounterStopPower;
        /* 0x1DAC */ public float PulseEncounterStopSpeed;
        [NMS(Size = 0x5)]
        /* 0x1DB0 */ public int[] AlienShipEvolveCosts;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x1DC4 */ public byte[] EndPadding;
    }
}

/* Notes and algorithms:

Since the names for the sentinal timer and flyby timers are a bit hard to understand,
this is the algorithm that shows how the game uses them:

if SentinelLevel == Agressive:
	MaxActiveDrones = 1
	SentinelTimer = SentinelTimer_Default_or_Aggressive
	FlybyTimer = FlybyTimer_B_or_Aggressive
else:
	MaxActiveDrones = 2
	if RNG(0,100) >= SentinelTimer_Default_Chance_percent:
		SentinelTimer = SentinelTimer_A
		if RNG(0,100) < SentinelTimer_B_Chance_percent:
			SentinelTimer = SentinelTimer_B
	else:
		SentinelTimer = SentinelTimer_Default_or_Aggressive
	
	if RNG(0,100) >= FlybyTimer_Default_Chance_percent:
		FlybyTimer = FlybyTimer_A
		if RNG(0,100) < FlybyTimer_B_Chance_percent:
			FlybyTimer = FlybyTimer_B_or_Aggressive
	else:
		FlybyTimer = FlybyTimer_Default
*/
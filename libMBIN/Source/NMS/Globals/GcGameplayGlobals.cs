using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x1D60, GUID = 0x70F37C71E79EB9C7)]
    public class GcGameplayGlobals : NMSTemplate
    {
        /* 0x000 */ public float AlienPodThreshold2;
        /* 0x004 */ public float AlienPodThreshold1;  // Yes... these are the order in the exe...
        /* 0x010 */ public Colour BulletTraceLineColour;
        /* 0x020 */ public float BulletTraceLineWidth;
        /* 0x024 */ public float TracerBeamStart;
        /* 0x028 */ public float TracerBeamEnd;
        /* 0x02C */ public float VehicleAllIconScanTime;
        /* 0x030 */ public int GPSRandomChangeTimeWide;
        /* 0x034 */ public int GPSRandomChangeTimeMid;
        /* 0x038 */ public int GPSRandomChangeTimeNarrow;
        /* 0x03C */ public float SalvageValueAsProds;
        /* 0x040 */ public int SalvageSubstanceValueThreshold;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x044 */ public byte[] Padding44;
        [NMS(Size = 0x4)]
        /* 0x048 */ public NMSString0x10[] SalvageRewardsShuttle;
        [NMS(Size = 0x4)]
        /* 0x088 */ public NMSString0x10[] SalvageRewardsDropship;
        [NMS(Size = 0x4)]
        /* 0x0C8 */ public NMSString0x10[] SalvageRewardsFighter;
        [NMS(Size = 0x4)]
        /* 0x108 */ public NMSString0x10[] SalvageRewardsScience;
        [NMS(Size = 0xA)]
        /* 0x148 */ public NMSString0x10[] SalvageTechList;
        [NMS(Size = 0xC)]
        /* 0x1E8 */ public NMSString0x10[] SalvageProdsList;
        [NMS(Size = 0x7)]
        /* 0x2A8 */ public NMSString0x10[] SalvageSubstancesList;
        /* 0x318 */ public bool AlwaysSpaceBattle;
        /* 0x31C */ public float MultidimensionalFadeTime;
        /* 0x320 */ public float TeleporterDistanceTravelledMultiplier;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x324 */ public byte[] Padding2F4;
        /* 0x330 */ public GcScanEffectData BinocularSelectedEffect;
		/* 0x380 */ public Colour BinocularSelectedColour;
		/* 0x390 */ public Colour BinocularSelectedUnknownColour;
		/* 0x3A0 */ public float CockpitScale;
		/* 0x3A4 */ public float MaxDistanceForLadderTeleport;
		/* 0x3A8 */ public float AngleFromBaseComputerWhenTeleporting;
		/* 0x3AC */ public float DistanceFromBaseComputerWhenTeleporting;
		/* 0x3B0 */ public float AutoTranslateWordChance;
		/* 0x3B4 */ public float SurveyBeginScanPercentage;
		/* 0x3B8 */ public float SurveyScanMinSpeed;
		/* 0x3BC */ public float SurveyScanMaxSpeed;
		/* 0x3C0 */ public float SurveySonarPulseSpeedBandCount;
		/* 0x3C4 */ public float SurveySonarMinPulseSpeed;
		/* 0x3C8 */ public float SurveySonarMaxPulseSpeed;
		/* 0x3CC */ public float SurveySonarMiddleRangeMin;
		/* 0x3D0 */ public float SurveySonarMiddleRangeMax;
		/* 0x3D4 */ public float SurveyMaxDistance;
		/* 0x3D8 */ public int CreaturesToBaitForTutorial;
		/* 0x3DC */ public int CreaturesToFeedForTutorial;
		/* 0x3E0 */ public bool DisableGalaxyMapInQuickMenu;
		/* 0x3E1 */ public bool DisableNexusInQuickMenu;
		/* 0x3E2 */ public bool EnableTeleporters;
		/* 0x3E3 */ public bool AllowSpaceScanEvents;
		/* 0x3E4 */ public bool CanMoveTechnology;
		/* 0x3E8 */ public float NormalModeHeatBonus;
		/* 0x3EC */ public float BaseLaserHeatTime;
		/* 0x3F0 */ public float HeatAlertTime;
		/* 0x3F4 */ public float HeatAlertTimeSurvival;
		/* 0x3F8 */ public float HeatDamageBoost;
		/* 0x3FC */ public float HeatWidthBoost;
		/* 0x400 */ public float HeatWidthBoostAlt;
		/* 0x404 */ public float OverheatGenerosity;
		/* 0x408 */ public float HeatMaxPowerPoint;
		/* 0x40C */ public float HeatMaxPowerPointSurvival;
		/* 0x410 */ public float OverheatDecay;
		/* 0x414 */ public float OverheatDecaySurvival;
		/* 0x418 */ public TkCurveType OverheatCurve;
		/* 0x41C */ public TkCurveType OverheatCurveSurvival;
		/* 0x420 */ public bool UseOverheatColour;
		/* 0x430 */ public Colour OverHeatColour;
		/* 0x440 */ public Colour OverHeatBarColour;
		/* 0x450 */ public Colour OverHeatColourSurvival;
		/* 0x460 */ public TkCurveType OverheatColourCurve;
		/* 0x464 */ public TkCurveType OverheatColourCurveSurvival;
		/* 0x468 */ public int RefinerProductsMadeInTime;
		/* 0x46C */ public int RefinerSubsMadeInTime;
		/* 0x470 */ public int RefinerProductsMadeInTimeSurvival;
		/* 0x474 */ public int RefinerSubsMadeInTimeSurvival;
        [NMS(Size = 0x3)]
        /* 0x0478 */ public NMSString0x10[] HyperdriveAccess;
        [NMS(Size = 0x3)]
        /* 0x04A8 */ public NMSString0x10[] FreighterHyperdriveAccess;
        /* 0x04D8 */ public float HmdInteractionRangeMinRange;
        /* 0x04DC */ public float HmdInteractionRangeMinDistance;
        /* 0x04E0 */ public float HmdInteractionRangeMultiplier;
        [NMSDescription("Set to False to revert to legacy method of installing technologies and upgrades")]
        /* 0x04E4 */ public bool InstallTechWithInteraction;
        /* 0x04E5 */ public bool FreighterRequiresRGBHyperdriveUpgrades;
        /* 0x04E6 */ public bool DisableAnomalyAmbientSpawn;
        /* 0x04E7 */ public bool AllowDeconstruct;
        /* 0x04E8 */ public bool AllowBinocularMarker;
        /* 0x04E9 */ public bool EveryMaintenanceIsBroken;
        /* 0x04EA */ public bool SpawnResourceBlobsOnPartDelete;
        /* 0x04EB */ public bool EnableShootHitEffect;
        /* 0x04EC */ public int MaxNumSameGroupTech;
        /* 0x04F0 */ public float ShootableArmourHighlightHitTime;
        /* 0x04F4 */ public float ShootableAggroMinStartTime;
        /* 0x04F8 */ public float ShootableAggroForgetTime;
        /* 0x0500 */ public Colour RefinerColour1A;
        /* 0x0510 */ public Colour RefinerColour1B;
        /* 0x0520 */ public Colour RefinerColour1C;
        /* 0x0530 */ public Colour RefinerColour1D;
        /* 0x0540 */ public float AtmosphereEntryTime;
        /* 0x0544 */ public float AtmosphereEntryFadeTimeFactor;
        /* 0x0548 */ public float AtmosphereEntryOffset;
        /* 0x054C */ public TkCurveType AtmosphereEntryCurve;
        /* 0x0550 */ public float TerrainResourceScanTime;
        /* 0x0554 */ public float TerrainResourceScanRange;
        /* 0x0558 */ public float TerrainResourceCompassRange;
        /* 0x055C */ public bool BinocsDisplayUnknownCreatures;
        /* 0x0560 */ public float BinocularScanTargetMinHeight;
        /* 0x0564 */ public float BinocularScanTargetHeightRange;
        /* 0x0568 */ public float BinocTimeBeforeScan;
        /* 0x056C */ public float BinocMinScanTime;
        /* 0x0570 */ public float BinocScanTime;
        /* 0x0574 */ public float BinocCreatureScanTime;
        /* 0x0578 */ public TkCurveType BinocularScanTargetHeightCurve;
        /* 0x057C */ public float BinocularScanTargetInitialFadeTime;
        /* 0x0580 */ public float BinocularScanTargetScaler;
        /* 0x0584 */ public float BinocularScanTargetLineWidth;
        /* 0x0588 */ public float BinocularScanTargetFadeTime;
        /* 0x0590 */ public Colour BinocularScanTargetColour;
        /* 0x05A0 */ public GcScanEffectData BinocularScanEffect;
        /* 0x05F0 */ public float ScannerIconsClumpRadius;
        /* 0x05F4 */ public float ScannableComponentMarkerOffset;
        /* 0x05F8 */ public float ScannableComponentPlaceMarkerOffset;
        /* 0x05FC */ public float MissionEventAllowResetDistance;
        /* 0x0600 */ public float AllRecipesKnownNanitesMin;
        /* 0x0604 */ public float AllRecipesKnownNanitesMax;
        /* 0x0608 */ public float MaxPossibleShipDamagePotential;
        /* 0x060C */ public float BuildingPlayerBaseIconOffset;
        /* 0x0610 */ public float CriticalHitMultiplier;
        /* 0x0614 */ public float HitEffectMinTime;
        /* 0x0618 */ public float GrabPlayerCooldownTime;
        /* 0x061C */ public float TapInteractionIncreaseAmount;
        /* 0x0620 */ public float TapInteractionDecay;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x0624 */ public byte[] Padding624;
        /* 0x0630 */ public GcScanEffectData DeconstructEffect;
        /* 0x0680 */ public GcScanEffectData HitEffect;
        /* 0x06D0 */ public GcScanEffectData HitEffectCritical;
        /* 0x0720 */ public float CommunicatorSpawnOffset;
        /* 0x0724 */ public float CommunicatorSpawnHeightOffset;
        /* 0x0730 */ public Vector3f CommunicatorShipSpawnOffset;
        /* 0x0740 */ public float CommunicatorSpawnScale;
        /* 0x0744 */ public float CommunicatorSpawnRotation;
        /* 0x0748 */ public float CommunicatorFadeTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x074C */ public byte[] Padding74C;
        [NMS(Size = 0x2)]
        /* 0x0750 */ public GcScanEffectData[] CommunicatorEffectTable;
        /* 0x07F0 */ public int MaxNumMissionsFromMissionGiver;
        /* 0x07F4 */ public float InteractionMessageModuleDisplayTime;
        /* 0x07F8 */ public float InteractionAttractTime;
        /* 0x07FC */ public float InteractionDescriptionTextTime;
        /* 0x0800 */ public float InteractionMinTimeForResponseText;
        /* 0x0804 */ public bool InteractionOverride;
        [NMS(Size = 0x03, Ignore = true)]
        /* 0x0805 */ public byte[] Padding805;
        /* 0x0808 */ public GcInteractionType InteractionOverrideFrom;
        /* 0x080C */ public GcInteractionType InteractionOverrideTo;
        /* 0x0810 */ public float DestroyEffectHeight;
        /* 0x0814 */ public float DestroyEffectMaxScale;
        /* 0x0818 */ public float EventTargetSpeed;
        /* 0x081C */ public int SpecialMiningAmount;
        /* 0x0820 */ public float SpecialMiningTime;
        /* 0x0824 */ public int HardModeTechDamageMidNum;
        /* 0x0828 */ public int HardModeTechDamageMidPercent;
        /* 0x082C */ public int HardModeTechDamageHighPercent;
        /* 0x0830 */ public int EarlyPiratesToBeKilled;
        /* 0x0834 */ public int PirateInterestOverride;
        /* 0x0838 */ public float PirateInterestDistance;
        [NMS(Size = 0x3)]
        /* 0x083C */ public int[] PirateInterestLevels;
        [NMS(Size = 0x3)]
        /* 0x0848 */ public int[] PirateInterestLevelsSurvival;
        /* 0x0854 */ public float SpaceCombatRadius;
        /* 0x0858 */ public int WarpsBetweenBattles;
        /* 0x085C */ public float HoursBetweenBattles;
        /* 0x0860 */ public float SpaceBattleRadius;
        /* 0x0864 */ public float SpaceBattleAnyHostileShipsRadius;
        /* 0x0868 */ public float FreighterBattleRadius;
        /* 0x086C */ public float MissileMaxTurnAngle;
        /* 0x0870 */ public float MissileLockTime;
        /* 0x0874 */ public float MissileReloadTime;
        /* 0x0878 */ public float MissileRotateMin;
        /* 0x087C */ public float MissileRotateMax;
        /* 0x0880 */ public float MissileMaxSpeed;
        /* 0x0884 */ public float MissileForceMin;
        /* 0x0888 */ public float MissileForceMax;
        /* 0x088C */ public float MissileBrakeForceMin;
        /* 0x0890 */ public float MissileBrakeForceMax;
        /* 0x0894 */ public float MissileThreatTime;
        /* 0x0898 */ public float MissileBrakeTime;
        /* 0x089C */ public float MissileHitRadius;
        /* 0x08A0 */ public float MissileOffset;
        /* 0x08A4 */ public float MissileMinCircleTime;
        /* 0x08A8 */ public float MissileApproachTime;
        /* 0x08AC */ public float MissileRotateSpeed;
        /* 0x08B0 */ public float ScanStartTimeDelayMinDist;
        /* 0x08B4 */ public float ScanStartTimeDelayRange;
        /* 0x08B8 */ public float ScanStartTimeDistanceDelayTime;
        /* 0x08BC */ public float ScanStickyDecay;
        /* 0x08C0 */ public float CreatureScanStickyDecay;
        /* 0x08C4 */ public float CreatureScanAngle;
        /* 0x08C8 */ public float CreatureMinScanTime;
        /* 0x08CC */ public float ScanAngle;
        /* 0x08D0 */ public float NewDiscoveryDisplayTime;
        /* 0x08D4 */ public bool FailToFindBuildings;
        /* 0x08D8 */ public int CritDamage;
        /* 0x08DC */ public float CritScale;
        /* 0x08E0 */ public int NumMissionsPerSolarSystem;
        /* 0x08E4 */ public float EmergencyBuildingScanEventDistance;
        /* 0x08E8 */ public float EmergencyBuildingScanEventTime;
        /* 0x08EC */ public float ProjectileLightIntensity;
        /* 0x08F0 */ public float AggressiveSentinelProbability;
        /* 0x08F4 */ public float AggressiveSentinelProbabilitySurvival;
        /* 0x08F8 */ public float LowSentinelProbability;
        /* 0x08FC */ public float LowSentinelProbabilitySurvival;
        /* 0x0900 */ public float NonAggressiveLushSurvivalProbabability;
        /* 0x0904 */ public int MaxDronesLow;
        /* 0x0908 */ public int MaxDronesLowSurvival;
        /* 0x090C */ public int MaxDronesNormal;
        /* 0x0910 */ public int MaxDronesNormalSurvival;
        /* 0x0914 */ public int MaxDronesAggressive;
        /* 0x0918 */ public int MaxDronesAggressiveSurvival;
        /* 0x091C */ public GcExperienceTimers SentinelTimersLow;
        /* 0x093C */ public GcExperienceTimers SentinelTimersNormal;
        /* 0x095C */ public GcExperienceTimers SentinelTimersSurvival;
        /* 0x097C */ public int FreighterStartPecent;
        /* 0x0980 */ public GcExperienceTimers FreighterTimers;
        /* 0x09A0 */ public GcExperienceTimers PirateTimers;
        /* 0x09C0 */ public GcExperienceTimers HardPirateTimers;
        [NMS(Size = 0x3)]
        /* 0x09E0 */ public float[] PirateEarlySpawnChances;
        /* 0x09EC */ public float PirateEarlySpawnTime;
        /* 0x09F0 */ public GcExperienceTimers FlybyTimers;
        /* 0x0A10 */ public GcExperienceTimers SpaceFlybyTimers;
        [NMS(Size = 0x4)]
        /* 0x0A30 */ public int[] FreighterTechQualityWeightings;
        /* 0x0A40 */ public int SentinelsHigh;
        /* 0x0A44 */ public int SentinelsLow;
        /* 0x0A48 */ public float AsteroidHitForce;
        /* 0x0A4C */ public float AsteroidTorqueForce;
        /* 0x0A50 */ public float AsteroidCarveRadius;
        /* 0x0A54 */ public int DeathMoneyPenalty;
        /* 0x0A58 */ public int DeathMoneyPenaltyHardMode;
        /* 0x0A5C */ public int MaxResourceCrystalBlobSize;
        /* 0x0A60 */ public float BuildingBeamDistance;
        /* 0x0A64 */ public float WaypointScanTime;
        /* 0x0A68 */ public int RareSubstanceEffectiveness;
        /* 0x0A6C */ public int CommonProductEffectiveness;
        /* 0x0A70 */ public int RareProductEffectiveness;
        /* 0x0A74 */ public int AsteroidResourceReducer;
        /* 0x0A78 */ public float VoxelAsteroidResourceChance;
        /* 0x0A7C */ public int ResourceReducer;
        /* 0x0A80 */ public int ResourceMinAmount;
        /* 0x0A84 */ public int ResourceMaxAmount;
        /* 0x0A88 */ public int ResourceCommonReducer;
        /* 0x0A8C */ public int ResourceCommonMinAmount;
        /* 0x0A90 */ public int ResourceCommonMaxAmount;
        /* 0x0A94 */ public int ResourceDirtReducer;            // Do not set to 0
        /* 0x0A98 */ public int ResourceDirtMinAmount;
        /* 0x0A9C */ public int ResourceDirtMaxAmount;
        [NMS(Size = 0x10)]
        /* 0x0AA0 */ public string ResourceDirtSubstanceID;
        [NMS(Size = 0x10)]
        /* 0x0AB0 */ public string BioShipTerrainResource;        // "SUNGOLD" -> Liquid Sun substance
        [NMS(Size = 0x20)]
        /* 0x0AC0 */ public string RobotResource;
        [NMS(Size = 0x20)]
        /* 0x0AE0 */ public string DepotResource;
        /* 0x0B00 */ public float DockNodeBuyRadius;
        /* 0x0B04 */ public float BeaconInteractRange;
        /* 0x0B08 */ public float ShipInteractRadius;
        /* 0x0B0C */ public GcResourceCollectEffect AsteroidResourceCollect;
        /* 0x0B40 */ public float ScanAngleCutoff;
        /* 0x0B44 */ public GcScanData ToolScan;
        /* 0x0B58 */ public GcScanData ToolScanHardMode;
        /* 0x0B6C */ public GcScanData WaypointScan;
        /* 0x0B80 */ public GcScanData BeaconScan;
        /* 0x0B94 */ public GcScanData RadioTowerScan;
        /* 0x0BA8 */ public GcScanData ObservatoryScan;
        /* 0x0BBC */ public GcScanData DistressSignalScan;
        /* 0x0BD0 */ public GcScanData DebugScanPlanet;
        /* 0x0BE4 */ public GcScanData DebugScanSpace;
        /* 0x0BF8 */ public GcScanData ShipScan;
        /* 0x0C0C */ public GcScanData VisualScan;
        /* 0x0C20 */ public float ZoomFindBuildingRange;
        /* 0x0C24 */ public float TimeToDisplayScanResults;
        /* 0x0C28 */ public float HoverTimeToScan;
        /* 0x0C3C */ public float HoverTimeToScanCreatures;
        /* 0x0C30 */ public int HoverVisiblePointsNeeded;
        [NMS(Size = 0x4)]
        /* 0x0C34 */ public GcZoomData[] ZoomLevels;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x0CA4 */ public byte[] PaddingCA4;
		/* 0x0CB0 */ public GcScanEffectData PassiveScanEffect;
		/* 0x0D00 */ public GcScanEffectData BuildingScanEffect;
		/* 0x0D50 */ public GcScanEffectData TargetShipScanEffect;
		/* 0x0DA0 */ public GcScanEffectData HUDShipScanEffect;
		/* 0x0DF0 */ public GcScanEffectData CreatureScanEffect;
		/* 0x0E40 */ public GcScanEffectData ObjectsScanEffect;
		/* 0x0E90 */ public GcScanEffectData VRGhostScanEffect;
		/* 0x0EE0 */ public GcScanEffectData BaseBuildingValidScanEffect;
		/* 0x0F30 */ public GcScanEffectData BaseBuildingPreviewSelectionScanEffect;
		/* 0x0F80 */ public GcScanEffectData BaseBuildingSelectionScanEffect;
		/* 0x0FD0 */ public GcScanEffectData BaseBuildingDeleteScanEffect;
		/* 0x1020 */ public GcScanEffectData BaseBuildingGhostScanEffect;
		/* 0x1070 */ public GcScanEffectData BaseBuildingSpawnStaticEffect;
		/* 0x10C0 */ public GcScanEffectData BaseBuildingErrorInsideScanEffect;
		/* 0x1110 */ public GcScanEffectData BaseBuildingErrorCollisionScanEffect;
		/* 0x1160 */ public GcScanEffectData BaseBuildingErrorImpossibleScanEffect;
		/* 0x11B0 */ public GcScanEffectData BaseBuildingErrorUnaffordableScanEffect;
		/* 0x1200 */ public GcScanEffectData BaseBuildingErrorAboveWaterScanEffect;
		/* 0x1250 */ public GcScanEffectData BaseBuildingErrorBelowWaterScanEffect;
		/* 0x12A0 */ public GcScanEffectData BaseBuildingRemotePlayerValidScanEffect;
		/* 0x12F0 */ public GcScanEffectData BaseBuildingRemotePlayerSelectionScanEffect;
		/* 0x1340 */ public float BaseBuildingRemotePlayerErrorAlphaScanEffect;
        /* 0x1344 */ public bool UseDebugScan;
        /* 0x1345 */ public bool DebugScanForceBuilding;
        [NMS(Size = 0x02, Ignore = true)]
        /* 0x1346 */ public byte[] Padding1346;
        /* 0x1348 */ public GcBuildingClassification DebugScanForceBuildingType;
        /* 0x134C */ public float ShipScanOffset;
        /* 0x1350 */ public float ShipScanOffsetGap;
        /* 0x1354 */ public TkCurveType ShipScanCurve;
        /* 0x1358 */ public float ScannerMarkerFadeTime;
        /* 0x135C */ public float ScannerSmallMarkerFadeTime;
        /* 0x1360 */ public float ScannerPhysicsProbeAABBSize;
        /* 0x1364 */ public float ScannerAnalyzeFXRate;
        /* 0x1368 */ public float ScannerSubstanceTimePerTrigger;
        /* 0x136C */ public float ScannerTuningA;
        /* 0x1370 */ public float ScannerTuningB;
        /* 0x1374 */ public float ScannerTuningC;
        /* 0x1378 */ public float ScannerTuningD;
        /* 0x137C */ public float ScannerTuningResourceOffset1;
        /* 0x1380 */ public float ScannerTuningResourceOffset2;
        /* 0x1384 */ public float ScannerTuningSmoothStepAmount;
        /* 0x1388 */ public float ScannerTuningTrailingEdge;
        /* 0x138C */ public bool Autolevel;
        [NMS(Size = 0x03, Ignore = true)]
        /* 0x138D */ public byte[] Padding138D;
        /* 0x1390 */ public Colour ScannerColour1;
        /* 0x13A0 */ public Colour ScannerColour2;
        /* 0x13B0 */ public float HUDStoreFlashTime;
        /* 0x13B4 */ public float ExcitingViewAngle;
        /* 0x13B8 */ public float ExcitingViewRange;
        /* 0x13BC */ public float ExcitingNearRange;
        /* 0x13C0 */ public float ProjectileSpeedBoost;
        /* 0x13C4 */ public float LineWidth;
        /* 0x13C8 */ public float LockOffFactor;
        /* 0x13CC */ public float OffscreenFadeDistance;
        /* 0x13D0 */ public float OffscreenMinDot;
        /* 0x13D4 */ public bool HUDUpdateFromData;
        /* 0x13D8 */ public float HUDLockOnAudioTime;
        /* 0x13DC */ public float HUDArrowPrimaryScaler;
        /* 0x13E0 */ public Vector2f HUDDamageSize;
        /* 0x13E8 */ public Vector2f HUDDamageSplatSize;
        /* 0x13F0 */ public Colour HUDDamageSplatShieldColour;
        /* 0x1400 */ public Colour HUDDamageSplatPainColour;
        /* 0x1410 */ public float HUDDamageOffset;
        /* 0x1414 */ public float HUDDamageScaler;
        /* 0x1418 */ public float HUDDamageRadius;
        [NMS(Size = 0x04, Ignore = true)]
        /* 0x141C */ public byte[] Padding141C;
        /* 0x1420 */ public GcShipHUDTargetData HUDTarget;
        /* 0x1850 */ public float HUDLabelTime;
        /* 0x1854 */ public float HUDLabelAngle;
        /* 0x1858 */ public float HUDLabelAngleOffset;
        /* 0x185C */ public float HUDLabelOffsetX;
        /* 0x1860 */ public float HUDLabelOffsetY;
        /* 0x1864 */ public float HUDLabelOffsetZ;
        /* 0x1868 */ public float HUDLabelScale;
        /* 0x186C */ public float MaxSpawnTime;
        [NMS(Size = 0x80)]
        /* 0x1870 */ public string ResourceParticleFile;
        /* 0x18F0 */ public float ResourceParticleSpeed;
        /* 0x18F4 */ public float ResourceParticleSpread;
        /* 0x18F8 */ public int ResourceParticleMaxNum;
        /* 0x18FC */ public int ResourceParticleMinNum;
        /* 0x1900 */ public float MapHeight;
        /* 0x1904 */ public float MapOffset;
        /* 0x1908 */ public float MapTargetOffset;
        /* 0x190C */ public float MapFOV;
        /* 0x1910 */ public float MapRadius;
        /* 0x1914 */ public float HUDScaleAdd;
        /* 0x1918 */ public float HUDScaleRadius;
        /* 0x191C */ public float HUDScaleMin;
        /* 0x1920 */ public float HUDScaleMinAim;
        /* 0x1924 */ public float HUDScaleMax;
        /* 0x1928 */ public float HUDScaleFarTarget;
        /* 0x192C */ public float HUDReticuleMoveBack;
        /* 0x1930 */ public float HUDReticuleMoveAim;
        /* 0x1934 */ public float MouseSensitivity;
        /* 0x1938 */ public float MouseSensitivityShip;
        /* 0x193C */ public float MouseSensitivityVehicle;
        /* 0x1940 */ public float PainTime;
        /* 0x1944 */ public TkCurveType PainCurve;
        /* 0x1950 */ public Colour PainColour;
        /* 0x1960 */ public float GunOffsetX;
        /* 0x1964 */ public float GunOffsetY;
        /* 0x1968 */ public float GunOffsetZ;
        /* 0x196C */ public float GunDownAngle;
        /* 0x1970 */ public float GunUpAngle;
        /* 0x1974 */ public float BarrelOffset;
        /* 0x1978 */ public float HitOffset;
        /* 0x197C */ public GcTracerData BulletTracer;
        /* 0x1994 */ public GcTracerData ShipTracer;
         [NMS(Size = 0x04, Ignore = true)]
        /* 0x19AC */ public byte[] Padding19AC;
        [NMS(Size = 0x10)]
        /* 0x19B0 */ public string DefaultAnim;
        /* 0x19C0 */ public bool DebugDrawTriggerBoxes;
        /* 0x19C4 */ public float SpeedReadoutMultiplier;
        /* 0x19C8 */ public float SpaceSpeedReadoutMultiplier;
        /* 0x19CC */ public int TorchCookieIndex;
        /* 0x19D0 */ public float TorchFoV;
        /* 0x19D4 */ public float TorchStrength;
        /* 0x19D8 */ public int TorchDimCookieIndex;
        /* 0x19DC */ public float TorchDimFoV;
        /* 0x19E0 */ public float TorchDimStrength;
        /* 0x19E4 */ public float TorchOffsetX;
        /* 0x19E8 */ public float TorchOffsetY;
        /* 0x19EC */ public float TorchOffsetZ;
        /* 0x19F0 */ public float TorchHandOffsetX;
        /* 0x19F4 */ public float TorchHandOffsetY;
        /* 0x19F8 */ public float TorchHandOffsetZ;
        /* 0x19FC */ public bool TorchDisabledInTheDay;
        /* 0x1A00 */ public float TorchRotation;
        /* 0x1A04 */ public float TorchFollowCameraPitch;
        /* 0x1A08 */ public float TorchFollowCameraTime;
        /* 0x1A10 */ public Colour TorchColour;
        /* 0x1A20 */ public float PlayerAmbientSpotLightIntensity;
        /* 0x1A30 */ public Colour PlayerAmbientSpotLightColour;
        /* 0x1A40 */ public float PlayerAmbientSpotLightOffsetY;
        /* 0x1A44 */ public float PlayerAmbientSpotLightOffsetZ;
        /* 0x1A48 */ public float SimpleInteractionPickupAngle;
        /* 0x1A4C */ public float SimpleInteractionPickupRadius;
        /* 0x1A50 */ public float SimpleInteractionMessageTime;
        /* 0x1A54 */ public float InteractionPickupAngle;
        /* 0x1A58 */ public float InteractionPickupRadius;
        /* 0x1A5C */ public float ExplosionRadiusMultiplier;
        /* 0x1A60 */ public float ExplosionForce;
        /* 0x1A64 */ public float ExplosionForceMaxForceRadius;
        /* 0x1A68 */ public float LaserExplosionForceRadius;
        /* 0x1A6C */ public float LaserExplosionForce;
        /* 0x1A70 */ public float LaserExplosionForceMaxForceRadius;
        [NMS(Size = 0x80)]
        /* 0x1A74 */ public string InitialDebrisScene;
        /* 0x1AF4 */ public float BonusSameTypeElementsAdd;
        /* 0x1AF8 */ public float BonusSameTypeElementsMultiply;
        /* 0x1AFC */ public float BonusChildTypeElementsAdd;
        /* 0x1B00 */ public float BonusChildTypeElementsMultiply;
        /* 0x1B04 */ public float InteractionComponentUpdateDistance;
        /* 0x1B08 */ public float GoalGapVoxelDist;
        /* 0x1B0C */ public float BlackHoleJumpVoxelDist;
        /* 0x1B10 */ public float BlackHoleJumpVoxelVariation;
        /* 0x1B14 */ public float JumpToCenterFuelCost;
        /* 0x1B18 */ public int WarpsBetweenMiniStation;
        /* 0x1B1C */ public float HoursBetweenMiniStation;
        [NMS(Size = 0x80)]
        /* 0x1B20 */ public string LegacyBaseBuildingTable;
        [NMS(Size = 0x80)]
        /* 0x1BA0 */ public string BaseBuildingTable;
        /* 0x1C20 */ public ulong NPCWorkerInteractionCooldown;
        /* 0x1C28 */ public float LightStrength;
        /* 0x1C2C */ public float AirLockDoorRange;
        /* 0x1C30 */ public bool DisableBasePowerHUDOverlay;
        /* 0x1C31 */ public bool KeepAttackingMaxWantedLevel;
        /* 0x1C32 */ public bool UseMultiplierBonus;
        /* 0x1C34 */ public float ShipDisplayDamageMultiplier;
        /* 0x1C38 */ public bool UseTradingCostTable;
        /* 0x1C39 */ public bool ChangePricesLocally;
        /* 0x1C3A */ public bool ShowPriceMarkupsAsPercentages;
        /* 0x1C3C */ public int ProductItemStockDecayTime;
        /* 0x1C40 */ public int ProductItemStockReplenishTime;
        /* 0x1C44 */ public int SubstanceItemStockDecayTime;
        /* 0x1C48 */ public int SubstanceItemStockReplenishTime;
        /* 0x1C4C */ public GcPortalData Portal;
        /* 0x1C54 */ public int FourthRaceSpawnPercentage;
        /* 0x1C58 */ public int NonDominantRaceSpawnPercentage;
        /* 0x1C5C */ public float ViciousSentinelProbability;
        /* 0x1C60 */ public float ViciousStormProbability;
        /* 0x1C64 */ public float ViciousWeatherProbability;
        /* 0x1C68 */ public float ScrapDroneProbability;
        /* 0x1C6C */ public float MaxRespawnOnGroundHeight;
        /* 0x1C70 */ public float DeadPlanetGravityFactor;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x1C74 */ public byte[] Padding1C74;
        /* 0x1C80 */ public GcScanEffectData ShipSalvageScanEffect;
		/* 0x1CD0 */ public float SalvageShipPitch;
		/* 0x1CD4 */ public float SalvageShipHeightOffset;
		/* 0x1CD8 */ public float SalvageShipExplodeSpeed;
		/* 0x1CDC */ public float SalvageShipShowShipSpeed;
		/* 0x1CE0 */ public float SalvageShipShowShipDistance;
		/* 0x1CE4 */ public float SalvageShipExplodeShipDistance;
		/* 0x1CE8 */ public float SalvageShipOneRevolutionTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1CEC */ public byte[] Padding1CEC;
        [NMS(Size = 0x20)]
		/* 0x1CF0 */ public string CommunicatorFireteamNexusExitDialog;
        [NMS(Size = 0x20)]
		/* 0x1D10 */ public string CommunicatorNexusExitAbandonWarningDialog;
		/* 0x1D30 */ public float PulseEncounterCheckTimer;
		/* 0x1D34 */ public float PulseEncounterChance;
		/* 0x1D38 */ public float PulseEncounterChanceStandard;
		/* 0x1D3C */ public float PulseEncounterChanceRed;
		/* 0x1D40 */ public float PulseEncounterChanceGreen;
		/* 0x1D44 */ public float PulseEncounterChanceBlue;
		/* 0x1D48 */ public float PulseEncounterStopPower;
		/* 0x1D4C */ public float PulseEncounterStopSpeed;
        [NMS(Size = 0x4)]
        /* 0x1D50 */ public int[] AlienShipEvolveCosts;
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

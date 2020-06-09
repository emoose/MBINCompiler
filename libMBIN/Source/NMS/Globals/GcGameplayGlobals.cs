using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x1CE0, GUID = 0x54ACD3B81DA8ED08)]
    public class GcGameplayGlobals : NMSTemplate
    {
        /* 0x000 */ public float VehicleAllIconScanTime;
        /* 0x004 */ public int GPSRandomChangeTimeWide;
        /* 0x008 */ public int GPSRandomChangeTimeMid;
        /* 0x00C */ public int GPSRandomChangeTimeNarrow;
        /* 0x010 */ public float SalvageValueAsProds;
        /* 0x014 */ public int SalvageSubstanceValueThreshold;
        [NMS(Size = 0x4)]
        /* 0x018 */ public NMSString0x10[] SalvageRewardsShuttle;
        [NMS(Size = 0x4)]
        /* 0x058 */ public NMSString0x10[] SalvageRewardsDropship;
        [NMS(Size = 0x4)]
        /* 0x098 */ public NMSString0x10[] SalvageRewardsFighter;
        [NMS(Size = 0x4)]
        /* 0x0D8 */ public NMSString0x10[] SalvageRewardsScience;
        [NMS(Size = 0xA)]
        /* 0x118 */ public NMSString0x10[] SalvageTechList;
        [NMS(Size = 0xC)]
        /* 0x1B8 */ public NMSString0x10[] SalvageProdsList;
        [NMS(Size = 0x7)]
        /* 0x278 */ public NMSString0x10[] SalvageSubstancesList;
        /* 0x2E8 */ public bool AlwaysSpaceBattle;
        /* 0x2EC */ public float MultidimensionalFadeTime;
        /* 0x2F0 */ public float TeleporterDistanceTravelledMultiplier;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x2F4 */ public byte[] Padding2F4;
        /* 0x300 */ public GcScanEffectData BinocularSelectedEffect;
		/* 0x350 */ public Colour BinocularSelectedColour;
		/* 0x360 */ public Colour BinocularSelectedUnknownColour;
		/* 0x370 */ public float CockpitScale;
		/* 0x374 */ public float MaxDistanceForLadderTeleport;
		/* 0x378 */ public float AngleFromBaseComputerWhenTeleporting;
		/* 0x37C */ public float DistanceFromBaseComputerWhenTeleporting;
		/* 0x380 */ public float AutoTranslateWordChance;
		/* 0x384 */ public float SurveyBeginScanPercentage;
		/* 0x388 */ public float SurveyScanMinSpeed;
		/* 0x38C */ public float SurveyScanMaxSpeed;
		/* 0x390 */ public float SurveySonarPulseSpeedBandCount;
		/* 0x394 */ public float SurveySonarMinPulseSpeed;
		/* 0x398 */ public float SurveySonarMaxPulseSpeed;
		/* 0x39C */ public float SurveySonarMiddleRangeMin;
		/* 0x3A0 */ public float SurveySonarMiddleRangeMax;
		/* 0x3A4 */ public float SurveyMaxDistance;
		/* 0x3A8 */ public int CreaturesToBaitForTutorial;
		/* 0x3AC */ public int CreaturesToFeedForTutorial;
		/* 0x3B0 */ public bool DisableGalaxyMapInQuickMenu;
		/* 0x3B1 */ public bool DisableNexusInQuickMenu;
		/* 0x3B2 */ public bool EnableTeleporters;
		/* 0x3B3 */ public bool AllowSpaceScanEvents;
		/* 0x3B4 */ public bool CanMoveTechnology;
		/* 0x3B8 */ public float NormalModeHeatBonus;
		/* 0x3BC */ public float BaseLaserHeatTime;
		/* 0x3C0 */ public float HeatAlertTime;
		/* 0x3C4 */ public float HeatAlertTimeSurvival;
		/* 0x3C8 */ public float HeatDamageBoost;
		/* 0x3CC */ public float HeatWidthBoost;
		/* 0x3D0 */ public float HeatWidthBoostAlt;
		/* 0x3D4 */ public float OverheatGenerosity;
		/* 0x3D8 */ public float HeatMaxPowerPoint;
		/* 0x3DC */ public float HeatMaxPowerPointSurvival;
		/* 0x3E0 */ public float OverheatDecay;
		/* 0x3E4 */ public float OverheatDecaySurvival;
		/* 0x3E8 */ public TkCurveType OverheatCurve;
		/* 0x3EC */ public TkCurveType OverheatCurveSurvival;
		/* 0x3F0 */ public bool UseOverheatColour;
		/* 0x400 */ public Colour OverHeatColour;
		/* 0x410 */ public Colour OverHeatBarColour;
		/* 0x420 */ public Colour OverHeatColourSurvival;
		/* 0x430 */ public TkCurveType OverheatColourCurve;
		/* 0x434 */ public TkCurveType OverheatColourCurveSurvival;
		/* 0x438 */ public int RefinerProductsMadeInTime;
		/* 0x43C */ public int RefinerSubsMadeInTime;
		/* 0x440 */ public int RefinerProductsMadeInTimeSurvival;
		/* 0x444 */ public int RefinerSubsMadeInTimeSurvival;
        [NMS(Size = 0x3)]
        /* 0x0448 */ public NMSString0x10[] HyperdriveAccess;
        [NMS(Size = 0x3)]
        /* 0x0478 */ public NMSString0x10[] FreighterHyperdriveAccess;
        /* 0x04A8 */ public float HmdInteractionRangeMinRange;
        /* 0x04AC */ public float HmdInteractionRangeMinDistance;
        /* 0x04B0 */ public float HmdInteractionRangeMultiplier;
        /* 0x04B4 */ public bool InstallTechWithInteraction; // Set to False to revert to legacy method of installing technologies and upgrades
        /* 0x04B5 */ public bool FreighterRequiresRGBHyperdriveUpgrades;
        /* 0x04B6 */ public bool DisableAnomalyAmbientSpawn;
        /* 0x04B7 */ public bool AllowDeconstruct;
        /* 0x04B8 */ public bool AllowBinocularMarker;
        /* 0x04B9 */ public bool EveryMaintenanceIsBroken;
        /* 0x04BA */ public bool SpawnResourceBlobsOnPartDelete;
        /* 0x04BB */ public bool EnableShootHitEffect;
        /* 0x04BC */ public int MaxNumSameGroupTech;
        /* 0x04C0 */ public float ShootableArmourHighlightHitTime;
        /* 0x04C4 */ public float ShootableAggroMinStartTime;
        /* 0x04C8 */ public float ShootableAggroForgetTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x04CC */ public byte[] Padding4CC;
        /* 0x04D0 */ public Colour RefinerColour1A;
        /* 0x04E0 */ public Colour RefinerColour1B;
        /* 0x04F0 */ public Colour RefinerColour1C;
        /* 0x0500 */ public Colour RefinerColour1D;
        /* 0x0510 */ public float AtmosphereEntryTime;
        /* 0x0514 */ public float AtmosphereEntryFadeTimeFactor;
        /* 0x0518 */ public float AtmosphereEntryOffset;
        /* 0x051C */ public TkCurveType AtmosphereEntryCurve;
        /* 0x0520 */ public float TerrainResourceScanTime;
        /* 0x0524 */ public float TerrainResourceScanRange;
        /* 0x0528 */ public float TerrainResourceCompassRange;
        /* 0x052C */ public bool BinocsDisplayUnknownCreatures;
        /* 0x0530 */ public float BinocularScanTargetMinHeight;
        /* 0x0534 */ public float BinocularScanTargetHeightRange;
        /* 0x0538 */ public float BinocTimeBeforeScan;
        /* 0x053C */ public float BinocMinScanTime;
        /* 0x0540 */ public float BinocScanTime;
        /* 0x0544 */ public float BinocCreatureScanTime;
        /* 0x0548 */ public TkCurveType BinocularScanTargetHeightCurve;
        /* 0x054C */ public float BinocularScanTargetInitialFadeTime;
        /* 0x0550 */ public float BinocularScanTargetScaler;
        /* 0x0554 */ public float BinocularScanTargetLineWidth;
        /* 0x0558 */ public float BinocularScanTargetFadeTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x055C */ public byte[] Padding268;
        /* 0x0560 */ public Colour BinocularScanTargetColour;
        /* 0x0570 */ public GcScanEffectData BinocularScanEffect;
        /* 0x05C0 */ public float ScannerIconsClumpRadius;
        /* 0x05C4 */ public float ScannableComponentMarkerOffset;
        /* 0x05C8 */ public float ScannableComponentPlaceMarkerOffset;
        /* 0x05CC */ public float MissionEventAllowResetDistance;
        /* 0x05D0 */ public float AllRecipesKnownNanitesMin;
        /* 0x05D4 */ public float AllRecipesKnownNanitesMax;
        /* 0x05D8 */ public float MaxPossibleShipDamagePotential;
        /* 0x05DC */ public float BuildingPlayerBaseIconOffset;
        /* 0x05E0 */ public float CriticalHitMultiplier;
        /* 0x05E4 */ public float HitEffectMinTime;
        /* 0x05E8 */ public float GrabPlayerCooldownTime;
        /* 0x05EC */ public float TapInteractionIncreaseAmount;
        /* 0x05F0 */ public float TapInteractionDecay;
        [NMS(Size = 0x0C, Ignore = true)]
        /* 0x05F4 */ public byte[] Padding5F4;
        /* 0x0600 */ public GcScanEffectData DeconstructEffect;
        /* 0x0650 */ public GcScanEffectData HitEffect;
        /* 0x06A0 */ public GcScanEffectData HitEffectCritical;
        /* 0x06F0 */ public float CommunicatorSpawnOffset;
        /* 0x06F4 */ public float CommunicatorSpawnHeightOffset;
        [NMS(Size = 0x08, Ignore = true)]
        /* 0x06F8 */ public byte[] Padding6F8;
        /* 0x0700 */ public Vector4f CommunicatorShipSpawnOffset;
        /* 0x0710 */ public float CommunicatorSpawnScale;
        /* 0x0714 */ public float CommunicatorSpawnRotation;
        /* 0x0718 */ public float CommunicatorFadeTime;
        [NMS(Size = 0x04, Ignore = true)]
        /* 0x071C */ public byte[] Padding71C;
        [NMS(Size = 0x02)]
        /* 0x0720 */ public GcScanEffectData[] CommunicatorEffectTable;
        /* 0x07C0 */ public int MaxNumMissionsFromMissionGiver;
        /* 0x07C4 */ public float InteractionMessageModuleDisplayTime;
        /* 0x07C8 */ public float InteractionAttractTime;
        /* 0x07CC */ public float InteractionDescriptionTextTime;
        /* 0x07D0 */ public float InteractionMinTimeForResponseText;
        /* 0x07D4 */ public bool InteractionOverride;
        [NMS(Size = 0x03, Ignore = true)]
        /* 0x07D5 */ public byte[] Padding7D5;
        /* 0x07D8 */ public GcInteractionType InteractionOverrideFrom;
        /* 0x07DC */ public GcInteractionType InteractionOverrideTo;
        /* 0x07E0 */ public float DestroyEffectHeight;
        /* 0x07E4 */ public float DestroyEffectMaxScale;
        /* 0x07E8 */ public float EventTargetSpeed;
        /* 0x07EC */ public int SpecialMiningAmount;
        /* 0x07F0 */ public float SpecialMiningTime;
        /* 0x07F4 */ public int HardModeTechDamageMidNum;
        /* 0x07F8 */ public int HardModeTechDamageMidPercent;
        /* 0x07FC */ public int HardModeTechDamageHighPercent;
        /* 0x0800 */ public int EarlyPiratesToBeKilled;
        /* 0x0804 */ public int PirateInterestOverride;
        /* 0x0808 */ public float PirateInterestDistance;
        [NMS(Size = 0x3)]
        /* 0x080C */ public int[] PirateInterestLevels;
        [NMS(Size = 0x3)]
        /* 0x0818 */ public int[] PirateInterestLevelsSurvival;
        /* 0x0824 */ public float SpaceCombatRadius;
        /* 0x0828 */ public int WarpsBetweenBattles;
        /* 0x082C */ public float HoursBetweenBattles;
        /* 0x0830 */ public float SpaceBattleRadius;
        /* 0x0834 */ public float SpaceBattleAnyHostileShipsRadius;
        /* 0x0838 */ public float FreighterBattleRadius;
        /* 0x083C */ public float MissileMaxTurnAngle;
        /* 0x0840 */ public float MissileLockTime;
        /* 0x0844 */ public float MissileReloadTime;
        /* 0x0848 */ public float MissileRotateMin;
        /* 0x084C */ public float MissileRotateMax;
        /* 0x0850 */ public float MissileMaxSpeed;
        /* 0x0854 */ public float MissileForceMin;
        /* 0x0858 */ public float MissileForceMax;
        /* 0x085C */ public float MissileBrakeForceMin;
        /* 0x0860 */ public float MissileBrakeForceMax;
        /* 0x0864 */ public float MissileThreatTime;
        /* 0x0868 */ public float MissileBrakeTime;
        /* 0x086C */ public float MissileHitRadius;
        /* 0x0870 */ public float MissileOffset;
        /* 0x0874 */ public float MissileMinCircleTime;
        /* 0x0878 */ public float MissileApproachTime;
        /* 0x087C */ public float MissileRotateSpeed;
        /* 0x0880 */ public float ScanStartTimeDelayMinDist;
        /* 0x0884 */ public float ScanStartTimeDelayRange;
        /* 0x0888 */ public float ScanStartTimeDistanceDelayTime;
        /* 0x088C */ public float ScanStickyDecay;
        /* 0x0890 */ public float CreatureScanStickyDecay;
        /* 0x0894 */ public float CreatureScanAngle;
        /* 0x0898 */ public float CreatureMinScanTime;
        /* 0x089C */ public float ScanAngle;
        /* 0x08A0 */ public float NewDiscoveryDisplayTime;
        /* 0x08A4 */ public bool FailToFindBuildings;
        /* 0x08A8 */ public int CritDamage;
        /* 0x08AC */ public float CritScale;
        /* 0x08B0 */ public int NumMissionsPerSolarSystem;
        /* 0x08B4 */ public float EmergencyBuildingScanEventDistance;
        /* 0x08B8 */ public float EmergencyBuildingScanEventTime;
        /* 0x08BC */ public float ProjectileLightIntensity;
        /* 0x08C0 */ public float AggressiveSentinelProbability;
        /* 0x08C4 */ public float AggressiveSentinelProbabilitySurvival;
        /* 0x08C8 */ public float LowSentinelProbability;
        /* 0x08CC */ public float LowSentinelProbabilitySurvival;
        /* 0x08D0 */ public float NonAggressiveLushSurvivalProbabability;
        /* 0x08D4 */ public int MaxDronesLow;
        /* 0x08D8 */ public int MaxDronesLowSurvival;
        /* 0x08DC */ public int MaxDronesNormal;
        /* 0x08E0 */ public int MaxDronesNormalSurvival;
        /* 0x08E4 */ public int MaxDronesAggressive;
        /* 0x08E8 */ public int MaxDronesAggressiveSurvival;
        /* 0x08EC */ public GcExperienceTimers SentinelTimersLow;
        /* 0x090C */ public GcExperienceTimers SentinelTimersNormal;
        /* 0x092C */ public GcExperienceTimers SentinelTimersSurvival;
        /* 0x094C */ public int FreighterStartPecent;
        /* 0x0950 */ public GcExperienceTimers FreighterTimers;
        /* 0x0970 */ public GcExperienceTimers PirateTimers;
        /* 0x0990 */ public GcExperienceTimers HardPirateTimers;
        [NMS(Size = 0x3)]
        /* 0x09B0 */ public float[] PirateEarlySpawnChances;
        /* 0x09BC */ public float PirateEarlySpawnTime;
        /* 0x09C0 */ public GcExperienceTimers FlybyTimers;
        /* 0x09E0 */ public GcExperienceTimers SpaceFlybyTimers;
        /* 0x0A00 */ public int SentinelsHigh;
        /* 0x0A04 */ public int SentinelsLow;
        /* 0x0A08 */ public float AsteroidHitForce;
        /* 0x0A0C */ public float AsteroidTorqueForce;
        /* 0x0A10 */ public float AsteroidCarveRadius;
        /* 0x0A14 */ public int DeathMoneyPenalty;
        /* 0x0A18 */ public int DeathMoneyPenaltyHardMode;
        /* 0x0A1C */ public int MaxResourceCrystalBlobSize;
        /* 0x0A20 */ public float BuildingBeamDistance;
        /* 0x0A24 */ public float WaypointScanTime;
        /* 0x0A28 */ public int RareSubstanceEffectiveness;
        /* 0x0A2C */ public int CommonProductEffectiveness;
        /* 0x0A30 */ public int RareProductEffectiveness;
        /* 0x0A34 */ public int AsteroidResourceReducer;
        /* 0x0A38 */ public float VoxelAsteroidResourceChance;
        /* 0x0A3C */ public int ResourceReducer;
        /* 0x0A40 */ public int ResourceMinAmount;
        /* 0x0A44 */ public int ResourceMaxAmount;
        /* 0x0A48 */ public int ResourceCommonReducer;
        /* 0x0A4C */ public int ResourceCommonMinAmount;
        /* 0x0A50 */ public int ResourceCommonMaxAmount;
        /* 0x0A54 */ public int ResourceDirtReducer;            // Do not set to 0
        /* 0x0A58 */ public int ResourceDirtMinAmount;
        /* 0x0A5C */ public int ResourceDirtMaxAmount;
        [NMS(Size = 0x10)]
        /* 0x0A60 */ public string ResourceDirtSubstanceID;
        [NMS(Size = 0x10)]
        /* 0x0A70 */ public string BioShipTerrainResource;        // "SUNGOLD" -> Liquid Sun substance
        [NMS(Size = 0x20)]
        /* 0x0A80 */ public string RobotResource;
        [NMS(Size = 0x20)]
        /* 0x0AA0 */ public string DepotResource;
        /* 0x0AC0 */ public float DockNodeBuyRadius;
        /* 0x0AC4 */ public float BeaconInteractRange;
        /* 0x0AC8 */ public float ShipInteractRadius;
        /* 0x0ACC */ public GcResourceCollectEffect AsteroidResourceCollect;
        /* 0x0B00 */ public float ScanAngleCutoff;
        /* 0x0B04 */ public GcScanData ToolScan;
        /* 0x0B18 */ public GcScanData ToolScanHardMode;
        /* 0x0B2C */ public GcScanData WaypointScan;
        /* 0x0B40 */ public GcScanData BeaconScan;
        /* 0x0B54 */ public GcScanData RadioTowerScan;
        /* 0x0B68 */ public GcScanData ObservatoryScan;
        /* 0x0B7C */ public GcScanData DistressSignalScan;
        /* 0x0B90 */ public GcScanData DebugScanPlanet;
        /* 0x0BA4 */ public GcScanData DebugScanSpace;
        /* 0x0BB8 */ public GcScanData ShipScan;
        /* 0x0BCC */ public GcScanData VisualScan;
        /* 0x0BE0 */ public float ZoomFindBuildingRange;
        /* 0x0BE4 */ public float TimeToDisplayScanResults;
        /* 0x0BE8 */ public float HoverTimeToScan;
        /* 0x0BFC */ public float HoverTimeToScanCreatures;
        /* 0x0BF0 */ public int HoverVisiblePointsNeeded;
        [NMS(Size = 0x4)]
        /* 0x0BF4 */ public GcZoomData[] ZoomLevels;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x0C64 */ public byte[] PaddingC64;
		/* 0x0C70 */ public GcScanEffectData PassiveScanEffect;
		/* 0x0CC0 */ public GcScanEffectData BuildingScanEffect;
		/* 0x0D10 */ public GcScanEffectData TargetShipScanEffect;
		/* 0x0D60 */ public GcScanEffectData HUDShipScanEffect;
		/* 0x0DB0 */ public GcScanEffectData CreatureScanEffect;
		/* 0x0E00 */ public GcScanEffectData ObjectsScanEffect;
		/* 0x0E50 */ public GcScanEffectData VRGhostScanEffect;
		/* 0x0EA0 */ public GcScanEffectData BaseBuildingValidScanEffect;
		/* 0x0EF0 */ public GcScanEffectData BaseBuildingPreviewSelectionScanEffect;
		/* 0x0F40 */ public GcScanEffectData BaseBuildingSelectionScanEffect;
		/* 0x0F90 */ public GcScanEffectData BaseBuildingDeleteScanEffect;
		/* 0x0FE0 */ public GcScanEffectData BaseBuildingGhostScanEffect;
		/* 0x1030 */ public GcScanEffectData BaseBuildingSpawnStaticEffect;
		/* 0x1080 */ public GcScanEffectData BaseBuildingErrorInsideScanEffect;
		/* 0x10D0 */ public GcScanEffectData BaseBuildingErrorCollisionScanEffect;
		/* 0x1120 */ public GcScanEffectData BaseBuildingErrorImpossibleScanEffect;
		/* 0x1170 */ public GcScanEffectData BaseBuildingErrorUnaffordableScanEffect;
		/* 0x11C0 */ public GcScanEffectData BaseBuildingErrorAboveWaterScanEffect;
		/* 0x1210 */ public GcScanEffectData BaseBuildingErrorBelowWaterScanEffect;
		/* 0x1260 */ public GcScanEffectData BaseBuildingRemotePlayerValidScanEffect;
		/* 0x12B0 */ public GcScanEffectData BaseBuildingRemotePlayerSelectionScanEffect;
		/* 0x1300 */ public float BaseBuildingRemotePlayerErrorAlphaScanEffect;
        /* 0x1304 */ public bool UseDebugScan;
        /* 0x1305 */ public bool DebugScanForceBuilding;
        [NMS(Size = 0x02, Ignore = true)]
        /* 0x1306 */ public byte[] Padding1306;
        /* 0x1308 */ public GcBuildingClassification DebugScanForceBuildingType;
        /* 0x130C */ public float ShipScanOffset;
        /* 0x1310 */ public float ShipScanOffsetGap;
        /* 0x1314 */ public TkCurveType ShipScanCurve;
        /* 0x1318 */ public float ScannerMarkerFadeTime;
        /* 0x131C */ public float ScannerSmallMarkerFadeTime;
        /* 0x1320 */ public float ScannerPhysicsProbeAABBSize;
        /* 0x1324 */ public float ScannerAnalyzeFXRate;
        /* 0x1328 */ public float ScannerSubstanceTimePerTrigger;
        /* 0x132C */ public float ScannerTuningA;
        /* 0x1330 */ public float ScannerTuningB;
        /* 0x1334 */ public float ScannerTuningC;
        /* 0x1338 */ public float ScannerTuningD;
        /* 0x133C */ public float ScannerTuningResourceOffset1;
        /* 0x1340 */ public float ScannerTuningResourceOffset2;
        /* 0x1344 */ public float ScannerTuningSmoothStepAmount;
        /* 0x1348 */ public float ScannerTuningTrailingEdge;
        /* 0x134C */ public bool Autolevel;
        [NMS(Size = 0x03, Ignore = true)]
        /* 0x134D */ public byte[] Padding134D;
        /* 0x1350 */ public Colour ScannerColour1;
        /* 0x1360 */ public Colour ScannerColour2;
        /* 0x1370 */ public float HUDStoreFlashTime;
        /* 0x1374 */ public float ExcitingViewAngle;
        /* 0x1378 */ public float ExcitingViewRange;
        /* 0x137C */ public float ExcitingNearRange;
        /* 0x1380 */ public float ProjectileSpeedBoost;
        /* 0x1384 */ public float LineWidth;
        /* 0x1388 */ public float LockOffFactor;
        /* 0x138C */ public float OffscreenFadeDistance;
        /* 0x1390 */ public float OffscreenMinDot;
        /* 0x1394 */ public bool HUDUpdateFromData;
        /* 0x1398 */ public float HUDLockOnAudioTime;
        /* 0x139C */ public float HUDArrowPrimaryScaler;
        /* 0x13A0 */ public Vector2f HUDDamageSize;
        /* 0x13A8 */ public Vector2f HUDDamageSplatSize;
        /* 0x13B0 */ public Colour HUDDamageSplatShieldColour;
        /* 0x13C0 */ public Colour HUDDamageSplatPainColour;
        /* 0x13D0 */ public float HUDDamageOffset;
        /* 0x13D4 */ public float HUDDamageScaler;
        /* 0x13D8 */ public float HUDDamageRadius;
        [NMS(Size = 0x04, Ignore = true)]
        /* 0x13DC */ public byte[] Padding13DC;
        /* 0x13E0 */ public GcShipHUDTargetData HUDTarget;
        /* 0x1810 */ public float HUDLabelTime;
        /* 0x1814 */ public float HUDLabelAngle;
        /* 0x1818 */ public float HUDLabelAngleOffset;
        /* 0x181C */ public float HUDLabelOffsetX;
        /* 0x1820 */ public float HUDLabelOffsetY;
        /* 0x1824 */ public float HUDLabelOffsetZ;
        /* 0x1828 */ public float HUDLabelScale;
        /* 0x182C */ public float MaxSpawnTime;
        [NMS(Size = 0x80)]
        /* 0x1830 */ public string ResourceParticleFile;
        /* 0x18B0 */ public float ResourceParticleSpeed;
        /* 0x18B4 */ public float ResourceParticleSpread;
        /* 0x18B8 */ public int ResourceParticleMaxNum;
        /* 0x18BC */ public int ResourceParticleMinNum;
        /* 0x18C0 */ public float MapHeight;
        /* 0x18C4 */ public float MapOffset;
        /* 0x18C8 */ public float MapTargetOffset;
        /* 0x18CC */ public float MapFOV;
        /* 0x18D0 */ public float MapRadius;
        /* 0x18D4 */ public float HUDScaleAdd;
        /* 0x18D8 */ public float HUDScaleRadius;
        /* 0x18DC */ public float HUDScaleMin;
        /* 0x18E0 */ public float HUDScaleMinAim;
        /* 0x18E4 */ public float HUDScaleMax;
        /* 0x18E8 */ public float HUDScaleFarTarget;
        /* 0x18EC */ public float HUDReticuleMoveBack;
        /* 0x18F0 */ public float HUDReticuleMoveAim;
        /* 0x18F4 */ public float MouseSensitivity;
        /* 0x18F8 */ public float MouseSensitivityShip;
        /* 0x18FC */ public float MouseSensitivityVehicle;
        /* 0x1900 */ public float PainTime;
        /* 0x1904 */ public TkCurveType PainCurve;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x1908 */ public byte[] Padding18E4;
        /* 0x1910 */ public Colour PainColour;
        /* 0x1920 */ public float GunOffsetX;
        /* 0x1924 */ public float GunOffsetY;
        /* 0x1928 */ public float GunOffsetZ;
        /* 0x192C */ public float GunDownAngle;
        /* 0x1930 */ public float GunUpAngle;
        /* 0x1934 */ public float BarrelOffset;
        /* 0x1938 */ public float HitOffset;
        /* 0x193C */ public GcTracerData BulletTracer;
        /* 0x1954 */ public GcTracerData ShipTracer;
         [NMS(Size = 0x04, Ignore = true)]
        /* 0x196C */ public byte[] Padding196C;
        [NMS(Size = 0x10)]
        /* 0x1970 */ public string DefaultAnim;
        /* 0x1980 */ public bool DebugDrawTriggerBoxes;
        /* 0x1984 */ public float SpeedReadoutMultiplier;
        /* 0x1988 */ public float SpaceSpeedReadoutMultiplier;
        /* 0x198C */ public float TorchFoV;
        /* 0x1990 */ public float TorchStrength;
        /* 0x1994 */ public float TorchOffsetX;
        /* 0x1998 */ public float TorchOffsetY;
        /* 0x199C */ public float TorchOffsetZ;
        /* 0x19A0 */ public float TorchHandOffsetX;
        /* 0x19A4 */ public float TorchHandOffsetY;
        /* 0x19A8 */ public float TorchHandOffsetZ;
        /* 0x19AC */ public bool TorchDisabledInTheDay;
        /* 0x19B0 */ public float TorchRotation;
        /* 0x19C0 */ public Colour TorchColour;
        /* 0x19D0 */ public float SimpleInteractionPickupAngle;
        /* 0x19D4 */ public float SimpleInteractionPickupRadius;
        /* 0x19D8 */ public float SimpleInteractionMessageTime;
        /* 0x19DC */ public float InteractionPickupAngle;
        /* 0x19E0 */ public float InteractionPickupRadius;
        /* 0x19E4 */ public float ExplosionRadiusMultiplier;
        /* 0x19E8 */ public float ExplosionForce;
        /* 0x19EC */ public float ExplosionForceMaxForceRadius;
        /* 0x19F0 */ public float LaserExplosionForceRadius;
        /* 0x19F4 */ public float LaserExplosionForce;
        /* 0x19F8 */ public float LaserExplosionForceMaxForceRadius;
        [NMS(Size = 0x80)]
        /* 0x19FC */ public string InitialDebrisScene;
        /* 0x1A7C */ public float BonusSameTypeElementsAdd;
        /* 0x1A80 */ public float BonusSameTypeElementsMultiply;
        /* 0x1A84 */ public float BonusChildTypeElementsAdd;
        /* 0x1A88 */ public float BonusChildTypeElementsMultiply;
        /* 0x1A8C */ public float InteractionComponentUpdateDistance;
        /* 0x1A90 */ public float GoalGapVoxelDist;
        /* 0x1A94 */ public float BlackHoleJumpVoxelDist;
        /* 0x1A98 */ public float BlackHoleJumpVoxelVariation;
        /* 0x1A9C */ public float JumpToCenterFuelCost;
        /* 0x1AA0 */ public int WarpsBetweenMiniStation;
        /* 0x1AA4 */ public float HoursBetweenMiniStation;
        [NMS(Size = 0x80)]
        /* 0x1AA8 */ public string LegacyBaseBuildingTable;
        [NMS(Size = 0x80)]
        /* 0x1B28 */ public string BaseBuildingTable;
        /* 0x1BA8 */ public ulong NPCWorkerInteractionCooldown;
        /* 0x1BB0 */ public float LightStrength;
        /* 0x1BB4 */ public float AirLockDoorRange;
        /* 0x1BB8 */ public bool DisableBasePowerHUDOverlay;
        /* 0x1BB9 */ public bool KeepAttackingMaxWantedLevel;
        /* 0x1BBA */ public bool UseMultiplierBonus;
        /* 0x1BBC */ public float ShipDisplayDamageMultiplier;
        /* 0x1BC0 */ public bool UseTradingCostTable;
        /* 0x1BC1 */ public bool ChangePricesLocally;
        /* 0x1BC2 */ public bool ShowPriceMarkupsAsPercentages;
        /* 0x1BC4 */ public int ProductItemStockDecayTime;
        /* 0x1BC8 */ public int ProductItemStockReplenishTime;
        /* 0x1BCC */ public int SubstanceItemStockDecayTime;
        /* 0x1BD0 */ public int SubstanceItemStockReplenishTime;
        /* 0x1BD4 */ public GcPortalData Portal;
        /* 0x1BDC */ public int FourthRaceSpawnPercentage;
        /* 0x1BE0 */ public int NonDominantRaceSpawnPercentage;
        /* 0x1BE4 */ public float ViciousSentinelProbability;
        /* 0x1BE8 */ public float ViciousStormProbability;
        /* 0x1BEC */ public float ViciousWeatherProbability;
        /* 0x1BF0 */ public float ScrapDroneProbability;
        /* 0x1BF4 */ public float MaxRespawnOnGroundHeight;
        /* 0x1BF8 */ public float DeadPlanetGravityFactor;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1BFC */ public byte[] Padding1BFC;
        /* 0x1C00 */ public GcScanEffectData ShipSalvageScanEffect;
		/* 0x1C50 */ public float SalvageShipPitch;
		/* 0x1C54 */ public float SalvageShipHeightOffset;
		/* 0x1C58 */ public float SalvageShipExplodeSpeed;
		/* 0x1C5C */ public float SalvageShipShowShipSpeed;
		/* 0x1C60 */ public float SalvageShipShowShipDistance;
		/* 0x1C64 */ public float SalvageShipExplodeShipDistance;
		/* 0x1C68 */ public float SalvageShipOneRevolutionTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1C6C */ public byte[] Padding1C6C;
        [NMS(Size = 0x20)]
		/* 0x1C70 */ public string CommunicatorFireteamNexusExitDialog;
        [NMS(Size = 0x20)]
		/* 0x1C90 */ public string CommunicatorNexusExitAbandonWarningDialog;
		/* 0x1CB0 */ public float PulseEncounterCheckTimer;
		/* 0x1CB4 */ public float PulseEncounterChance;
		/* 0x1CB8 */ public float PulseEncounterChanceStandard;
		/* 0x1CBC */ public float PulseEncounterChanceRed;
		/* 0x1CC0 */ public float PulseEncounterChanceGreen;
		/* 0x1CC4 */ public float PulseEncounterChanceBlue;
		/* 0x1CC8 */ public float PulseEncounterStopPower;
		/* 0x1CCC */ public float PulseEncounterStopSpeed;
        [NMS(Size = 0x4)]
        /* 0x1CD0 */ public int[] AlienShipEvolveCosts;
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

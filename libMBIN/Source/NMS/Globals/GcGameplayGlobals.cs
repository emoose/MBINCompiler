using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x282EED977E323564)]
    public class GcGameplayGlobals : NMSTemplate
    {
        [NMS(Size = 0x3)]
        /* 0x0 */ public NMSString0x10[] HyperdriveAccess;
        [NMS(Size = 0x3)]
        /* 0x30 */ public NMSString0x10[] FreighterHyperdriveAccess;
        /* 0x60 */ public bool FreighterRequiresRGBHyperdriveUpgrades;
		/* 0x61 */ public bool AllowTeleportItemsToFreighter;
		/* 0x62 */ public bool DisableAnomalyAmbientSpawn;
		/* 0x63 */ public bool AllowDeconstruct;
		/* 0x64 */ public bool AllowBinocularMarker;
		/* 0x65 */ public bool EveryMaintenanceIsBroken;
		/* 0x66 */ public bool SpawnResourceBlobsOnPartDelete;
		/* 0x67 */ public bool EnableShootHitEffect;
		/* 0x68 */ public int MaxNumSameGroupTech;
		/* 0x6C */ public float ShootableAggroMinStartTime;
		/* 0x70 */ public float ShootableAggroForgetTime;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x74 */ public byte[] Padding74;
        /* 0x80 */ public Colour RefinerColour1A;
        /* 0x90 */ public Colour RefinerColour1B;
        /* 0xA0 */ public Colour RefinerColour1C;
        /* 0xB0 */ public Colour RefinerColour1D;
        /* 0xC0 */ public float AtmosphereEntryTime;
        /* 0xC4 */ public float AtmosphereEntryFadeTimeFactor;
        /* 0xC8 */ public float AtmosphereEntryOffset;
        /* 0xCC */ public TkCurveType AtmosphereEntryCurve;
        /* 0xD0 */ public float TerrainResourceScanTime;
        /* 0xD4 */ public float TerrainResourceScanRange;
        /* 0xD8 */ public bool BinocsDisplayUnknownCreatures;
        /* 0xDC */ public float BinocularScanTargetMinHeight;
        /* 0xE0 */ public float BinocularScanTargetHeightRange;
        /* 0xE4 */ public float BinocTimeBeforeScan;
        /* 0xE8 */ public float BinocMinScanTime;
        /* 0xEC */ public float BinocScanTime;
        /* 0xF0 */ public float BinocCreatureScanTime;
        /* 0xF4 */ public TkCurveType BinocularScanTargetHeightCurve;
        /* 0xF8 */ public float BinocularScanTargetInitialFadeTime;
        /* 0xFC */ public float BinocularScanTargetScaler;
        /* 0x100 */ public float BinocularScanTargetLineWidth;
        /* 0x104 */ public float BinocularScanTargetFadeTime;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x108 */ public byte[] Padding108;
        /* 0x110 */ public Colour BinocularScanTargetColour;
        /* 0x120 */ public GcScanEffectData BinocularScanEffect;
        /* 0x170 */ public float ScannerIconsClumpRadius;
        /* 0x174 */ public float ScannableComponentMarkerOffset;
        /* 0x178 */ public float ScannableComponentPlaceMarkerOffset;
        /* 0x17C */ public float MissionEventAllowResetDistance;
        /* 0x180 */ public float AllRecipesKnownNanitesMin;
        /* 0x184 */ public float AllRecipesKnownNanitesMax;
        /* 0x188 */ public float MaxPossibleShipDamagePotential;
        /* 0x18C */ public float BuildingPlayerBaseIconOffset;
        /* 0x190 */ public float CriticalHitMultiplier;
        /* 0x194 */ public float HitEffectMinTime;
		/* 0x198 */ public float GrabPlayerCooldownTime;
		/* 0x19C */ public float TapInteractionIncreaseAmount;
		/* 0x1A0 */ public float TapInteractionDecay;
        /* 0x1B0 */ public GcScanEffectData DeconstructEffect;
        /* 0x200 */ public GcScanEffectData HitEffect;
        /* 0x250 */ public GcScanEffectData HitEffectCritical;
        /* 0x2A0 */ public float CommunicatorSpawnOffset;
        /* 0x2A4 */ public float CommunicatorSpawnHeightOffset;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x2A8 */ public byte[] Padding2A8;
        /* 0x2B0 */ public Vector4f CommunicatorShipSpawnOffset;
        /* 0x2C0 */ public float CommunicatorSpawnScale;
        /* 0x2C4 */ public float CommunicatorSpawnRotation;
        /* 0x2C8 */ public float CommunicatorFadeTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2CC */ public byte[] Padding2CC;
        [NMS(Size = 0x2)]
        /* 0x2D0 */ public GcScanEffectData[] CommunicatorEffectTable;
        /* 0x370 */ public int MaxNumMissionsFromMissionGiver;
        /* 0x374 */ public float InteractionMessageModuleDisplayTime;
        /* 0x378 */ public float InteractionAttractTime;
        /* 0x37C */ public float InteractionDescriptionTextTime;
        /* 0x380 */ public float InteractionMinTimeForResponseText;
        /* 0x384 */ public bool InteractionOverride;
        /* 0x388 */ public int InteractionOverrideFrom;     // GcInteractionType ?
        /* 0x38C */ public int InteractionOverrideTo;       // GcInteractionType ?
        /* 0x390 */ public float DestroyEffectHeight;
        /* 0x394 */ public float DestroyEffectMaxScale;
        /* 0x398 */ public float EventTargetSpeed;
        /* 0x39C */ public int SpecialMiningAmount;
        /* 0x3A0 */ public float SpecialMiningTime;
        /* 0x3A4 */ public int HardModeTechDamageMidNum;
        /* 0x3A8 */ public int HardModeTechDamageMidPercent;
        /* 0x3AC */ public int HardModeTechDamageHighPercent;
        /* 0x3B0 */ public float PirateInterestOverride;
        /* 0x3B4 */ public float PirateInterestDistance;
        [NMS(Size = 0x3)]
        /* 0x3B8 */ public int[] PirateInterestLevels;
        /* 0x3C4 */ public float SpaceCombatRadius;
        /* 0x3C8 */ public int WarpsBetweenBattles;
        /* 0x3CC */ public float HoursBetweenBattles;
        /* 0x3D0 */ public float SpaceBattleRadius;
        /* 0x3D4 */ public float SpaceBattleAnyHostileShipsRadius;
        /* 0x3D8 */ public float FreighterBattleRadius;
        /* 0x3DC */ public float MissileMaxTurnAngle;
        /* 0x3E0 */ public float MissileLockTime;
        /* 0x3E4 */ public float MissileReloadTime;
        /* 0x3E8 */ public float MissileRotateMin;
        /* 0x3EC */ public float MissileRotateMax;
        /* 0x3F0 */ public float MissileMaxSpeed;
        /* 0x3F4 */ public float MissileForceMin;
        /* 0x3F8 */ public float MissileForceMax;
        /* 0x3FC */ public float MissileBrakeForceMin;
        /* 0x400 */ public float MissileBrakeForceMax;
        /* 0x404 */ public float MissileThreatTime;
        /* 0x408 */ public float MissileBrakeTime;
        /* 0x40C */ public float MissileHitRadius;
        /* 0x410 */ public float MissileOffset;
        /* 0x414 */ public float MissileMinCircleTime;
        /* 0x418 */ public float MissileApproachTime;
        /* 0x41C */ public float MissileRotateSpeed;
        /* 0x420 */ public float ScanStartTimeDelayMinDist;
        /* 0x424 */ public float ScanStartTimeDelayRange;
        /* 0x428 */ public float ScanStartTimeDistanceDelayTime;
        /* 0x42C */ public float ScanStickyDecay;
        /* 0x430 */ public float CreatureScanStickyDecay;
        /* 0x434 */ public float CreatureScanAngle;
        /* 0x438 */ public float CreatureMinScanTime;
        /* 0x43C */ public float ScanAngle;
        /* 0x440 */ public float NewDiscoveryDisplayTime;
        /* 0x444 */ public bool FailToFindBuildings;
        /* 0x448 */ public int CritDamage;
        /* 0x44C */ public float CritScale;
        /* 0x450 */ public int NumMissionsPerSolarSystem;
        /* 0x454 */ public float EmergencyBuildingScanEventDistance;
        /* 0x458 */ public float EmergencyBuildingScanEventTime;
        /* 0x45C */ public float ProjectileLightIntensity;
        /* 0x460 */ public float AggressiveSentinelProbability;
        /* 0x464 */ public GcExperienceTimers SentinelTimers;
        /* 0x484 */ public int FreighterStartPecent;
        /* 0x488 */ public GcExperienceTimers FreighterTimers;
        /* 0x4A8 */ public GcExperienceTimers PirateTimers;
        /* 0x4C8 */ public GcExperienceTimers HardPirateTimers;
        [NMS(Size = 0x3)]
        /* 0x4E8 */ public float[] PirateEarlySpawnChances;
        /* 0x4F4 */ public float PirateEarlySpawnTime;
        /* 0x4F8 */ public GcExperienceTimers FlybyTimers;
        /* 0x518 */ public GcExperienceTimers SpaceFlybyTimers;
        /* 0x538 */ public int SentinelsHigh;
        /* 0x53C */ public int SentinelsLow;
        /* 0x540 */ public float AsteroidHitForce;
        /* 0x544 */ public float AsteroidTorqueForce;
        /* 0x548 */ public float AsteroidCarveRadius;
        /* 0x54C */ public int DeathMoneyPenalty;
        /* 0x550 */ public int DeathMoneyPenaltyHardMode;
        /* 0x554 */ public int MaxResourceCrystalBlobSize;
        /* 0x558 */ public float BuildingBeamDistance;
        /* 0x55C */ public float WaypointScanTime;
        /* 0x560 */ public int RareSubstanceEffectiveness;
        /* 0x564 */ public int CommonProductEffectiveness;
        /* 0x568 */ public int RareProductEffectiveness;
        /* 0x56C */ public int AsteroidResourceReducer;
        /* 0x570 */ public float VoxelAsteroidResourceChance;
        /* 0x574 */ public int ResourceReducer;
        /* 0x578 */ public int ResourceMinAmount;
        /* 0x57C */ public int ResourceMaxAmount;
        /* 0x580 */ public int ResourceCommonReducer;
        /* 0x584 */ public int ResourceCommonMinAmount;
        /* 0x588 */ public int ResourceCommonMaxAmount;
        [NMS(Size = 0x20)]
        /* 0x58C */ public string RobotResource;
        [NMS(Size = 0x20)]
        /* 0x5AC */ public string DepotResource;
        /* 0x5CC */ public float DockNodeBuyRadius;
        /* 0x5D0 */ public float BeaconInteractRange;
        /* 0x5D4 */ public float ShipInteractRadius;
        /* 0x5D8 */ public GcResourceCollectEffect AsteroidResourceCollect;
        /* 0x60C */ public float ScanAngleCutoff;
        /* 0x610 */ public GcScanData ToolScan;
        /* 0x624 */ public GcScanData ToolScanHardMode;
        /* 0x638 */ public GcScanData WaypointScan;
        /* 0x64C */ public GcScanData BeaconScan;
        /* 0x660 */ public GcScanData RadioTowerScan;
        /* 0x674 */ public GcScanData ObservatoryScan;
        /* 0x688 */ public GcScanData DistressSignalScan;
        /* 0x69C */ public GcScanData DebugScanPlanet;
        /* 0x6B0 */ public GcScanData DebugScanSpace;
        /* 0x6C4 */ public GcScanData ShipScan;
        /* 0x6D8 */ public GcScanData VisualScan;
        /* 0x6EC */ public float ZoomFindBuildingRange;
        /* 0x6F0 */ public float TimeToDisplayScanResults;
        /* 0x6F4 */ public float HoverTimeToScan;
        /* 0x6F8 */ public float HoverTimeToScanCreatures;
        /* 0x6FC */ public int HoverVisiblePointsNeeded;
        [NMS(Size = 0x4)]
        /* 0x700 */ public GcZoomData[] ZoomLevels;
        /* 0x770 */ public GcScanEffectData PassiveScanEffect;
        /* 0x7C0 */ public GcScanEffectData BuildingScanEffect;
        /* 0x810 */ public GcScanEffectData TargetShipScanEffect;
        /* 0x860 */ public GcScanEffectData HUDShipScanEffect;
        /* 0x8B0 */ public GcScanEffectData CreatureScanEffect;
        /* 0x900 */ public GcScanEffectData ObjectsScanEffect;
        /* 0x950 */ public GcScanEffectData BaseBuildingScanEffect;
        /* 0x9A0 */ public GcScanEffectData BaseBuildingBlockedScanEffect;
        /* 0x9F0 */ public GcScanEffectData BaseBuildingFreighterScanEffect;
        /* 0xA40 */ public GcScanEffectData BaseBuildingFreighterBlockedScanEffect;
        /* 0xA90 */ public GcScanEffectData BaseBuildingSelectionScanEffect;
        /* 0xAE0 */ public GcScanEffectData BaseBuildingRemotePlayerScanEffect;
        /* 0xB30 */ public GcScanEffectData BaseBuildingRemotePlayerBlockedScanEffect;
        /* 0xB80 */ public GcScanEffectData BaseBuildingRemotePlayerFreighterScanEffect;
        /* 0xBD0 */ public GcScanEffectData BaseBuildingRemotePlayerFreighterBlockedScanEffect;
        /* 0xC20 */ public GcScanEffectData BaseBuildingRemotePlayerSelectionScanEffect;
        /* 0xC70 */ public bool UseDebugScan;
        /* 0xC71 */ public bool DebugScanForceBuilding;
        /* 0xC74 */ public float DebugScanForceBuildingType;
        /* 0xC78 */ public float ShipScanOffset;
        /* 0xC7C */ public float ShipScanOffsetGap;
        /* 0xC80 */ public TkCurveType ShipScanCurve;
        /* 0xC84 */ public float ScannerMarkerFadeTime;
        /* 0xC88 */ public float ScannerSmallMarkerFadeTime;
        /* 0xC8C */ public float ScannerPhysicsProbeAABBSize;
        /* 0xC90 */ public float ScannerAnalyzeFXRate;
        /* 0xC94 */ public float ScannerSubstanceTimePerTrigger;
        /* 0xC98 */ public float ScannerTuningA;
        /* 0xC9C */ public float ScannerTuningB;
        /* 0xCA0 */ public float ScannerTuningC;
        /* 0xCA4 */ public float ScannerTuningD;
        /* 0xCA8 */ public float ScannerTuningResourceOffset1;
        /* 0xCAC */ public float ScannerTuningResourceOffset2;
        /* 0xCB0 */ public float ScannerTuningSmoothStepAmount;
        /* 0xCB4 */ public float ScannerTuningTrailingEdge;
        /* 0xCB8 */ public bool Autolevel;
        /* 0xCC0 */ public Colour ScannerColour1;
        /* 0xCD0 */ public Colour ScannerColour2;
        /* 0xCE0 */ public float HUDStoreFlashTime;
        /* 0xCE4 */ public float ExcitingViewAngle;
        /* 0xCE8 */ public float ExcitingViewRange;
        /* 0xCEC */ public float ExcitingNearRange;
        /* 0xCF0 */ public float ProjectileSpeedBoost;
        /* 0xCF4 */ public float LineWidth;
        /* 0xCF8 */ public float LockOffFactor;
        /* 0xCFC */ public float OffscreenFadeDistance;
        /* 0xD00 */ public float OffscreenMinDot;
        /* 0xD04 */ public bool HUDUpdateFromData;
        /* 0xD08 */ public float HUDLockOnAudioTime;
        /* 0xD0C */ public float HUDArrowPrimaryScaler;
        /* 0xD10 */ public Vector2f HUDDamageSize;
        /* 0xD18 */ public Vector2f HUDDamageSplatSize;
        /* 0xD20 */ public Colour HUDDamageSplatShieldColour;
        /* 0xD30 */ public Colour HUDDamageSplatPainColour;
        /* 0xD40 */ public float HUDDamageOffset;
        /* 0xD44 */ public float HUDDamageScaler;
        /* 0xD48 */ public float HUDDamageRadius;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xD4C */ public byte[] PaddingD4C;
        /* 0xD50 */ public GcShipHUDTargetData HUDTarget;
        /* 0x1180 */ public float HUDLabelTime;
        /* 0x1184 */ public float HUDLabelAngle;
        /* 0x1188 */ public float HUDLabelAngleOffset;
        /* 0x118C */ public float HUDLabelOffsetX;
        /* 0x1190 */ public float HUDLabelOffsetY;
        /* 0x1194 */ public float HUDLabelOffsetZ;
        /* 0x1198 */ public float HUDLabelScale;
        /* 0x119C */ public float MaxSpawnTime;
        [NMS(Size = 0x80)]
        /* 0x11A0 */ public string ResourceParticleFile;
        /* 0x1220 */ public float ResourceParticleSpeed;
        /* 0x1224 */ public float ResourceParticleSpread;
        /* 0x1228 */ public int ResourceParticleMaxNum;
        /* 0x122C */ public int ResourceParticleMinNum;
        /* 0x1230 */ public float MapHeight;
        /* 0x1234 */ public float MapOffset;
        /* 0x1238 */ public float MapTargetOffset;
        /* 0x123C */ public float MapFOV;
        /* 0x1240 */ public float MapRadius;
        /* 0x1244 */ public float HUDScaleAdd;
        /* 0x1248 */ public float HUDScaleRadius;
        /* 0x124C */ public float HUDScaleMin;
        /* 0x1250 */ public float HUDScaleMinAim;
        /* 0x1254 */ public float HUDScaleMax;
        /* 0x1258 */ public float HUDScaleFarTarget;
        /* 0x125C */ public float HUDReticuleMoveBack;
        /* 0x1260 */ public float HUDReticuleMoveAim;
        /* 0x1264 */ public float MouseSensitivity;
        /* 0x1268 */ public float MouseSensitivityShip;
        /* 0x126C */ public float PainTime;
        /* 0x1270 */ public TkCurveType PainCurve;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x1274 */ public byte[] Padding1274;
        /* 0x1280 */ public Colour PainColour;
        /* 0x1290 */ public float GunOffsetX;
        /* 0x1294 */ public float GunOffsetY;
        /* 0x1298 */ public float GunOffsetZ;
        /* 0x129C */ public float GunDownAngle;
        /* 0x12A0 */ public float GunUpAngle;
        /* 0x12A4 */ public float BarrelOffset;
        /* 0x12A8 */ public float HitOffset;
        /* 0x12AC */ public GcTracerData BulletTracer;
        /* 0x12C4 */ public GcTracerData ShipTracer;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x12DC */ public byte[] Padding12DC;
        [NMS(Size = 0x10)]
        /* 0x12E0 */ public string DefaultAnim;
        /* 0x12F0 */ public bool DebugDrawTriggerBoxes;
        /* 0x12F4 */ public float SpeedReadoutMultiplier;
        /* 0x12F8 */ public float SpaceSpeedReadoutMultiplier;
        /* 0x12FC */ public float TorchFoV;
        /* 0x1300 */ public float TorchStrength;
        /* 0x1304 */ public float TorchOffsetX;
        /* 0x1308 */ public float TorchOffsetY;
        /* 0x130C */ public float TorchOffsetZ;
        /* 0x1310 */ public float TorchRotation;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x1314 */ public byte[] Padding1314;
        /* 0x1320 */ public Colour TorchColour;
        /* 0x1330 */ public float SimpleInteractionPickupAngle;
        /* 0x1334 */ public float SimpleInteractionPickupRadius;
        /* 0x1338 */ public float SimpleInteractionMessageTime;
        /* 0x133C */ public float InteractionPickupAngle;
        /* 0x1340 */ public float InteractionPickupRadius;
        /* 0x1344 */ public float ExplosionRadiusMultiplier;
        /* 0x1348 */ public float ExplosionForce;
        /* 0x134C */ public float ExplosionForceMaxForceRadius;
        /* 0x1350 */ public float LaserExplosionForceRadius;
        /* 0x1354 */ public float LaserExplosionForce;
        /* 0x1358 */ public float LaserExplosionForceMaxForceRadius;
        [NMS(Size = 0x80)]
        /* 0x135C */ public string InitialDebrisScene;
        /* 0x13DC */ public float BonusSameTypeElementsAdd;
        /* 0x13E0 */ public float BonusSameTypeElementsMultiply;
        /* 0x13E4 */ public float BonusChildTypeElementsAdd;
        /* 0x13E8 */ public float BonusChildTypeElementsMultiply;
        /* 0x13EC */ public float InteractionComponentUpdateDistance;
        /* 0x13F0 */ public float GoalGapVoxelDist;
        /* 0x13F4 */ public float BlackHoleJumpVoxelDist;
        /* 0x13F8 */ public float BlackHoleJumpVoxelVariation;
        /* 0x13FC */ public float JumpToCenterFuelCost;
        /* 0x1400 */ public int WarpsBetweenMiniStation;
        /* 0x1404 */ public float HoursBetweenMiniStation;
        [NMS(Size = 0x80)]
        /* 0x1408 */ public string LegacyBaseBuildingTable;
        [NMS(Size = 0x80)]
        /* 0x1488 */ public string BaseBuildingTable;
        /* 0x1508 */ public int NPCWorkerInteractionCooldownA;      // don't know... 8 bytes...
        /* 0x150C */ public int NPCWorkerInteractionCooldownB;
        /* 0x1510 */ public float LightStrength;
        /* 0x1514 */ public float AirLockDoorRange;
        /* 0x1518 */ public bool KeepAttackingMaxWantedLevel;
        /* 0x1519 */ public bool UseMultiplierBonus;
        /* 0x151C */ public float ShipDisplayDamageMultiplier;
        /* 0x1520 */ public bool UseTradingCostTable;
        /* 0x1521 */ public bool ChangePricesLocally;
        /* 0x1522 */ public bool ShowPriceMarkupsAsPercentages;
        /* 0x1524 */ public int ProductItemStockDecayTime;
        /* 0x1528 */ public int ProductItemStockReplenishTime;
        /* 0x152C */ public int SubstanceItemStockDecayTime;
        /* 0x1530 */ public int SubstanceItemStockReplenishTime;
        /* 0x1534 */ public GcPortalData Portal;
        /* 0x153C */ public int FourthRaceSpawnPercentage;
        /* 0x1540 */ public float ViciousSentinelProbability;
        /* 0x1544 */ public float ViciousStormProbability;
        /* 0x1548 */ public float ViciousWeatherProbability;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x154C */ public byte[] Endpadding;
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
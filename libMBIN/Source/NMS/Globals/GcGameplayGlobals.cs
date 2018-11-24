using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS( GUID = 0xC78D17FE2EF366D8 )]
    public class GcGameplayGlobals : NMSTemplate
    {
                     [NMS(Size = 0x03)]
        /* 0x0000 */ public NMSString0x10[] HyperdriveAccess;
                     [NMS(Size = 0x03)]
        /* 0x0030 */ public NMSString0x10[] FreighterHyperdriveAccess;
        /* 0x0060 */ public bool FreighterRequiresRGBHyperdriveUpgrades;
        /* 0x0061 */ public bool AllowTeleportItemsToFreighter;
        /* 0x0062 */ public bool DisableAnomalyAmbientSpawn;
        /* 0x0063 */ public bool AllowDeconstruct;
        /* 0x0064 */ public bool AllowBinocularMarker;
        /* 0x0065 */ public bool EveryMaintenanceIsBroken;
        /* 0x0066 */ public bool SpawnResourceBlobsOnPartDelete;
        /* 0x0067 */ public bool EnableShootHitEffect;
        /* 0x0068 */ public int MaxNumSameGroupTech;
        /* 0x006C */ public float ShootableArmourHighlightHitTime;
        /* 0x0070 */ public float ShootableAggroMinStartTime;
        /* 0x0074 */ public float ShootableAggroForgetTime;
                     [NMS(Size = 0x08, Ignore = true)]
        /* 0x0078 */ public byte[] Padding78;
        /* 0x0080 */ public Colour RefinerColour1A;
        /* 0x0090 */ public Colour RefinerColour1B;
        /* 0x00A0 */ public Colour RefinerColour1C;
        /* 0x00B0 */ public Colour RefinerColour1D;
        /* 0x00C0 */ public float AtmosphereEntryTime;
        /* 0x00C4 */ public float AtmosphereEntryFadeTimeFactor;
        /* 0x00C8 */ public float AtmosphereEntryOffset;
        /* 0x00CC */ public TkCurveType AtmosphereEntryCurve;
        /* 0x00D0 */ public float TerrainResourceScanTime;
        /* 0x00D4 */ public float TerrainResourceScanRange;
        /* 0x00D8 */ public bool BinocsDisplayUnknownCreatures;
                     [NMS(Size = 0x03, Ignore = true)]
        /* 0x00D9 */ public byte[] PaddingD9;
        /* 0x00DC */ public float BinocularScanTargetMinHeight;
        /* 0x00E0 */ public float BinocularScanTargetHeightRange;
        /* 0x00E4 */ public float BinocTimeBeforeScan;
        /* 0x00E8 */ public float BinocMinScanTime;
        /* 0x00EC */ public float BinocScanTime;
        /* 0x00F0 */ public float BinocCreatureScanTime;
        /* 0x00F4 */ public TkCurveType BinocularScanTargetHeightCurve;
        /* 0x00F8 */ public float BinocularScanTargetInitialFadeTime;
        /* 0x00FC */ public float BinocularScanTargetScaler;
        /* 0x0100 */ public float BinocularScanTargetLineWidth;
        /* 0x0104 */ public float BinocularScanTargetFadeTime;
                     [NMS(Size = 0x08, Ignore = true)]
        /* 0x0108 */ public byte[] Padding108;
        /* 0x0110 */ public Colour BinocularScanTargetColour;
        /* 0x0120 */ public GcScanEffectData BinocularScanEffect;
        /* 0x0170 */ public float ScannerIconsClumpRadius;
        /* 0x0174 */ public float ScannableComponentMarkerOffset;
        /* 0x0178 */ public float ScannableComponentPlaceMarkerOffset;
        /* 0x017C */ public float MissionEventAllowResetDistance;
        /* 0x0180 */ public float AllRecipesKnownNanitesMin;
        /* 0x0184 */ public float AllRecipesKnownNanitesMax;
        /* 0x0188 */ public float MaxPossibleShipDamagePotential;
        /* 0x018C */ public float BuildingPlayerBaseIconOffset;
        /* 0x0190 */ public float CriticalHitMultiplier;
        /* 0x0194 */ public float HitEffectMinTime;
        /* 0x0198 */ public float GrabPlayerCooldownTime;
        /* 0x019C */ public float TapInteractionIncreaseAmount;
        /* 0x01A0 */ public float TapInteractionDecay;
                     [NMS(Size = 0x0C, Ignore = true)]
        /* 0x01A4 */ public byte[] Padding1A4;
        /* 0x01B0 */ public GcScanEffectData DeconstructEffect;
        /* 0x0200 */ public GcScanEffectData HitEffect;
        /* 0x0250 */ public GcScanEffectData HitEffectCritical;
        /* 0x02A0 */ public float CommunicatorSpawnOffset;
        /* 0x02A4 */ public float CommunicatorSpawnHeightOffset;
                     [NMS(Size = 0x08, Ignore = true)]
        /* 0x02A8 */ public byte[] Padding2A8;
        /* 0x02B0 */ public Vector4f CommunicatorShipSpawnOffset;
        /* 0x02C0 */ public float CommunicatorSpawnScale;
        /* 0x02C4 */ public float CommunicatorSpawnRotation;
        /* 0x02C8 */ public float CommunicatorFadeTime;
                     [NMS(Size = 0x04, Ignore = true)]
        /* 0x02CC */ public byte[] Padding2CC;
                     [NMS(Size = 0x02)]
        /* 0x02D0 */ public GcScanEffectData[] CommunicatorEffectTable;
        /* 0x0370 */ public int MaxNumMissionsFromMissionGiver;
        /* 0x0374 */ public float InteractionMessageModuleDisplayTime;
        /* 0x0378 */ public float InteractionAttractTime;
        /* 0x037C */ public float InteractionDescriptionTextTime;
        /* 0x0380 */ public float InteractionMinTimeForResponseText;
        /* 0x0384 */ public bool InteractionOverride;
                     [NMS(Size = 0x03, Ignore = true)]
        /* 0x0385 */ public byte[] Padding385;
        /* 0x0388 */ public GcInteractionType InteractionOverrideFrom;
        /* 0x038C */ public GcInteractionType InteractionOverrideTo;
        /* 0x0390 */ public float DestroyEffectHeight;
        /* 0x0394 */ public float DestroyEffectMaxScale;
        /* 0x0398 */ public float EventTargetSpeed;
        /* 0x039C */ public int SpecialMiningAmount;
        /* 0x03A0 */ public float SpecialMiningTime;
        /* 0x03A4 */ public int HardModeTechDamageMidNum;
        /* 0x03A8 */ public int HardModeTechDamageMidPercent;
        /* 0x03AC */ public int HardModeTechDamageHighPercent;
        /* 0x03B0 */ public int PirateInterestOverride;
        /* 0x03B4 */ public float PirateInterestDistance;
                     [NMS(Size = 0x03)]
        /* 0x03B8 */ public int[] PirateInterestLevels;
        /* 0x03C4 */ public float SpaceCombatRadius;
        /* 0x03C8 */ public int WarpsBetweenBattles;
        /* 0x03CC */ public float HoursBetweenBattles;
        /* 0x03D0 */ public float SpaceBattleRadius;
        /* 0x03D4 */ public float SpaceBattleAnyHostileShipsRadius;
        /* 0x03D8 */ public float FreighterBattleRadius;
        /* 0x03DC */ public float MissileMaxTurnAngle;
        /* 0x03E0 */ public float MissileLockTime;
        /* 0x03E4 */ public float MissileReloadTime;
        /* 0x03E8 */ public float MissileRotateMin;
        /* 0x03EC */ public float MissileRotateMax;
        /* 0x03F0 */ public float MissileMaxSpeed;
        /* 0x03F4 */ public float MissileForceMin;
        /* 0x03F8 */ public float MissileForceMax;
        /* 0x03FC */ public float MissileBrakeForceMin;
        /* 0x0400 */ public float MissileBrakeForceMax;
        /* 0x0404 */ public float MissileThreatTime;
        /* 0x0408 */ public float MissileBrakeTime;
        /* 0x040C */ public float MissileHitRadius;
        /* 0x0410 */ public float MissileOffset;
        /* 0x0414 */ public float MissileMinCircleTime;
        /* 0x0418 */ public float MissileApproachTime;
        /* 0x041C */ public float MissileRotateSpeed;
        /* 0x0420 */ public float ScanStartTimeDelayMinDist;
        /* 0x0424 */ public float ScanStartTimeDelayRange;
        /* 0x0428 */ public float ScanStartTimeDistanceDelayTime;
        /* 0x042C */ public float ScanStickyDecay;
        /* 0x0430 */ public float CreatureScanStickyDecay;
        /* 0x0434 */ public float CreatureScanAngle;
        /* 0x0438 */ public float CreatureMinScanTime;
        /* 0x043C */ public float ScanAngle;
        /* 0x0440 */ public float NewDiscoveryDisplayTime;
        /* 0x0444 */ public bool FailToFindBuildings;
                     [NMS(Size = 0x03, Ignore = true)]
        /* 0x0445 */ public byte[] Padding445;
        /* 0x0448 */ public int CritDamage;
        /* 0x044C */ public float CritScale;
        /* 0x0450 */ public int NumMissionsPerSolarSystem;
        /* 0x0454 */ public float EmergencyBuildingScanEventDistance;
        /* 0x0458 */ public float EmergencyBuildingScanEventTime;
        /* 0x045C */ public float ProjectileLightIntensity;
        /* 0x0460 */ public float AggressiveSentinelProbability;
        /* 0x0464 */ public GcExperienceTimers SentinelTimers;
        /* 0x0484 */ public int FreighterStartPecent;
        /* 0x0488 */ public GcExperienceTimers FreighterTimers;
        /* 0x04A8 */ public GcExperienceTimers PirateTimers;
        /* 0x04C8 */ public GcExperienceTimers HardPirateTimers;
                     [NMS(Size = 0x03)]
        /* 0x04E8 */ public float[] PirateEarlySpawnChances;
        /* 0x04F4 */ public float PirateEarlySpawnTime;
        /* 0x04F8 */ public GcExperienceTimers FlybyTimers;
        /* 0x0518 */ public GcExperienceTimers SpaceFlybyTimers;
        /* 0x0538 */ public int SentinelsHigh;
        /* 0x053C */ public int SentinelsLow;
        /* 0x0540 */ public float AsteroidHitForce;
        /* 0x0544 */ public float AsteroidTorqueForce;
        /* 0x0548 */ public float AsteroidCarveRadius;
        /* 0x054C */ public int DeathMoneyPenalty;
        /* 0x0550 */ public int DeathMoneyPenaltyHardMode;
        /* 0x0554 */ public int MaxResourceCrystalBlobSize;
        /* 0x0558 */ public float BuildingBeamDistance;
        /* 0x055C */ public float WaypointScanTime;
        /* 0x0560 */ public int RareSubstanceEffectiveness;
        /* 0x0564 */ public int CommonProductEffectiveness;
        /* 0x0568 */ public int RareProductEffectiveness;
        /* 0x056C */ public int AsteroidResourceReducer;
        /* 0x0570 */ public float VoxelAsteroidResourceChance;
        /* 0x0574 */ public int ResourceReducer;
        /* 0x0578 */ public int ResourceMinAmount;
        /* 0x057C */ public int ResourceMaxAmount;
        /* 0x0580 */ public int ResourceCommonReducer;
        /* 0x0584 */ public int ResourceCommonMinAmount;
        /* 0x0588 */ public int ResourceCommonMaxAmount;
                     [NMS(Size = 0x20)]
        /* 0x058C */ public string RobotResource;
                     [NMS(Size = 0x20)]
        /* 0x05AC */ public string DepotResource;
        /* 0x05CC */ public float DockNodeBuyRadius;
        /* 0x05D0 */ public float BeaconInteractRange;
        /* 0x05D4 */ public float ShipInteractRadius;
        /* 0x05D8 */ public GcResourceCollectEffect AsteroidResourceCollect;
        /* 0x060C */ public float ScanAngleCutoff;
        /* 0x0610 */ public GcScanData ToolScan;
        /* 0x0624 */ public GcScanData ToolScanHardMode;
        /* 0x0638 */ public GcScanData WaypointScan;
        /* 0x064C */ public GcScanData BeaconScan;
        /* 0x0660 */ public GcScanData RadioTowerScan;
        /* 0x0674 */ public GcScanData ObservatoryScan;
        /* 0x0688 */ public GcScanData DistressSignalScan;
        /* 0x069C */ public GcScanData DebugScanPlanet;
        /* 0x06B0 */ public GcScanData DebugScanSpace;
        /* 0x06C4 */ public GcScanData ShipScan;
        /* 0x06D8 */ public GcScanData VisualScan;
        /* 0x06EC */ public float ZoomFindBuildingRange;
        /* 0x06F0 */ public float TimeToDisplayScanResults;
        /* 0x06F4 */ public float HoverTimeToScan;
        /* 0x06F8 */ public float HoverTimeToScanCreatures;
        /* 0x06FC */ public int HoverVisiblePointsNeeded;
                     [NMS(Size = 0x04)]
        /* 0x0700 */ public GcZoomData[] ZoomLevels;
        /* 0x0770 */ public GcScanEffectData PassiveScanEffect;
        /* 0x07C0 */ public GcScanEffectData BuildingScanEffect;
        /* 0x0810 */ public GcScanEffectData TargetShipScanEffect;
        /* 0x0860 */ public GcScanEffectData HUDShipScanEffect;
        /* 0x08B0 */ public GcScanEffectData CreatureScanEffect;
        /* 0x0900 */ public GcScanEffectData ObjectsScanEffect;
        /* 0x0950 */ public GcScanEffectData BaseBuildingScanEffect;
        /* 0x09A0 */ public GcScanEffectData BaseBuildingBlockedScanEffect;
        /* 0x09F0 */ public GcScanEffectData BaseBuildingFreighterScanEffect;
        /* 0x0A40 */ public GcScanEffectData BaseBuildingFreighterBlockedScanEffect;
        /* 0x0A90 */ public GcScanEffectData BaseBuildingSelectionScanEffect;
        /* 0x0AE0 */ public GcScanEffectData BaseBuildingRemotePlayerScanEffect;
        /* 0x0B30 */ public GcScanEffectData BaseBuildingRemotePlayerBlockedScanEffect;
        /* 0x0B80 */ public GcScanEffectData BaseBuildingRemotePlayerFreighterScanEffect;
        /* 0x0BD0 */ public GcScanEffectData BaseBuildingRemotePlayerFreighterBlockedScanEffect;
        /* 0x0C20 */ public GcScanEffectData BaseBuildingRemotePlayerSelectionScanEffect;
        /* 0x0C70 */ public bool UseDebugScan;
        /* 0x0C71 */ public bool DebugScanForceBuilding;
                     [NMS(Size = 0x02, Ignore = true)]
        /* 0x0C72 */ public byte[] PaddingC72;
        /* 0x0C74 */ public GcBuildingClassification DebugScanForceBuildingType;
        /* 0x0C78 */ public float ShipScanOffset;
        /* 0x0C7C */ public float ShipScanOffsetGap;
        /* 0x0C80 */ public TkCurveType ShipScanCurve;
        /* 0x0C84 */ public float ScannerMarkerFadeTime;
        /* 0x0C88 */ public float ScannerSmallMarkerFadeTime;
        /* 0x0C8C */ public float ScannerPhysicsProbeAABBSize;
        /* 0x0C90 */ public float ScannerAnalyzeFXRate;
        /* 0x0C94 */ public float ScannerSubstanceTimePerTrigger;
        /* 0x0C98 */ public float ScannerTuningA;
        /* 0x0C9C */ public float ScannerTuningB;
        /* 0x0CA0 */ public float ScannerTuningC;
        /* 0x0CA4 */ public float ScannerTuningD;
        /* 0x0CA8 */ public float ScannerTuningResourceOffset1;
        /* 0x0CAC */ public float ScannerTuningResourceOffset2;
        /* 0x0CB0 */ public float ScannerTuningSmoothStepAmount;
        /* 0x0CB4 */ public float ScannerTuningTrailingEdge;
        /* 0x0CB8 */ public bool Autolevel;
                     [NMS(Size = 0x07, Ignore = true)]
        /* 0x0CB9 */ public byte[] PaddingCB9;
        /* 0x0CC0 */ public Colour ScannerColour1;
        /* 0x0CD0 */ public Colour ScannerColour2;
        /* 0x0CE0 */ public float HUDStoreFlashTime;
        /* 0x0CE4 */ public float ExcitingViewAngle;
        /* 0x0CE8 */ public float ExcitingViewRange;
        /* 0x0CEC */ public float ExcitingNearRange;
        /* 0x0CF0 */ public float ProjectileSpeedBoost;
        /* 0x0CF4 */ public float LineWidth;
        /* 0x0CF8 */ public float LockOffFactor;
        /* 0x0CFC */ public float OffscreenFadeDistance;
        /* 0x0D00 */ public float OffscreenMinDot;
        /* 0x0D04 */ public bool HUDUpdateFromData;
                     [NMS(Size = 0x03, Ignore = true)]
        /* 0x0D05 */ public byte[] PaddingD05;
        /* 0x0D08 */ public float HUDLockOnAudioTime;
        /* 0x0D0C */ public float HUDArrowPrimaryScaler;
        /* 0x0D10 */ public Vector2f HUDDamageSize;
        /* 0x0D18 */ public Vector2f HUDDamageSplatSize;
        /* 0x0D20 */ public Colour HUDDamageSplatShieldColour;
        /* 0x0D30 */ public Colour HUDDamageSplatPainColour;
        /* 0x0D40 */ public float HUDDamageOffset;
        /* 0x0D44 */ public float HUDDamageScaler;
        /* 0x0D48 */ public float HUDDamageRadius;
                     [NMS(Size = 0x04, Ignore = true)]
        /* 0x0D4C */ public byte[] PaddingD4C;
        /* 0x0D50 */ public GcShipHUDTargetData HUDTarget;
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
                     [NMS(Size = 0x0C, Ignore = true)]
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
                     [NMS(Size = 0x04, Ignore = true)]
        /* 0x12DC */ public byte[] Padding12DC;
                     [NMS(Size = 0x10)]
        /* 0x12E0 */ public string DefaultAnim;
        /* 0x12F0 */ public bool DebugDrawTriggerBoxes;
                     [NMS(Size = 0x03, Ignore = true)]
        /* 0x12F1 */ public byte[] Padding12F1;
        /* 0x12F4 */ public float SpeedReadoutMultiplier;
        /* 0x12F8 */ public float SpaceSpeedReadoutMultiplier;
        /* 0x12FC */ public float TorchFoV;
        /* 0x1300 */ public float TorchStrength;
        /* 0x1304 */ public float TorchOffsetX;
        /* 0x1308 */ public float TorchOffsetY;
        /* 0x130C */ public float TorchOffsetZ;
        /* 0x1310 */ public float TorchRotation;
                     [NMS(Size = 0x0C, Ignore = true)]
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
        /* 0x1508 */ public ulong NPCWorkerInteractionCooldown;
        /* 0x1510 */ public float LightStrength;
        /* 0x1514 */ public float AirLockDoorRange;
        /* 0x1518 */ public bool KeepAttackingMaxWantedLevel;
        /* 0x1519 */ public bool UseMultiplierBonus;
                     [NMS(Size = 0x02, Ignore = true)]
        /* 0x151A */ public byte[] Padding151A;
        /* 0x151C */ public float ShipDisplayDamageMultiplier;
        /* 0x1520 */ public bool UseTradingCostTable;
        /* 0x1521 */ public bool ChangePricesLocally;
        /* 0x1522 */ public bool ShowPriceMarkupsAsPercentages;
                     [NMS(Size = 0x01, Ignore = true)]
        /* 0x1523 */ public byte[] Padding1523;
        /* 0x1524 */ public int ProductItemStockDecayTime;
        /* 0x1528 */ public int ProductItemStockReplenishTime;
        /* 0x152C */ public int SubstanceItemStockDecayTime;
        /* 0x1530 */ public int SubstanceItemStockReplenishTime;
        /* 0x1534 */ public GcPortalData Portal;
        /* 0x153C */ public int FourthRaceSpawnPercentage;
        /* 0x1540 */ public float ViciousSentinelProbability;
        /* 0x1544 */ public float ViciousStormProbability;
        /* 0x1548 */ public float ViciousWeatherProbability;
        /* 0x154C */ public float ScrapDroneProbability;
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
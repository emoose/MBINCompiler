using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x397E231F547EC919)]
    public class GcGameplayGlobals : NMSTemplate
    {

        [NMS(Size = 0x03)]
        /* 0x0158 */ public NMSString0x10[] HyperdriveAccess;
        [NMS(Size = 0x03)]
        /* 0x00188 */ public NMSString0x10[] FreighterHyperdriveAccess;
        /* 0x001B8 */ public bool FreighterRequiresRGBHyperdriveUpgrades;
        /* 0x001B9 */ public bool AllowTeleportItemsToFreighter;
        /* 0x001BA */ public bool DisableAnomalyAmbientSpawn;
        /* 0x001BB */ public bool AllowDeconstruct;
        /* 0x001BC */ public bool AllowBinocularMarker;
        /* 0x001BD */ public bool EveryMaintenanceIsBroken;
        /* 0x001BE */ public bool SpawnResourceBlobsOnPartDelete;
        /* 0x001BF */ public bool EnableShootHitEffect;
        /* 0x001C0 */ public int MaxNumSameGroupTech;
        /* 0x001C4 */ public float ShootableArmourHighlightHitTime;
        /* 0x001C8 */ public float ShootableAggroMinStartTime;
        /* 0x001CC */ public float ShootableAggroForgetTime;
                     [NMS(Size = 0x08, Ignore = true)]
        /* 0x001D0 */ public byte[] Padding1D0;
        /* 0x001D8 */ public Colour RefinerColour1A;
        /* 0x001E8 */ public Colour RefinerColour1B;
        /* 0x001F8 */ public Colour RefinerColour1C;
        /* 0x00208 */ public Colour RefinerColour1D;
        /* 0x00218 */ public float AtmosphereEntryTime;
        /* 0x0021C */ public float AtmosphereEntryFadeTimeFactor;
        /* 0x00220 */ public float AtmosphereEntryOffset;
        /* 0x00224 */ public TkCurveType AtmosphereEntryCurve;
        /* 0x00228 */ public float TerrainResourceScanTime;
        /* 0x0022C */ public float TerrainResourceScanRange;
        /* 0x00230 */ public bool BinocsDisplayUnknownCreatures;
                     [NMS(Size = 0x03, Ignore = true)]
        /* 0x00231 */ public byte[] Padding231;
        /* 0x00234 */ public float BinocularScanTargetMinHeight;
        /* 0x00238 */ public float BinocularScanTargetHeightRange;
        /* 0x0023C */ public float BinocTimeBeforeScan;
        /* 0x00240 */ public float BinocMinScanTime;
        /* 0x00244 */ public float BinocScanTime;
        /* 0x00248 */ public float BinocCreatureScanTime;
        /* 0x0024C */ public TkCurveType BinocularScanTargetHeightCurve;
        /* 0x00250 */ public float BinocularScanTargetInitialFadeTime;
        /* 0x00254 */ public float BinocularScanTargetScaler;
        /* 0x0258 */ public float BinocularScanTargetLineWidth;
        /* 0x025C */ public float BinocularScanTargetFadeTime;
                     [NMS(Size = 0x08, Ignore = true)]
        /* 0x0260 */ public byte[] Padding260;
        /* 0x0268 */ public Colour BinocularScanTargetColour;
        /* 0x0278 */ public GcScanEffectData BinocularScanEffect;
        /* 0x02C8 */ public float ScannerIconsClumpRadius;
        /* 0x02CC */ public float ScannableComponentMarkerOffset;
        /* 0x02D0 */ public float ScannableComponentPlaceMarkerOffset;
        /* 0x02D4 */ public float MissionEventAllowResetDistance;
        /* 0x02D8 */ public float AllRecipesKnownNanitesMin;
        /* 0x02DC */ public float AllRecipesKnownNanitesMax;
        /* 0x02E0 */ public float MaxPossibleShipDamagePotential;
        /* 0x02E4 */ public float BuildingPlayerBaseIconOffset;
        /* 0x02E8 */ public float CriticalHitMultiplier;
        /* 0x02EC */ public float HitEffectMinTime;
        /* 0x02F0 */ public float GrabPlayerCooldownTime;
        /* 0x02F4 */ public float TapInteractionIncreaseAmount;
        /* 0x02F8 */ public float TapInteractionDecay;
                     [NMS(Size = 0x0C, Ignore = true)]
        /* 0x02FC */ public byte[] Padding2FC;
        /* 0x0308 */ public GcScanEffectData DeconstructEffect;
        /* 0x0358 */ public GcScanEffectData HitEffect;
        /* 0x03A8 */ public GcScanEffectData HitEffectCritical;
        /* 0x03F8 */ public float CommunicatorSpawnOffset;
        /* 0x03FC */ public float CommunicatorSpawnHeightOffset;
                     [NMS(Size = 0x08, Ignore = true)]
        /* 0x0400 */ public byte[] Padding400;
        /* 0x0408 */ public Vector4f CommunicatorShipSpawnOffset;
        /* 0x0418 */ public float CommunicatorSpawnScale;
        /* 0x041C */ public float CommunicatorSpawnRotation;
        /* 0x0420 */ public float CommunicatorFadeTime;
                     [NMS(Size = 0x04, Ignore = true)]
        /* 0x0424 */ public byte[] Padding424;
                     [NMS(Size = 0x02)]
        /* 0x0428 */ public GcScanEffectData[] CommunicatorEffectTable;
        /* 0x04C8 */ public int MaxNumMissionsFromMissionGiver;
        /* 0x04CC */ public float InteractionMessageModuleDisplayTime;
        /* 0x04D0 */ public float InteractionAttractTime;
        /* 0x04D4 */ public float InteractionDescriptionTextTime;
        /* 0x04D8 */ public float InteractionMinTimeForResponseText;
        /* 0x04DC */ public bool InteractionOverride;
                     [NMS(Size = 0x03, Ignore = true)]
        /* 0x04DD */ public byte[] Padding4DD;
        /* 0x04E0 */ public GcInteractionType InteractionOverrideFrom;
        /* 0x04E4 */ public GcInteractionType InteractionOverrideTo;
        /* 0x04E8 */ public float DestroyEffectHeight;
        /* 0x04EC */ public float DestroyEffectMaxScale;
        /* 0x04F0 */ public float EventTargetSpeed;
        /* 0x04F4 */ public int SpecialMiningAmount;
        /* 0x04F8 */ public float SpecialMiningTime;
        /* 0x04FC */ public int HardModeTechDamageMidNum;
        /* 0x0500 */ public int HardModeTechDamageMidPercent;
        /* 0x0504 */ public int HardModeTechDamageHighPercent;
        /* 0x0508 */ public int PirateInterestOverride;
        /* 0x050C */ public float PirateInterestDistance;
                     [NMS(Size = 0x03)]
        /* 0x0510 */ public int[] PirateInterestLevels;
        /* 0x051C */ public float SpaceCombatRadius;
        /* 0x0520 */ public int WarpsBetweenBattles;
        /* 0x0524 */ public float HoursBetweenBattles;
        /* 0x0528 */ public float SpaceBattleRadius;
        /* 0x052C */ public float SpaceBattleAnyHostileShipsRadius;
        /* 0x0530 */ public float FreighterBattleRadius;
        /* 0x0534 */ public float MissileMaxTurnAngle;
        /* 0x0538 */ public float MissileLockTime;
        /* 0x053C */ public float MissileReloadTime;
        /* 0x0540 */ public float MissileRotateMin;
        /* 0x0544 */ public float MissileRotateMax;
        /* 0x0548 */ public float MissileMaxSpeed;
        /* 0x054C */ public float MissileForceMin;
        /* 0x0550 */ public float MissileForceMax;
        /* 0x0554 */ public float MissileBrakeForceMin;
        /* 0x0558 */ public float MissileBrakeForceMax;
        /* 0x055C */ public float MissileThreatTime;
        /* 0x0560 */ public float MissileBrakeTime;
        /* 0x0564 */ public float MissileHitRadius;
        /* 0x0568 */ public float MissileOffset;
        /* 0x056C */ public float MissileMinCircleTime;
        /* 0x0570 */ public float MissileApproachTime;
        /* 0x0574 */ public float MissileRotateSpeed;
        /* 0x0578 */ public float ScanStartTimeDelayMinDist;
        /* 0x057C */ public float ScanStartTimeDelayRange;
        /* 0x0580 */ public float ScanStartTimeDistanceDelayTime;
        /* 0x0584 */ public float ScanStickyDecay;
        /* 0x0588 */ public float CreatureScanStickyDecay;
        /* 0x058C */ public float CreatureScanAngle;
        /* 0x0590 */ public float CreatureMinScanTime;
        /* 0x0594 */ public float ScanAngle;
        /* 0x0598 */ public float NewDiscoveryDisplayTime;
        /* 0x059C */ public bool FailToFindBuildings;
                     [NMS(Size = 0x03, Ignore = true)]
        /* 0x059D */ public byte[] Padding59D;
        /* 0x05A0 */ public int CritDamage;
        /* 0x05A4 */ public float CritScale;
        /* 0x05A8 */ public int NumMissionsPerSolarSystem;
        /* 0x05AC */ public float EmergencyBuildingScanEventDistance;
        /* 0x05B0 */ public float EmergencyBuildingScanEventTime;
        /* 0x05B4 */ public float ProjectileLightIntensity;
        /* 0x05B8 */ public float AggressiveSentinelProbability;
        /* 0x05BC */ public GcExperienceTimers SentinelTimers;
        /* 0x05DC */ public int FreighterStartPecent;
        /* 0x05E0 */ public GcExperienceTimers FreighterTimers;
        /* 0x0600 */ public GcExperienceTimers PirateTimers;
        /* 0x0620 */ public GcExperienceTimers HardPirateTimers;
                     [NMS(Size = 0x03)]
        /* 0x0640 */ public float[] PirateEarlySpawnChances;
        /* 0x064C */ public float PirateEarlySpawnTime;
        /* 0x0650 */ public GcExperienceTimers FlybyTimers;
        /* 0x0670 */ public GcExperienceTimers SpaceFlybyTimers;
        /* 0x0690 */ public int SentinelsHigh;
        /* 0x0694 */ public int SentinelsLow;
        /* 0x0698 */ public float AsteroidHitForce;
        /* 0x069C */ public float AsteroidTorqueForce;
        /* 0x06A0 */ public float AsteroidCarveRadius;
        /* 0x06A4 */ public int DeathMoneyPenalty;
        /* 0x06A8 */ public int DeathMoneyPenaltyHardMode;
        /* 0x06AC */ public int MaxResourceCrystalBlobSize;
        /* 0x06B0 */ public float BuildingBeamDistance;
        /* 0x06B4 */ public float WaypointScanTime;
        /* 0x06B8 */ public int RareSubstanceEffectiveness;
        /* 0x06BC */ public int CommonProductEffectiveness;
        /* 0x06C0 */ public int RareProductEffectiveness;
        /* 0x06C4 */ public int AsteroidResourceReducer;
        /* 0x06C8 */ public float VoxelAsteroidResourceChance;
        /* 0x06CC */ public int ResourceReducer;
        /* 0x06D0 */ public int ResourceMinAmount;
        /* 0x06D4 */ public int ResourceMaxAmount;
        /* 0x06D8 */ public int ResourceCommonReducer;
        /* 0x06DC */ public int ResourceCommonMinAmount;
        /* 0x06E0 */ public int ResourceCommonMaxAmount;
                     [NMS(Size = 0x20)]
        /* 0x06E4 */ public string RobotResource;
                     [NMS(Size = 0x20)]
        /* 0x0704 */ public string DepotResource;
        /* 0x0724 */ public float DockNodeBuyRadius;
        /* 0x0728 */ public float BeaconInteractRange;
        /* 0x072C */ public float ShipInteractRadius;
        /* 0x0730 */ public GcResourceCollectEffect AsteroidResourceCollect;
        /* 0x0764 */ public float ScanAngleCutoff;
        /* 0x0768 */ public GcScanData ToolScan;
        /* 0x077C */ public GcScanData ToolScanHardMode;
        /* 0x0790 */ public GcScanData WaypointScan;
        /* 0x07A4 */ public GcScanData BeaconScan;
        /* 0x07B8 */ public GcScanData RadioTowerScan;
        /* 0x07CC */ public GcScanData ObservatoryScan;
        /* 0x07E0 */ public GcScanData DistressSignalScan;
        /* 0x07F4 */ public GcScanData DebugScanPlanet;
        /* 0x0808 */ public GcScanData DebugScanSpace;
        /* 0x081C */ public GcScanData ShipScan;
        /* 0x0830 */ public GcScanData VisualScan;
        /* 0x0844 */ public float ZoomFindBuildingRange;
        /* 0x0848 */ public float TimeToDisplayScanResults;
        /* 0x084C */ public float HoverTimeToScan;
        /* 0x0850 */ public float HoverTimeToScanCreatures;
        /* 0x0854 */ public int HoverVisiblePointsNeeded;
                     [NMS(Size = 0x04)]
        /* 0x0858 */ public GcZoomData[] ZoomLevels;
        /* 0x08C8 */ public GcScanEffectData PassiveScanEffect;
        /* 0x0918 */ public GcScanEffectData BuildingScanEffect;
        /* 0x0968 */ public GcScanEffectData TargetShipScanEffect;
        /* 0x09B8 */ public GcScanEffectData HUDShipScanEffect;
        /* 0x0A08 */ public GcScanEffectData CreatureScanEffect;
        /* 0x0A58 */ public GcScanEffectData ObjectsScanEffect;
        /* 0x0AA8 */ public GcScanEffectData BaseBuildingScanEffect;
        /* 0x0AF8 */ public GcScanEffectData BaseBuildingBlockedScanEffect;
        /* 0x0B48 */ public GcScanEffectData BaseBuildingFreighterScanEffect;
        /* 0x0B98 */ public GcScanEffectData BaseBuildingFreighterBlockedScanEffect;
        /* 0x0BE8 */ public GcScanEffectData BaseBuildingSelectionScanEffect;
        /* 0x0C38 */ public GcScanEffectData BaseBuildingRemotePlayerScanEffect;
        /* 0x0C88 */ public GcScanEffectData BaseBuildingRemotePlayerBlockedScanEffect;
        /* 0x0CD8 */ public GcScanEffectData BaseBuildingRemotePlayerFreighterScanEffect;
        /* 0x0D28 */ public GcScanEffectData BaseBuildingRemotePlayerFreighterBlockedScanEffect;
        /* 0x0D78 */ public GcScanEffectData BaseBuildingRemotePlayerSelectionScanEffect;
        /* 0x0DC8 */ public bool UseDebugScan;
        /* 0x0DC9 */ public bool DebugScanForceBuilding;
                     [NMS(Size = 0x02, Ignore = true)]
        /* 0x0DCA */ public byte[] PaddingDCA;
        /* 0x0DCC */ public GcBuildingClassification DebugScanForceBuildingType;
        /* 0x0DD0 */ public float ShipScanOffset;
        /* 0x0DD4 */ public float ShipScanOffsetGap;
        /* 0x0DD8 */ public TkCurveType ShipScanCurve;
        /* 0x0DDC */ public float ScannerMarkerFadeTime;
        /* 0x0DE0 */ public float ScannerSmallMarkerFadeTime;
        /* 0x0DE4 */ public float ScannerPhysicsProbeAABBSize;
        /* 0x0DE8 */ public float ScannerAnalyzeFXRate;
        /* 0x0DEC */ public float ScannerSubstanceTimePerTrigger;
        /* 0x0DF0 */ public float ScannerTuningA;
        /* 0x0DF4 */ public float ScannerTuningB;
        /* 0x0DF8 */ public float ScannerTuningC;
        /* 0x0DFC */ public float ScannerTuningD;
        /* 0x0E00 */ public float ScannerTuningResourceOffset1;
        /* 0x0E04 */ public float ScannerTuningResourceOffset2;
        /* 0x0E08 */ public float ScannerTuningSmoothStepAmount;
        /* 0x0E0C */ public float ScannerTuningTrailingEdge;
        /* 0x0E10 */ public bool Autolevel;
                     [NMS(Size = 0x07, Ignore = true)]
        /* 0x0E11 */ public byte[] PaddingE11;
        /* 0x0E18 */ public Colour ScannerColour1;
        /* 0x0E28 */ public Colour ScannerColour2;
        /* 0x0E38 */ public float HUDStoreFlashTime;
        /* 0x0E3C */ public float ExcitingViewAngle;
        /* 0x0E40 */ public float ExcitingViewRange;
        /* 0x0E44 */ public float ExcitingNearRange;
        /* 0x0E48 */ public float ProjectileSpeedBoost;
        /* 0x0E4C */ public float LineWidth;
        /* 0x0E50 */ public float LockOffFactor;
        /* 0x0E54 */ public float OffscreenFadeDistance;
        /* 0x0E58 */ public float OffscreenMinDot;
        /* 0x0E5C */ public bool HUDUpdateFromData;
                     [NMS(Size = 0x03, Ignore = true)]
        /* 0x0E5D */ public byte[] PaddingE5D;
        /* 0x0E60 */ public float HUDLockOnAudioTime;
        /* 0x0E64 */ public float HUDArrowPrimaryScaler;
        /* 0x0E68 */ public Vector2f HUDDamageSize;
        /* 0x0E70 */ public Vector2f HUDDamageSplatSize;
        /* 0x0E78 */ public Colour HUDDamageSplatShieldColour;
        /* 0x0E88 */ public Colour HUDDamageSplatPainColour;
        /* 0x0E98 */ public float HUDDamageOffset;
        /* 0x0E9C */ public float HUDDamageScaler;
        /* 0x0EA0 */ public float HUDDamageRadius;
                     [NMS(Size = 0x04, Ignore = true)]
        /* 0x0EA4 */ public byte[] PaddingEA4;
        /* 0x0EA8 */ public GcShipHUDTargetData HUDTarget;
        /* 0x12D8 */ public float HUDLabelTime;
        /* 0x12DC */ public float HUDLabelAngle;
        /* 0x12E0 */ public float HUDLabelAngleOffset;
        /* 0x12E4 */ public float HUDLabelOffsetX;
        /* 0x12E8 */ public float HUDLabelOffsetY;
        /* 0x12EC */ public float HUDLabelOffsetZ;
        /* 0x12F0 */ public float HUDLabelScale;
        /* 0x12F4 */ public float MaxSpawnTime;
                     [NMS(Size = 0x80)]
        /* 0x12F8 */ public string ResourceParticleFile;
        /* 0x1378 */ public float ResourceParticleSpeed;
        /* 0x137C */ public float ResourceParticleSpread;
        /* 0x1380 */ public int ResourceParticleMaxNum;
        /* 0x1384 */ public int ResourceParticleMinNum;
        /* 0x1388 */ public float MapHeight;
        /* 0x138C */ public float MapOffset;
        /* 0x1390 */ public float MapTargetOffset;
        /* 0x1394 */ public float MapFOV;
        /* 0x1398 */ public float MapRadius;
        /* 0x139C */ public float HUDScaleAdd;
        /* 0x13A0 */ public float HUDScaleRadius;
        /* 0x13A4 */ public float HUDScaleMin;
        /* 0x13A8 */ public float HUDScaleMinAim;
        /* 0x13AC */ public float HUDScaleMax;
        /* 0x13B0 */ public float HUDScaleFarTarget;
        /* 0x13B4 */ public float HUDReticuleMoveBack;
        /* 0x13B8 */ public float HUDReticuleMoveAim;
        /* 0x13BC */ public float MouseSensitivity;
        /* 0x13C0 */ public float MouseSensitivityShip;
        /* 0x13C4 */ public float PainTime;
        /* 0x13C8 */ public TkCurveType PainCurve;
                     [NMS(Size = 0x0C, Ignore = true)]
        /* 0x13CC */ public byte[] Padding13CC;
        /* 0x13D8 */ public Colour PainColour;
        /* 0x13E8 */ public float GunOffsetX;
        /* 0x13EC */ public float GunOffsetY;
        /* 0x13F0 */ public float GunOffsetZ;
        /* 0x13F4 */ public float GunDownAngle;
        /* 0x13F8 */ public float GunUpAngle;
        /* 0x13FC */ public float BarrelOffset;
        /* 0x1400 */ public float HitOffset;
        /* 0x1404 */ public GcTracerData BulletTracer;
        /* 0x141C */ public GcTracerData ShipTracer;
                     [NMS(Size = 0x04, Ignore = true)]
        /* 0x1434 */ public byte[] Padding1434;
                     [NMS(Size = 0x10)]
        /* 0x1438 */ public string DefaultAnim;
        /* 0x1448 */ public bool DebugDrawTriggerBoxes;
                     [NMS(Size = 0x03, Ignore = true)]
        /* 0x1449 */ public byte[] Padding1449;
        /* 0x144C */ public float SpeedReadoutMultiplier;
        /* 0x1450 */ public float SpaceSpeedReadoutMultiplier;
        /* 0x1454 */ public float TorchFoV;
        /* 0x1458 */ public float TorchStrength;
        /* 0x145C */ public float TorchOffsetX;
        /* 0x1460 */ public float TorchOffsetY;
        /* 0x1464 */ public float TorchOffsetZ;
        /* 0x1468 */ public float TorchRotation;
                     [NMS(Size = 0x0C, Ignore = true)]
        /* 0x146C */ public byte[] Padding146C;
        /* 0x1478 */ public Colour TorchColour;
        /* 0x1488 */ public float SimpleInteractionPickupAngle;
        /* 0x148C */ public float SimpleInteractionPickupRadius;
        /* 0x1490 */ public float SimpleInteractionMessageTime;
        /* 0x1494 */ public float InteractionPickupAngle;
        /* 0x1498 */ public float InteractionPickupRadius;
        /* 0x149C */ public float ExplosionRadiusMultiplier;
        /* 0x14A0 */ public float ExplosionForce;
        /* 0x14A4 */ public float ExplosionForceMaxForceRadius;
        /* 0x14A8 */ public float LaserExplosionForceRadius;
        /* 0x14AC */ public float LaserExplosionForce;
        /* 0x14B0 */ public float LaserExplosionForceMaxForceRadius;
                     [NMS(Size = 0x80)]
        /* 0x14B4 */ public string InitialDebrisScene;
        /* 0x1534 */ public float BonusSameTypeElementsAdd;
        /* 0x1538 */ public float BonusSameTypeElementsMultiply;
        /* 0x153C */ public float BonusChildTypeElementsAdd;
        /* 0x1540 */ public float BonusChildTypeElementsMultiply;
        /* 0x1544 */ public float InteractionComponentUpdateDistance;
        /* 0x1548 */ public float GoalGapVoxelDist;
        /* 0x154C */ public float BlackHoleJumpVoxelDist;
        /* 0x1550 */ public float BlackHoleJumpVoxelVariation;
        /* 0x1554 */ public float JumpToCenterFuelCost;
        /* 0x1558 */ public int WarpsBetweenMiniStation;
        /* 0x155C */ public float HoursBetweenMiniStation;
                     [NMS(Size = 0x80)]
        /* 0x1560 */ public string LegacyBaseBuildingTable;
                     [NMS(Size = 0x80)]
        /* 0x15E0 */ public string BaseBuildingTable;
        /* 0x1660 */ public ulong NPCWorkerInteractionCooldown;
        /* 0x1668 */ public float LightStrength;
        /* 0x166C */ public float AirLockDoorRange;
        /* 0x1670 */ public bool KeepAttackingMaxWantedLevel;
        /* 0x1671 */ public bool UseMultiplierBonus;
                     [NMS(Size = 0x02, Ignore = true)]
        /* 0x1672 */ public byte[] Padding1672;
        /* 0x1674 */ public float ShipDisplayDamageMultiplier;
        /* 0x1678 */ public bool UseTradingCostTable;
        /* 0x1679 */ public bool ChangePricesLocally;
        /* 0x167A */ public bool ShowPriceMarkupsAsPercentages;
                     [NMS(Size = 0x01, Ignore = true)]
        /* 0x167B */ public byte[] Padding167B;
        /* 0x167C */ public int ProductItemStockDecayTime;
        /* 0x1680 */ public int ProductItemStockReplenishTime;
        /* 0x1684 */ public int SubstanceItemStockDecayTime;
        /* 0x1688 */ public int SubstanceItemStockReplenishTime;
        /* 0x168C */ public GcPortalData Portal;
        /* 0x1694 */ public int FourthRaceSpawnPercentage;
        /* 0x1698 */ public float ViciousSentinelProbability;
        /* 0x169C */ public float ViciousStormProbability;
        /* 0x16A0 */ public float ViciousWeatherProbability;
        /* 0x16A4 */ public float ScrapDroneProbability;
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
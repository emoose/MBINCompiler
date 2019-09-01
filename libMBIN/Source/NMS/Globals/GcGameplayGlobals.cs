using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x397E231F547EC919)]
    public class GcGameplayGlobals : NMSTemplate
    {
        /* 0x0 */ public float Unknown0x0;
        /* 0x4 */ public float Unknown0x4;
        /* 0x8 */ public float Unknown0x8;
        /* 0xC */ public float Unknown0xC;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string Unknown0x10;
        /* 0x20 */ public float Unknown0x20;
        /* 0x24 */ public float Unknown0x24;
        /* 0x28 */ public float Unknown0x28;
        /* 0x2C */ public float Unknown0x2C;
        /* 0x30 */ public float Unknown0x30;
        /* 0x34 */ public float Unknown0x34;
        /* 0x38 */ public float Unknown0x38;
        /* 0x3C */ public float Unknown0x3C;
        /* 0x40 */ public float Unknown0x40;
        /* 0x44 */ public float Unknown0x44;
        /* 0x48 */ public float Unknown0x48;
        /* 0x4C */ public float Unknown0x4C;
        /* 0x50 */ public float Unknown0x50;
        /* 0x54 */ public float Unknown0x54;
        /* 0x58 */ public float Unknown0x58;
        /* 0x5C */ public float Unknown0x5C;
        /* 0x60 */ public float Unknown0x60;
        /* 0x64 */ public float Unknown0x64;
        /* 0x68 */ public float Unknown0x68;
        /* 0x6C */ public float Unknown0x6C;
        /* 0x70 */ public float Unknown0x70;
        /* 0x74 */ public float Unknown0x74;
        /* 0x78 */ public float Unknown0x78;
        /* 0x7C */ public float Unknown0x7C;
        /* 0x80 */ public float Unknown0x80;
        /* 0x84 */ public float Unknown0x84;
        /* 0x88 */ public float Unknown0x88;
        /* 0x8C */ public float Unknown0x8C;
        /* 0x90 */ public float Unknown0x90;
        /* 0x94 */ public float Unknown0x94;
        /* 0x98 */ public float Unknown0x98;
        /* 0x9C */ public float Unknown0x9C;
        /* 0xA0 */ public float Unknown0xA0;
        /* 0xA4 */ public float Unknown0xA4;
        /* 0xA8 */ public float Unknown0xA8;
        /* 0xAC */ public float Unknown0xAC;
        /* 0xB0 */ public float Unknown0xB0;
        /* 0xB4 */ public float Unknown0xB4;
        /* 0xB8 */ public int UnknownInt0xB8;
        /* 0xBC */ public int UnknownInt0xBC;
        /* 0xC0 */ public bool Unknown0xC0;
        /* 0xC1 */ public bool Unknown0xC1;
        /* 0xC2 */ public bool Unknown0xC2;
        /* 0xC3 */ public bool Unknown0xC3;
        /* 0xC4 */ public bool Unknown0xC4;
        /* 0xC8 */ public float Unknown0xC8;
        /* 0xCC */ public float Unknown0xCC;
        /* 0xD0 */ public float Unknown0xD0;
        /* 0xD4 */ public float Unknown0xD4;
        /* 0xD8 */ public float Unknown0xD8;
        /* 0xDC */ public float Unknown0xDC;
        /* 0xE0 */ public float Unknown0xE0;
        /* 0xE4 */ public float Unknown0xE4;
        /* 0xE8 */ public float Unknown0xE8;
        /* 0xEC */ public float Unknown0xEC;
        /* 0xF0 */ public float Unknown0xF0;
        /* 0xF4 */ public float Unknown0xF4;
        /* 0xF8 */ public int UnknownInt0xF8;
        /* 0xFC */ public int UnknownInt0xFC;
        /* 0x100 */ public bool Unknown0x100;
        /* 0x104 */ public float Unknown0x104;
        /* 0x108 */ public float Unknown0x108;
        /* 0x10C */ public float Unknown0x10C;
        /* 0x110 */ public float Unknown0x110;
        /* 0x114 */ public float Unknown0x114;
        /* 0x118 */ public float Unknown0x118;
        /* 0x11C */ public float Unknown0x11C;
        /* 0x120 */ public float Unknown0x120;
        /* 0x124 */ public float Unknown0x124;
        /* 0x128 */ public float Unknown0x128;
        /* 0x12C */ public float Unknown0x12C;
        /* 0x130 */ public float Unknown0x130;
        /* 0x134 */ public float Unknown0x134;
        /* 0x138 */ public float Unknown0x138;
        /* 0x13C */ public float Unknown0x13C;
        /* 0x140 */ public int UnknownInt0x140;
        /* 0x144 */ public int UnknownInt0x144;
        /* 0x148 */ public int UnknownInt0x148;
        /* 0x14C */ public int UnknownInt0x14C;
        /* 0x150 */ public int UnknownInt0x150;
        /* 0x154 */ public int UnknownInt0x154;
        [NMS(Size = 0x03)]
        /* 0x0158 */ public NMSString0x10[] HyperdriveAccess;
        [NMS(Size = 0x03)]
        /* 0x0188 */ public NMSString0x10[] FreighterHyperdriveAccess;
        /* 0x01B8 */ public float Unknown0x1B8;
        /* 0x01BC */ public float Unknown0x1BC;
        /* 0x01C0 */ public float Unknown0x1C0;
        /* 0x01C4 */ public bool AllowPreInstallTechnologies; // Set to False to revert to legacy method of installing technologies and upgrades
        /* 0x01C8 */ public bool FreighterRequiresRGBHyperdriveUpgrades;
        /* 0x01C9 */ public bool AllowTeleportItemsToFreighter;
        /* 0x01CA */ public bool DisableAnomalyAmbientSpawn;
        /* 0x01CB */ public bool AllowDeconstruct;
        /* 0x01CC */ public bool AllowBinocularMarker;
        /* 0x01CD */ public bool EveryMaintenanceIsBroken;
        /* 0x01CE */ public bool SpawnResourceBlobsOnPartDelete;
        /* 0x01CF */ public bool EnableShootHitEffect;
        /* 0x01D0 */ public int MaxNumSameGroupTech;
        /* 0x01D4 */ public float ShootableArmourHighlightHitTime;
        /* 0x01D8 */ public float ShootableAggroMinStartTime;
        /* 0x01DC */ public float ShootableAggroForgetTime;
        /* 0x01E0 */ public Colour RefinerColour1A;
        /* 0x01F0 */ public Colour RefinerColour1B;
        /* 0x0200 */ public Colour RefinerColour1C;
        /* 0x0210 */ public Colour RefinerColour1D;
        /* 0x0220 */ public float AtmosphereEntryTime;
        /* 0x0224 */ public float AtmosphereEntryFadeTimeFactor;
        /* 0x0228 */ public float AtmosphereEntryOffset;
        /* 0x022C */ public TkCurveType AtmosphereEntryCurve;
        /* 0x0230 */ public float TerrainResourceScanTime;
        /* 0x0234 */ public float TerrainResourceScanRange;
        /* 0x0238 */ public float Unknown0x238;
        /* 0x023C */ public bool BinocsDisplayUnknownCreatures;
        /* 0x0240 */ public float BinocularScanTargetMinHeight;
        /* 0x0244 */ public float BinocularScanTargetHeightRange;
        /* 0x0248 */ public float BinocTimeBeforeScan;
        /* 0x024C */ public float BinocMinScanTime;
        /* 0x0250 */ public float BinocScanTime;
        /* 0x0254 */ public float BinocCreatureScanTime;
        /* 0x0258 */ public TkCurveType BinocularScanTargetHeightCurve;
        /* 0x025C */ public float BinocularScanTargetInitialFadeTime;
        /* 0x0260 */ public float BinocularScanTargetScaler;
        /* 0x0264 */ public float BinocularScanTargetLineWidth;
        /* 0x0268 */ public float BinocularScanTargetFadeTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x026C */ public byte[] Padding268;
        /* 0x0270 */ public Colour BinocularScanTargetColour;
        /* 0x0280 */ public GcScanEffectData BinocularScanEffect;
        /* 0x02D0 */ public float ScannerIconsClumpRadius;
        /* 0x02D4 */ public float ScannableComponentMarkerOffset;
        /* 0x02D8 */ public float ScannableComponentPlaceMarkerOffset;
        /* 0x02DC */ public float MissionEventAllowResetDistance;
        /* 0x02E0 */ public float AllRecipesKnownNanitesMin;
        /* 0x02E4 */ public float AllRecipesKnownNanitesMax;
        /* 0x02E8 */ public float MaxPossibleShipDamagePotential;
        /* 0x02EC */ public float BuildingPlayerBaseIconOffset;
        /* 0x02F0 */ public float CriticalHitMultiplier;
        /* 0x02F4 */ public float HitEffectMinTime;
        /* 0x02F8 */ public float GrabPlayerCooldownTime;
        /* 0x02FC */ public float TapInteractionIncreaseAmount;
        /* 0x0300 */ public float TapInteractionDecay;
        [NMS(Size = 0x0C, Ignore = true)]
        /* 0x0304 */ public byte[] Padding304;
        /* 0x0310 */ public GcScanEffectData DeconstructEffect;
        /* 0x0360 */ public GcScanEffectData HitEffect;
        /* 0x03B0 */ public GcScanEffectData HitEffectCritical;
        /* 0x0400 */ public float CommunicatorSpawnOffset;
        /* 0x0404 */ public float CommunicatorSpawnHeightOffset;
        [NMS(Size = 0x08, Ignore = true)]
        /* 0x0408 */ public byte[] Padding408;
        /* 0x0410 */ public Vector4f CommunicatorShipSpawnOffset;
        /* 0x0420 */ public float CommunicatorSpawnScale;
        /* 0x0424 */ public float CommunicatorSpawnRotation;
        /* 0x0428 */ public float CommunicatorFadeTime;
        [NMS(Size = 0x04, Ignore = true)]
        /* 0x042C */ public byte[] Padding42C;
        [NMS(Size = 0x02)]
        /* 0x0430 */ public GcScanEffectData[] CommunicatorEffectTable;
        /* 0x04D0 */ public int MaxNumMissionsFromMissionGiver;
        /* 0x04D4 */ public float InteractionMessageModuleDisplayTime;
        /* 0x04D8 */ public float InteractionAttractTime;
        /* 0x04DC */ public float InteractionDescriptionTextTime;
        /* 0x04E0 */ public float InteractionMinTimeForResponseText;
        /* 0x04E4 */ public bool InteractionOverride;
        [NMS(Size = 0x03, Ignore = true)]
        /* 0x04E5 */ public byte[] Padding4E5;
        /* 0x04E8 */ public GcInteractionType InteractionOverrideFrom;
        /* 0x04EC */ public GcInteractionType InteractionOverrideTo;
        /* 0x04F0 */ public float DestroyEffectHeight;
        /* 0x04F4 */ public float DestroyEffectMaxScale;
        /* 0x04F8 */ public float EventTargetSpeed;
        /* 0x04FC */ public int SpecialMiningAmount;
        /* 0x0500 */ public float SpecialMiningTime;
        /* 0x0504 */ public int HardModeTechDamageMidNum;
        /* 0x0508 */ public int HardModeTechDamageMidPercent;
        /* 0x050C */ public int HardModeTechDamageHighPercent;
        /* 0x0510 */ public int UnknownInt0x510;
        /* 0x0514 */ public int PirateInterestOverride;
        /* 0x0518 */ public float PirateInterestDistance;
        [NMS(Size = 0x06)]
        /* 0x051C */ public int[] PirateInterestLevels;     // maybe 2 separate int[0x3]'s?
        /* 0x0534 */ public float SpaceCombatRadius;
        /* 0x0538 */ public int WarpsBetweenBattles;
        /* 0x053C */ public float HoursBetweenBattles;
        /* 0x0540 */ public float SpaceBattleRadius;
        /* 0x0544 */ public float SpaceBattleAnyHostileShipsRadius;
        /* 0x0548 */ public float FreighterBattleRadius;
        /* 0x054C */ public float MissileMaxTurnAngle;
        /* 0x0550 */ public float MissileLockTime;
        /* 0x0554 */ public float MissileReloadTime;
        /* 0x0558 */ public float MissileRotateMin;
        /* 0x055C */ public float MissileRotateMax;
        /* 0x0560 */ public float MissileMaxSpeed;
        /* 0x0564 */ public float MissileForceMin;
        /* 0x0568 */ public float MissileForceMax;
        /* 0x056C */ public float MissileBrakeForceMin;
        /* 0x0570 */ public float MissileBrakeForceMax;
        /* 0x0574 */ public float MissileThreatTime;
        /* 0x0578 */ public float MissileBrakeTime;
        /* 0x057C */ public float MissileHitRadius;
        /* 0x0580 */ public float MissileOffset;
        /* 0x0584 */ public float MissileMinCircleTime;
        /* 0x0588 */ public float MissileApproachTime;
        /* 0x058C */ public float MissileRotateSpeed;
        /* 0x0590 */ public float ScanStartTimeDelayMinDist;
        /* 0x0594 */ public float ScanStartTimeDelayRange;
        /* 0x0598 */ public float ScanStartTimeDistanceDelayTime;
        /* 0x059C */ public float ScanStickyDecay;
        /* 0x05A0 */ public float CreatureScanStickyDecay;
        /* 0x05A4 */ public float CreatureScanAngle;
        /* 0x05A8 */ public float CreatureMinScanTime;
        /* 0x05AC */ public float ScanAngle;
        /* 0x05B0 */ public float NewDiscoveryDisplayTime;
        /* 0x05B4 */ public bool FailToFindBuildings;
        /* 0x05B8 */ public int CritDamage;
        /* 0x05BC */ public float CritScale;
        /* 0x05C0 */ public int NumMissionsPerSolarSystem;
        /* 0x05C4 */ public float EmergencyBuildingScanEventDistance;
        /* 0x05C8 */ public float EmergencyBuildingScanEventTime;
        /* 0x05CC */ public float ProjectileLightIntensity;
        /* 0x05D0 */ public float AggressiveSentinelProbability;
        /* 0x05D4 */ public float Unknown0x5D4;
        /* 0x05D8 */ public float Unknown0x5D8;
        /* 0x05DC */ public float Unknown0x5DC;
        /* 0x05E0 */ public float Unknown0x5E0;
        /* 0x05E4 */ public int UnknownInt0x5E4;
        /* 0x05E8 */ public int UnknownInt0x5E8;
        /* 0x05EC */ public int UnknownInt0x5EC;
        /* 0x05F0 */ public int UnknownInt0x5F0;
        /* 0x05F4 */ public int UnknownInt0x5F4;
        /* 0x05F8 */ public int UnknownInt0x5F8;
        /* 0x05FC */ public GcExperienceTimers Unknown0x5FC;
        /* 0x061C */ public GcExperienceTimers Unknown0x61C;
        /* 0x063C */ public GcExperienceTimers Unknown0x63C;
        /* 0x065C */ public int FreighterStartPecent;
        /* 0x0660 */ public GcExperienceTimers FreighterTimers;
        /* 0x0680 */ public GcExperienceTimers PirateTimers;
        /* 0x06A0 */ public GcExperienceTimers HardPirateTimers;
        [NMS(Size = 0x03)]
        /* 0x06C0 */ public float[] PirateEarlySpawnChances;
        /* 0x06CC */ public float PirateEarlySpawnTime;
        /* 0x06D0 */ public GcExperienceTimers FlybyTimers;
        /* 0x06F0 */ public GcExperienceTimers SpaceFlybyTimers;
        /* 0x0710 */ public int SentinelsHigh;
        /* 0x0714 */ public int SentinelsLow;
        /* 0x0718 */ public float AsteroidHitForce;
        /* 0x071C */ public float AsteroidTorqueForce;
        /* 0x0720 */ public float AsteroidCarveRadius;
        /* 0x0724 */ public int DeathMoneyPenalty;
        /* 0x0728 */ public int DeathMoneyPenaltyHardMode;
        /* 0x072C */ public int MaxResourceCrystalBlobSize;
        /* 0x0730 */ public float BuildingBeamDistance;
        /* 0x0734 */ public float WaypointScanTime;
        /* 0x0738 */ public int RareSubstanceEffectiveness;
        /* 0x073C */ public int CommonProductEffectiveness;
        /* 0x0740 */ public int RareProductEffectiveness;
        /* 0x0744 */ public int AsteroidResourceReducer;
        /* 0x0748 */ public float VoxelAsteroidResourceChance;
        /* 0x074C */ public int ResourceReducer;
        /* 0x0750 */ public int ResourceMinAmount;
        /* 0x0754 */ public int ResourceMaxAmount;
        /* 0x0758 */ public int ResourceCommonReducer;
        /* 0x075C */ public int ResourceCommonMinAmount;
        /* 0x0760 */ public int ResourceCommonMaxAmount;
        // I assume these have something to do with the mining of the ground...
        /* 0x0764 */ public int UnknownInt0x764;            // ResourceGroundReducer
        /* 0x0768 */ public int UnknownInt0x768;            // ResourceGroundMin
        /* 0x076C */ public int UnknownInt0x76C;            // ResourceGroundMax
        [NMS(Size = 0x10)]
        /* 0x0770 */ public string GroundResource;      // just guessing from the data
        [NMS(Size = 0x20)]
        /* 0x0780 */ public string RobotResource;
        [NMS(Size = 0x20)]
        /* 0x07A0 */ public string DepotResource;
        /* 0x07C0 */ public float DockNodeBuyRadius;
        /* 0x07C4 */ public float BeaconInteractRange;
        /* 0x07C8 */ public float ShipInteractRadius;
        /* 0x07CC */ public GcResourceCollectEffect AsteroidResourceCollect;
        /* 0x0800 */ public float ScanAngleCutoff;
        /* 0x0804 */ public GcScanData ToolScan;
        /* 0x0818 */ public GcScanData ToolScanHardMode;
        /* 0x082C */ public GcScanData WaypointScan;
        /* 0x0840 */ public GcScanData BeaconScan;
        /* 0x0854 */ public GcScanData RadioTowerScan;
        /* 0x0868 */ public GcScanData ObservatoryScan;
        /* 0x087C */ public GcScanData DistressSignalScan;
        /* 0x0890 */ public GcScanData DebugScanPlanet;
        /* 0x08A4 */ public GcScanData DebugScanSpace;
        /* 0x08B8 */ public GcScanData ShipScan;
        /* 0x08CC */ public GcScanData VisualScan;
        /* 0x08E0 */ public float ZoomFindBuildingRange;
        /* 0x08E4 */ public float TimeToDisplayScanResults;
        /* 0x08E8 */ public float HoverTimeToScan;
        /* 0x08FC */ public float HoverTimeToScanCreatures;
        /* 0x08F0 */ public int HoverVisiblePointsNeeded;
        [NMS(Size = 0x04)]
        /* 0x08F4 */ public GcZoomData[] ZoomLevels;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x0964 */ public byte[] Padding964;
        /* 0x0970 */ public GcScanEffectData PassiveScanEffect;
        /* 0x09C0 */ public GcScanEffectData BuildingScanEffect;
        /* 0x0A10 */ public GcScanEffectData TargetShipScanEffect;
        /* 0x0A60 */ public GcScanEffectData HUDShipScanEffect;
        /* 0x0AB0 */ public GcScanEffectData CreatureScanEffect;
        /* 0x0B00 */ public GcScanEffectData ObjectsScanEffect;
        /* 0x0B50 */ public GcScanEffectData BaseBuildingScanEffect;
        /* 0x0BA0 */ public GcScanEffectData BaseBuildingBlockedScanEffect;
        /* 0x0BF0 */ public GcScanEffectData BaseBuildingFreighterScanEffect;
        /* 0x0C40 */ public GcScanEffectData BaseBuildingFreighterBlockedScanEffect;
        /* 0x0C90 */ public GcScanEffectData BaseBuildingSelectionScanEffect;
        /* 0x0CE0 */ public GcScanEffectData BaseBuildingRemotePlayerScanEffect;
        /* 0x0D30 */ public GcScanEffectData BaseBuildingRemotePlayerBlockedScanEffect;
        /* 0x0D80 */ public GcScanEffectData BaseBuildingRemotePlayerFreighterScanEffect;
        /* 0x0DD0 */ public GcScanEffectData BaseBuildingRemotePlayerFreighterBlockedScanEffect;
        /* 0x0E20 */ public GcScanEffectData BaseBuildingRemotePlayerSelectionScanEffect;
        /* 0x0E70 */ public GcScanEffectData Unknown0xE70;              // some of these unknowns *may* be one of the above unknowns but swapped places...
        /* 0x0EC0 */ public GcScanEffectData Unknown0xEC0;
        /* 0x0F10 */ public GcScanEffectData Unknown0xF10;
        /* 0x0F60 */ public GcScanEffectData Unknown0xF60;
        /* 0x0FB0 */ public GcScanEffectData Unknown0xFB0;
        /* 0x1000 */ public float Unknown0x1000;
        /* 0x1004 */ public bool UseDebugScan;
        /* 0x1005 */ public bool DebugScanForceBuilding;
        [NMS(Size = 0x02, Ignore = true)]
        /* 0x1006 */ public byte[] Padding1006;
        /* 0x1008 */ public GcBuildingClassification DebugScanForceBuildingType;
        /* 0x100C */ public float ShipScanOffset;
        /* 0x1010 */ public float ShipScanOffsetGap;
        /* 0x1014 */ public TkCurveType ShipScanCurve;
        /* 0x1018 */ public float ScannerMarkerFadeTime;
        /* 0x101C */ public float ScannerSmallMarkerFadeTime;
        /* 0x1020 */ public float ScannerPhysicsProbeAABBSize;
        /* 0x1024 */ public float ScannerAnalyzeFXRate;
        /* 0x1028 */ public float ScannerSubstanceTimePerTrigger;
        /* 0x102C */ public float ScannerTuningA;
        /* 0x1030 */ public float ScannerTuningB;
        /* 0x1034 */ public float ScannerTuningC;
        /* 0x1038 */ public float ScannerTuningD;
        /* 0x103C */ public float ScannerTuningResourceOffset1;
        /* 0x1040 */ public float ScannerTuningResourceOffset2;
        /* 0x1044 */ public float ScannerTuningSmoothStepAmount;
        /* 0x1048 */ public float ScannerTuningTrailingEdge;
        /* 0x104C */ public bool Autolevel;
        [NMS(Size = 0x03, Ignore = true)]
        /* 0x104D */ public byte[] Padding104D;
        /* 0x1050 */ public Colour ScannerColour1;
        /* 0x1060 */ public Colour ScannerColour2;
        /* 0x1070 */ public float HUDStoreFlashTime;
        /* 0x1074 */ public float ExcitingViewAngle;
        /* 0x1078 */ public float ExcitingViewRange;
        /* 0x107C */ public float ExcitingNearRange;
        /* 0x1080 */ public float ProjectileSpeedBoost;
        /* 0x1084 */ public float LineWidth;
        /* 0x1088 */ public float LockOffFactor;
        /* 0x108C */ public float OffscreenFadeDistance;
        /* 0x1090 */ public float OffscreenMinDot;
        /* 0x1094 */ public bool HUDUpdateFromData;
        /* 0x1098 */ public float HUDLockOnAudioTime;
        /* 0x109C */ public float HUDArrowPrimaryScaler;
        /* 0x10A0 */ public Vector2f HUDDamageSize;
        /* 0x10A8 */ public Vector2f HUDDamageSplatSize;
        /* 0x10B0 */ public Colour HUDDamageSplatShieldColour;
        /* 0x10C0 */ public Colour HUDDamageSplatPainColour;
        /* 0x10D0 */ public float HUDDamageOffset;
        /* 0x10D4 */ public float HUDDamageScaler;
        /* 0x10D8 */ public float HUDDamageRadius;
        [NMS(Size = 0x04, Ignore = true)]
        /* 0x10DC */ public byte[] Padding10DC;
        /* 0x10E0 */ public GcShipHUDTargetData HUDTarget;
        /* 0x1510 */ public float HUDLabelTime;
        /* 0x1514 */ public float HUDLabelAngle;
        /* 0x1518 */ public float HUDLabelAngleOffset;
        /* 0x151C */ public float HUDLabelOffsetX;
        /* 0x1520 */ public float HUDLabelOffsetY;
        /* 0x1524 */ public float HUDLabelOffsetZ;
        /* 0x1528 */ public float HUDLabelScale;
        /* 0x152C */ public float MaxSpawnTime;
        [NMS(Size = 0x80)]
        /* 0x1530 */ public string ResourceParticleFile;
        /* 0x15B0 */ public float ResourceParticleSpeed;
        /* 0x15B4 */ public float ResourceParticleSpread;
        /* 0x15B8 */ public int ResourceParticleMaxNum;
        /* 0x15BC */ public int ResourceParticleMinNum;
        /* 0x15C0 */ public float MapHeight;
        /* 0x15C4 */ public float MapOffset;
        /* 0x15C8 */ public float MapTargetOffset;
        /* 0x15CC */ public float MapFOV;
        /* 0x15D0 */ public float MapRadius;
        /* 0x15D4 */ public float HUDScaleAdd;
        /* 0x15D8 */ public float HUDScaleRadius;
        /* 0x15DC */ public float HUDScaleMin;
        /* 0x15E0 */ public float HUDScaleMinAim;
        /* 0x15E4 */ public float HUDScaleMax;
        /* 0x15E8 */ public float HUDScaleFarTarget;
        /* 0x15EC */ public float HUDReticuleMoveBack;
        /* 0x15F0 */ public float HUDReticuleMoveAim;
        /* 0x15F4 */ public float MouseSensitivity;
        /* 0x15F8 */ public float MouseSensitivityShip;
        /* 0x15FC */ public float PainTime;
        /* 0x1600 */ public TkCurveType PainCurve;
        [NMS(Size = 0x0C, Ignore = true)]
        /* 0x1604 */ public byte[] Padding1604;
        /* 0x1610 */ public Colour PainColour;
        /* 0x1620 */ public float GunOffsetX;
        /* 0x1624 */ public float GunOffsetY;
        /* 0x1628 */ public float GunOffsetZ;
        /* 0x162C */ public float GunDownAngle;
        /* 0x1630 */ public float GunUpAngle;
        /* 0x1634 */ public float BarrelOffset;
        /* 0x1638 */ public float HitOffset;
        /* 0x163C */ public GcTracerData BulletTracer;
        /* 0x1654 */ public GcTracerData ShipTracer;
         [NMS(Size = 0x04, Ignore = true)]
        /* 0x166C */ public byte[] Padding166C;
        [NMS(Size = 0x10)]
        /* 0x1670 */ public string DefaultAnim;
        /* 0x1680 */ public bool DebugDrawTriggerBoxes;
        /* 0x1684 */ public float SpeedReadoutMultiplier;
        /* 0x1688 */ public float SpaceSpeedReadoutMultiplier;
        /* 0x168C */ public float TorchFoV;
        /* 0x1690 */ public float TorchStrength;
        /* 0x1694 */ public float TorchOffsetX;
        /* 0x1698 */ public float TorchOffsetY;
        /* 0x169C */ public float TorchOffsetZ;
        /* 0x16A0 */ public float TorchRotation;
        /* 0x16A4 */ public float Unknown0x16A4;
        /* 0x16A8 */ public float Unknown0x16A8;
        /* 0x16AC */ public bool Unknown0x16AC;
        /* 0x16B0 */ public float Unknown0x16B0;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x16B4 */ public byte[] Padding16B4;
        /* 0x16C0 */ public Colour TorchColour;
        /* 0x16D0 */ public float SimpleInteractionPickupAngle;
        /* 0x16D4 */ public float SimpleInteractionPickupRadius;
        /* 0x16D8 */ public float SimpleInteractionMessageTime;
        /* 0x16DC */ public float InteractionPickupAngle;
        /* 0x16E0 */ public float InteractionPickupRadius;
        /* 0x16E4 */ public float ExplosionRadiusMultiplier;
        /* 0x16E8 */ public float ExplosionForce;
        /* 0x16EC */ public float ExplosionForceMaxForceRadius;
        /* 0x16F0 */ public float LaserExplosionForceRadius;
        /* 0x16F4 */ public float LaserExplosionForce;
        /* 0x16F8 */ public float LaserExplosionForceMaxForceRadius;
        [NMS(Size = 0x80)]
        /* 0x16FC */ public string InitialDebrisScene;
        /* 0x177C */ public float BonusSameTypeElementsAdd;
        /* 0x1780 */ public float BonusSameTypeElementsMultiply;
        /* 0x1784 */ public float BonusChildTypeElementsAdd;
        /* 0x1788 */ public float BonusChildTypeElementsMultiply;
        /* 0x178C */ public float InteractionComponentUpdateDistance;
        /* 0x1790 */ public float GoalGapVoxelDist;
        /* 0x1794 */ public float BlackHoleJumpVoxelDist;
        /* 0x1798 */ public float BlackHoleJumpVoxelVariation;
        /* 0x179C */ public float JumpToCenterFuelCost;
        /* 0x17A0 */ public int WarpsBetweenMiniStation;
        /* 0x17A4 */ public float HoursBetweenMiniStation;
        [NMS(Size = 0x80)]
        /* 0x17A8 */ public string LegacyBaseBuildingTable;
        [NMS(Size = 0x80)]
        /* 0x1828 */ public string BaseBuildingTable;
        /* 0x18A8 */ public ulong NPCWorkerInteractionCooldown;
        /* 0x18B0 */ public float LightStrength;
        /* 0x18B4 */ public float AirLockDoorRange;
        /* 0x18B8 */ public bool Unknown0x18B8;                     // this value may be swapped with next value?
        /* 0x18B9 */ public bool KeepAttackingMaxWantedLevel;
        /* 0x18BA */ public bool UseMultiplierBonus;
        /* 0x18BC */ public float ShipDisplayDamageMultiplier;
        /* 0x18C0 */ public bool UseTradingCostTable;
        /* 0x18C1 */ public bool ChangePricesLocally;
        /* 0x18C2 */ public bool ShowPriceMarkupsAsPercentages;
        /* 0x18C4 */ public int ProductItemStockDecayTime;
        /* 0x18C8 */ public int ProductItemStockReplenishTime;
        /* 0x18CC */ public int SubstanceItemStockDecayTime;
        /* 0x18D0 */ public int SubstanceItemStockReplenishTime;
        /* 0x18D4 */ public GcPortalData Portal;
        /* 0x18DC */ public int FourthRaceSpawnPercentage;
        /* 0x18E0 */ public int UnknownInt0x18E0;
        /* 0x18E4 */ public float ViciousSentinelProbability;
        /* 0x18E8 */ public float ViciousStormProbability;
        /* 0x18EC */ public float ViciousWeatherProbability;
        /* 0x18F0 */ public float ScrapDroneProbability;
        /* 0x18F4 */ public float Unknown0x18F4;
        /* 0x18F8 */ public float Unknown0x18F8;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x18FC */ public byte[] EndPadding;
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

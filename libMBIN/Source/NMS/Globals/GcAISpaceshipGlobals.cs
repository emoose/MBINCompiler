using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x8B75D87FAF5635A5, NameHash = 0xD338272248F67908)]
    public class GcAISpaceshipGlobals : NMSTemplate
    {
        /* 0x000 */ public GcPlayerSquadronConfig PlayerSquadronConfig;
        /* 0x240 */ public Colour FreighterEngineGlowDefaultColour;
        /* 0x250 */ public float PoliceFreighterLaserRange;
        /* 0x254 */ public float PoliceFreighterLaserShootTime;
        /* 0x258 */ public float PoliceFreighterLaserRandomExtraPauseMax;
        /* 0x25C */ public float PoliceFreighterLaserActiveTime;
        /* 0x260 */ public float PoliceFreighterProjectileRange;
        /* 0x264 */ public int PoliceFreighterProjectileBurstCount;
        /* 0x268 */ public float PoliceFreighterProjectileBurstTime;
        /* 0x26C */ public float PoliceFreighterProjectilePauseTime;
        /* 0x270 */ public float PoliceFreighterProjectileRandomExtraPauseMax;
        /* 0x274 */ public int PoliceFreighterProjectileModulo;
        /* 0x278 */ public bool DisplayShipAttackTypes;
        /* 0x27C */ public float MaxDifficultySpaceCombatTurnExtra;
        /* 0x280 */ public float MaxDifficultySpaceCombatSpeedExtra;
        /* 0x284 */ public float MinimumCircleTimeBeforeLanding;
        /* 0x288 */ public float MinimumTimeBetweenOutpostLandings;
        /* 0x28C */ public float VisibleDistance;
        /* 0x290 */ public bool TradersAttackPirates;
        /* 0x291 */ public bool FreightersAlwaysAttackPlayer;
        /* 0x292 */ public bool GroundEffectEnabled;
        /* 0x293 */ public bool AtmosphereEffectEnabled;
        /* 0x294 */ public bool FillUpOutposts;
        /* 0x298 */ public float SalvageTime;
        /* 0x29C */ public float SalvageRemovalTime;
        /* 0x2A0 */ public float SalvageValueMultiplier;
        /* 0x2A4 */ public float DockingWaitDistance;
        /* 0x2A8 */ public int MaxNumActiveTraders;
        /* 0x2AC */ public float MaxNumActiveTraderRadius;
        /* 0x2B0 */ public int MaxNumActivePolice;
        /* 0x2B4 */ public float MaxNumActivePoliceRadius;
        /* 0x2B8 */ public int MinAggroDamage;
        /* 0x2BC */ public float TrailLandingFadeTime;
        /* 0x2C0 */ public bool EnergyShieldsEnabled;
        /* 0x2C1 */ public NMSString0x80 EnergyShield;
        /* 0x348 */ public NMSString0x10 EnergyShieldDepletedEffect;
        /* 0x358 */ public NMSString0x10 EnergyShieldStartRechargeEffect;
        /* 0x368 */ public NMSString0x10 EnergyShieldStartRechargeFromDepletedEffect;
        /* 0x378 */ public bool EnergyShieldAlwaysVisible;
        /* 0x37C */ public float EnergyShieldFadeMinOpacityInCombat;
        /* 0x380 */ public float EnergyShieldFadeNonPlayerHitOpacity;
        /* 0x384 */ public float EnergyShieldFadeInRate;
        /* 0x388 */ public float EnergyShieldFadeOutRate;
        /* 0x38C */ public float MinLaserFireTime;
        /* 0x390 */ public float ShipAlertPirateRange;
        /* 0x394 */ public float PlanetaryPirateHostileShipPerceptionRange;
        /* 0x398 */ public float PlanetaryPirateRaidFocusBuildingsTime;
        /* 0x39C */ public float PlanetaryPirateRaidTradersEngageTime;
        /* 0x3A0 */ public int PlanetaryPirateRaidMaxTradersJoinCombat;
        /* 0x3A4 */ public float EscapeRollTimePlanet;
        /* 0x3A8 */ public float EscapeRollTime;
        /* 0x3AC */ public float EscapeRollPlanet;
        /* 0x3B0 */ public float EscapeRoll;
        /* 0x3B4 */ public int CrashedShipMinNonBrokenSlots;
        /* 0x3B8 */ public float SentinelGunBrokenSlotChance;
        /* 0x3BC */ public float CrashedShipBrokenSlotChance;
        /* 0x3C0 */ public float CrashedShipBrokenTechChance;
        /* 0x3C4 */ public float CrashedShipRepairSlotCostIncreaseFactor;
        /* 0x3C8 */ public float CrashedShipGeneralCostDiscount;
        /* 0x3CC */ public float CrashedShipTechSlotsCostDiscount;
        /* 0x3D0 */ public float PirateSpawnSpacing;
        /* 0x3D4 */ public float DistanceFlareMinDistance;
        /* 0x3D8 */ public float DistanceFlareRange;
        /* 0x3DC */ public float DistanceFlareMinScale;
        /* 0x3E0 */ public float DistanceFlareMaxScale;
        /* 0x3E4 */ public float DistanceFlareMinSpeed;
        /* 0x3E8 */ public float DistanceFlareSpeedRange;
        /* 0x3EC */ public float DistanceFlareFlickerFreq;
        /* 0x3F0 */ public float DistanceFlareFlickerAmp;
        /* 0x3F4 */ public bool AttackRepositionBoost;
        /* 0x3F5 */ public bool AttackShipsFollowLeader;
        /* 0x3F8 */ public float AttackTooCloseMinRelSpeed;
        [NMS(Size = 0x7, EnumType = typeof(GcAISpaceshipTypes.ShipTypeEnum))]
        /* 0x400 */ public NMSString0x10[] ProjectileWeaponMuzzleFlashes;
        /* 0x470 */ public float RewardLootOffset;
        /* 0x474 */ public float RewardLootOffsetSpeed;
        /* 0x478 */ public float RewardLootAngularSpeed;
        /* 0x47C */ public float FlybyPlanetLandingProbability;
        /* 0x480 */ public GcCombatEffectsComponentData CombatEffectsComponentData;
        /* 0x4B0 */ public GcSpaceshipTravelData FallbackTravelData;
        /* 0x4F8 */ public GcSpaceshipTravelData SlowCombatEffectAttackTravel;
        /* 0x540 */ public GcSpaceshipTravelData AsteroidMiningPositioningTravelData;
        /* 0x588 */ public GcSpaceshipTravelData AsteroidMiningTravelData;
        /* 0x5D0 */ public float AsteroidMiningSearchRadius;
        /* 0x5D4 */ public float AsteroidMiningMaxAsteroidRadius;
        /* 0x5D8 */ public float AsteroidMiningMaxViewAngleYaw;
        /* 0x5DC */ public float AsteroidMiningMinViewAnglePitch;
        /* 0x5E0 */ public float AsteroidMiningMaxViewAnglePitch;
        /* 0x5E4 */ public float AsteroidMiningMinDistFromPlayer;
        /* 0x5E8 */ public float AsteroidMiningMinMiningAngle;
        /* 0x5EC */ public float AsteroidMiningMaxMiningTime;
        /* 0x5F0 */ public float AttackShipAvoidStartTime;
        /* 0x5F4 */ public float AttackMinimumTimeBeforeTargetSwitch;
        /* 0x5F8 */ public float PirateExtraDamage;
        [NMS(Size = 0x36, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x5FC */ public bool[] PirateAttackableBuildingClasses;
        /* 0x634 */ public float PirateMaintainBuildingTargetTime;
        /* 0x638 */ public float ShieldCollisionRadiusMultiplier;
        /* 0x63C */ public float CollisionRayLengthMin;
        /* 0x640 */ public float CollisionRayLengthMax;
        /* 0x648 */ public GcSpaceshipTravelData OutpostLanding;
        /* 0x690 */ public GcSpaceshipTravelData PlanetLanding;
        /* 0x6D8 */ public float OutpostLandingNoiseFreq;
        /* 0x6DC */ public float OutpostLandingNoiseAmp;
        /* 0x6E0 */ public float OutpostLandingNoiseOffset;
        /* 0x6E4 */ public float OutpostDockUpAlignMaxAngleFirstPerson;
        /* 0x6E8 */ public float OutpostDockUpAlignMaxAngle;
        /* 0x6EC */ public float OutpostDockMaxApproachSpeed;
        /* 0x6F0 */ public float OutpostDockOverspeedBrake;
        /* 0x6F4 */ public float OutpostDockGetToApproachForce;
        /* 0x6F8 */ public float OutpostDockGetToApproachBrakeForce;
        /* 0x6FC */ public float OutpostDockGetToApproachExtraBrakeForce;
        /* 0x700 */ public float OutpostDockApproachSpeedForce;
        /* 0x704 */ public float OutpostDockApproachDistance;
        /* 0x708 */ public float OutpostDockApproachSpeedUpDamper;
        /* 0x70C */ public float OutpostDockAIGetToApproachForce;
        /* 0x710 */ public float OutpostDockAIGetToApproachBrakeForce;
        /* 0x714 */ public float OutpostDockAIApproachSpeedForce;
        /* 0x718 */ public float OutpostDockMaxForce;
        /* 0x71C */ public float OutpostDockMinTipLength;
        /* 0x720 */ public float OutpostDockMaxTipLength;
        /* 0x724 */ public float OutpostDockApproachUpAmount;
        /* 0x728 */ public float OutpostDockApproachRenderRadius;
        /* 0x72C */ public float OutpostDockApproachRenderFlickerOffset;
        /* 0x730 */ public float LandingTipAngle;
        /* 0x734 */ public float LandingLongTipAngle;
        /* 0x738 */ public Vector2f SpaceBattleSpawnAngle;
        /* 0x740 */ public Vector2f SpaceBattleSpawnPitch;
        /* 0x748 */ public Vector2f SpaceBattleSpawnOffset;
        /* 0x750 */ public Vector2f SpaceBattleSunHeightAngle;
        /* 0x758 */ public Vector2f SpaceBattleSunAroundAngle;
        /* 0x760 */ public List<Vector2f> SpaceBattleSpawnRange;
        /* 0x770 */ public List<Vector2f> SpaceBattlePirateRange;
        /* 0x780 */ public List<Vector2f> SpaceBattleGuardsRange;
        /* 0x790 */ public float SpaceBattleGuardOffset;
        /* 0x794 */ public float SpaceBattleGuardUpOffset;
        /* 0x798 */ public float SpaceBattleInitialPirateUpOffset;
        /* 0x79C */ public float SpaceBattleInitialPirateOffset;
        /* 0x7A0 */ public float SpaceBattleObstructionRadius;
        /* 0x7A4 */ public float SpaceBattleFlybyTime;
        /* 0x7A8 */ public int SpaceBattleLevel;
        /* 0x7AC */ public Vector2f ConeSpawnOffsetFactor;
        /* 0x7B4 */ public float ConeSpawnFlattenUp;
        /* 0x7B8 */ public float ConeSpawnFlattenDown;
        /* 0x7BC */ public bool FreighterAlertLights;
        /* 0x7C0 */ public float FreighterAlertLightCapitalSize;
        /* 0x7C4 */ public NMSString0x80 LegacyHangarFilename;
        /* 0x844 */ public NMSString0x80 HangarFilename;
        /* 0x8C4 */ public float PoliceFreighterWarpOutRange;
        /* 0x8C8 */ public float MissileRange;
        /* 0x8D0 */ public Colour FreighterDoorColourActive;
        /* 0x8E0 */ public Colour FreighterDoorColourInactive;
        /* 0x8F0 */ public Colour AlertLightColour;
        /* 0x900 */ public TkHitCurveData FreighterLightHitCurve;
        /* 0x90C */ public float FreighterAlertLightTime;
        /* 0x910 */ public float FreighterAlertLightIntensity;
        /* 0x914 */ public int MaxNumTurretMissiles;
        /* 0x918 */ public float TurretOriginOffset;
        /* 0x91C */ public float TurretAlertLightIntensity;
        /* 0x920 */ public Vector3f TurretAlertLightOffset;
        /* 0x930 */ public bool DisableTradeRoutes;
        /* 0x934 */ public float AttackFreighterGetThereBoost;
        /* 0x938 */ public float AttackFreighterApproach;
        /* 0x93C */ public float AttackFreighterWingmanAlignMinDist;
        /* 0x940 */ public float AttackFreighterWingmanAlignRange;
        /* 0x944 */ public float AttackFreighterApproachDistance;
        /* 0x948 */ public float AttackFreighterAttackRunStartDistance;
        /* 0x94C */ public float AttackFreighterBugOutDistance;
        /* 0x950 */ public float AttackFreighterButOutTurnUp;
        /* 0x954 */ public float AttackFreighterButOutSpeedUp;
        /* 0x958 */ public float AttackFreighterWingmanRadius;
        /* 0x95C */ public float AttackFreighterWingmanOffset;
        /* 0x960 */ public float AttackFreighterWingmanLockAlign;
        /* 0x964 */ public float AttackFreighterWingmanLock;
        /* 0x968 */ public float AttackFreighterWingmanMaxForce;
        /* 0x96C */ public float AttackFreighterAngle;
        /* 0x970 */ public float AttackFreighterRunOffset;
        /* 0x974 */ public float AttackFreighterWingmanStart;
        /* 0x978 */ public float PirateFreighterWarpOffset;
        /* 0x97C */ public Vector2f PirateFreighterAttackRange;
        /* 0x984 */ public float MissileLaunchSpeed;
        /* 0x988 */ public float AttackAfterSpawnTime;
        /* 0x98C */ public Vector2f FreighterMiniSpeeds;
        /* 0x994 */ public float AttackBuildingGetThereBoost;
        /* 0x998 */ public float AttackBuildingApproachDistance;
        /* 0x99C */ public float AttackBuildingRunStartDistance;
        /* 0x9A0 */ public float AttackBuildingAttackRunDistTolerance;
        /* 0x9A4 */ public float AttackBuildingFiringAngleTolerance;
        /* 0x9A8 */ public float AttackBuildingBugOutDistance;
        /* 0x9AC */ public float AttackBuildingBugOutTurnUp;
        /* 0x9B0 */ public float AttackBuildingBugOutSpeedUp;
        /* 0x9B4 */ public float AttackBuildingRunAngleMin;
        /* 0x9B8 */ public float AttackBuildingRunAngleMax;
        /* 0x9BC */ public float AttackBuildingNextRunAngleDeltaMin;
        /* 0x9C0 */ public float AttackBuildingNextRunAngleDeltaMax;
        /* 0x9C4 */ public float AttackBuildingTargetGroundOffsetScaleStart;
        /* 0x9C8 */ public float AttackBuildingTargetGroundOffsetScaleEnd;
        /* 0x9CC */ public float AsteroidShootAngle;
        /* 0x9D0 */ public float TraderWantedTime;
        /* 0x9D4 */ public float TraderRequestTime;
        /* 0x9D8 */ public float TraderPostCombatRequestTime;
        /* 0x9DC */ public float TradingPostTraderRequestTime;
        /* 0x9E0 */ public float TradingPostTraderRange;
        /* 0x9E4 */ public float TradingPostTraderRangeSpace;
        /* 0x9E8 */ public float SpaceStationTraderRequestTime;
        /* 0x9EC */ public float AbandonedSystemShipSpawnProbablity;
        /* 0x9F0 */ public int FlybyCloseOdds;
        /* 0x9F4 */ public float BountySpawnAngle;
        /* 0x9F8 */ public float PoliceLaunchSpeed;
        /* 0x9FC */ public float PoliceLaunchTime;
        /* 0xA00 */ public float PolicePauseTime;
        /* 0xA04 */ public float PolicePauseTimeSpaceBattle;
        /* 0xA08 */ public float PoliceEscapeTime;
        /* 0xA0C */ public float PoliceEscapeMinTime;
        /* 0xA10 */ public float PoliceStationWaveTimer;
        /* 0xA14 */ public float PoliceStationEngageRange;
        /* 0xA18 */ public int PoliceStationNumToLaunch;
        /* 0xA1C */ public int TraderIgnoreHits;
        /* 0xA20 */ public float PirateFreighterSpawnAttackAngle;
        /* 0xA24 */ public float PirateFreighterSpawnAttackOffset;
        /* 0xA28 */ public float PirateFreighterSpawnAttackSpread;
        /* 0xA2C */ public float PirateSpawnAngle;
        /* 0xA30 */ public float PirateBattleMaxTime;
        /* 0xA34 */ public float PirateArriveTime;
        /* 0xA38 */ public float PirateStartSpeed;
        /* 0xA3C */ public float PirateBattleStartSpeed;
        /* 0xA40 */ public float PirateInterestTime;
        /* 0xA44 */ public float PirateBattleInterestTime;
        /* 0xA48 */ public float TraderArriveSpeed;
        /* 0xA4C */ public float TraderArriveTime;
        /* 0xA50 */ public float HeightTestSampleDistance;
        /* 0xA54 */ public float HeightTestSampleTime;
        /* 0xA58 */ public float OutpostToLandingDistance;
        /* 0xA5C */ public bool FreightersSamePalette;
        /* 0xA60 */ public float PlanetUpAlignTime;
        /* 0xA64 */ public float CollisionReactionTime;
        /* 0xA68 */ public float FreighterScale;
        /* 0xA6C */ public bool PoliceSpawnEffect;
        /* 0xA70 */ public int MaxNumFreighters;
        /* 0xA74 */ public float ShipSpawnStationRadius;
        /* 0xA78 */ public float ShipSpawnAnomalyRadius;
        /* 0xA7C */ public float BattleSpawnStationMinDistance;
        /* 0xA80 */ public float PoliceSpawnViewAngle;
        /* 0xA84 */ public float PoliceEntranceStartTime;
        /* 0xA88 */ public float PoliceEntranceProbe;
        /* 0xA8C */ public float PoliceEntranceEscalateProbingTime;
        /* 0xA90 */ public float PoliceEntranceEscalateIncomingTime;
        /* 0xA94 */ public float PoliceEntranceCargoScanStartTime;
        /* 0xA98 */ public float PoliceEntranceCargoProbingTime;
        /* 0xA9C */ public float PoliceEntranceCargoOpenCommsWaitTime;
        /* 0xAA0 */ public float PoliceEntranceCargoAttackWaitTime;
        /* 0xAA4 */ public float PoliceEntranceCargoScanHailNotificationWaitTime;
        /* 0xAA8 */ public float PoliceArriveTime;
        /* 0xAAC */ public float PoliceAbortRange;
        /* 0xAB0 */ public float PoliceWarnBeaconPulseTime;
        /* 0xAB4 */ public float ArrivalStaggerOffset;
        /* 0xAB8 */ public float TrailScaleMinDistance;
        /* 0xABC */ public float TrailScale;
        /* 0xAC0 */ public float TrailScaleRange;
        /* 0xAC4 */ public float TrailScaleMaxScale;
        /* 0xAC8 */ public float TrailScaleFreighterMaxScale;
        /* 0xACC */ public TkCurveType TrailScaleCurve;
        /* 0xAD0 */ public float TradeRouteSeekOutpostRange;
        /* 0xAD4 */ public float TradeRouteFollowOffset;
        /* 0xAD8 */ public NMSString0x100 TradeRouteIcon;
        /* 0xBD8 */ public float TradeRouteSpawnDistance;
        /* 0xBDC */ public float TradeRouteTrailDrawDistance;
        /* 0xBE0 */ public float TradeRouteTrailFadeTime;
        /* 0xBE4 */ public float TradeRouteTrailTimeOffset;
        /* 0xBE8 */ public float TradeRouteStationRadius;
        /* 0xBEC */ public float TradeRouteSpeed;
        /* 0xBF0 */ public float TradeRouteSlowRange;
        /* 0xBF4 */ public float TradeRouteSlowSpeed;
        /* 0xBF8 */ public int TradeRouteDivisions;
        /* 0xBFC */ public float TradeRouteFlickerFreq;
        /* 0xC00 */ public float TradeRouteFlickerAmp;
        /* 0xC04 */ public int TradeRouteMaxNum;
        /* 0xC08 */ public List<Colour> TradeRouteColours;
        /* 0xC18 */ public bool EnableLoot;
        /* 0xC1C */ public float LaserHitOffset;
        /* 0xC20 */ public float DirectionBrakeThresholdSq;
        /* 0xC24 */ public int PoliceNumPerTarget;
        /* 0xC28 */ public Vector2f PoliceSideOffset;
        /* 0xC30 */ public Vector2f PoliceUpOffset;
        /* 0xC38 */ public float WitnessHearingRange;
        /* 0xC3C */ public float WitnessSightRange;
        /* 0xC40 */ public float WitnessSightAngle;
        /* 0xC44 */ public float FreighterImpactScale;
        /* 0xC48 */ public float FreighterAlertThreshold;
        /* 0xC4C */ public float FreighterAttackDisengageDistance;
        /* 0xC50 */ public float FreighterAttackAlertThreshold;
        /* 0xC54 */ public float FreighterAlertTimeOutRate;
        /* 0xC58 */ public float FreighterAlertTimeOutMinTime;
        /* 0xC5C */ public float FreighterShipLaunchSpeed;
        /* 0xC60 */ public float FreighterLaunchTime;
        /* 0xC64 */ public float FreighterLaunchStartTime;
        /* 0xC68 */ public bool FreighterIgnorePlayer;
        /* 0xC6C */ public int FreighterNotifySquadAlertLevel;
        /* 0xC70 */ public int FreighterMaxNumLaunchedShips;
        /* 0xC74 */ public float FreighterSpawnMargin;
        /* 0xC78 */ public float FreighterSpawnRadius;
        /* 0xC7C */ public float FreighterSpawnRate;
        /* 0xC80 */ public float FreighterSpawnViewAngle;
        /* 0xC84 */ public float FreighterSpawnVisibleFreightersDistance;
        /* 0xC88 */ public float FrigateSpawnMargin;
        /* 0xC8C */ public float EngineFlareAccelMin;
        /* 0xC90 */ public float EngineFlareAccelMax;
        /* 0xC94 */ public float EngineFlareSizeMin;
        /* 0xC98 */ public float EngineFlareSizeMax;
        /* 0xC9C */ public float EngineFlareVibrateAmp;
        /* 0xCA0 */ public float EngineFlareVibrateFreq;
        /* 0xCA4 */ public float EngineFlareOffset;
        /* 0xCA8 */ public float EngineFireSize;
        /* 0xCAC */ public float PitchFlip;
        /* 0xCB0 */ public float AttackAimTime;
        /* 0xCB4 */ public float AttackRunSlowdown;
        /* 0xCB8 */ public float PiratePlayerAttackRange;
        /* 0xCBC */ public float MoveHeightAdjust;
        /* 0xCC0 */ public float MoveAvoidRange;
        /* 0xCC4 */ public int MoveHeightNumSamples;
        /* 0xCC8 */ public float MoveHeightSampleSectionSize;
        /* 0xCCC */ public float MoveHeightCheckTime;
        /* 0xCD0 */ public float TurretRandomOffset;
        /* 0xCD4 */ public float TurretRandomAIShipOffset;
        /* 0xCD8 */ public float PoliceLaunchDistance;
        /* 0xCDC */ public float Scaler;
        /* 0xCE0 */ public float ScaleTime;
        /* 0xCE4 */ public float ScalerMinDist;
        /* 0xCE8 */ public float ScalerMaxDist;
        /* 0xCEC */ public float ScaleHeightMin;
        /* 0xCF0 */ public float ScaleHeightMax;
        /* 0xCF4 */ public bool ScaleDisabledWhenOnFreighter;
        /* 0xCF8 */ public float WarpInPlayerLocatorTime;
        /* 0xCFC */ public float WarpInPlayerLocatorMinOffset;
        /* 0xD00 */ public float WarpInTime;
        /* 0xD04 */ public float WarpFadeInTime;
        /* 0xD08 */ public float WarpInTimeFreighter;
        /* 0xD0C */ public TkCurveType WarpInCurve;
        /* 0xD10 */ public float WarpInVariance;
        /* 0xD14 */ public float WarpInDistance;
        /* 0xD18 */ public float WarpInPostSpeed;
        /* 0xD1C */ public float WarpInPostSpeedFreighter;
        /* 0xD20 */ public float WarpInAudioFXDelay;
        /* 0xD24 */ public float WarpOutDistance;
        [NMS(Size = 0x7, EnumType = typeof(GcAISpaceshipTypes.ShipTypeEnum))]
        /* 0xD28 */ public NMSString0x10[] WarpStartEffectIDs;
        [NMS(Size = 0x7, EnumType = typeof(GcAISpaceshipTypes.ShipTypeEnum))]
        /* 0xD98 */ public NMSString0x10[] WarpArriveEffectIDs;
        /* 0xE08 */ public float ShipEscapeTimeBeforeWarpOut;
        /* 0xE0C */ public float ShipEscortLockOnDistance;
        /* 0xE10 */ public float ShipEscortVelocityBand;
        /* 0xE14 */ public float ShipEscortVelocityBandForce;
        /* 0xE18 */ public float ShipEscortFwdForceTime;
        /* 0xE1C */ public float ShipEscortBackForceTime;
        /* 0xE20 */ public float ShipEscortPerpForceTime;
        /* 0xE24 */ public float ShipEscortRadialOffsetScaleMin;
        /* 0xE28 */ public float ShipEscortRadialOffsetScaleMax;
        /* 0xE2C */ public float ShipEscortForwardOffsetScaleMin;
        /* 0xE30 */ public float ShipEscortForwardOffsetScaleMax;
        /* 0xE34 */ public float PirateFlybyLength;
        /* 0xE38 */ public float FlybyLength;
        /* 0xE3C */ public float FlybyHeight;
        /* 0xE40 */ public float FlybyOffset;
        /* 0xE44 */ public GcProjectileLineData ShipBullet;
        /* 0xE6C */ public float WingmanLockDistance;
        /* 0xE70 */ public float WingmanLockBetweenTime;
        /* 0xE74 */ public float WingmanLockArriveTime;
        /* 0xE78 */ public float WingmanMinHeight;
        /* 0xE7C */ public float WingmanHeightAdjust;
        /* 0xE80 */ public float WingmanStartTime;
        /* 0xE84 */ public float WingmanOffsetStart;
        /* 0xE88 */ public float WingmanOffset;
        /* 0xE8C */ public float WingmanSideOffset;
        /* 0xE90 */ public float WingmanRotate;
        /* 0xE94 */ public float WingmanAtTime;
        /* 0xE98 */ public float WingmanAtTimeBack;
        /* 0xE9C */ public float WingmanPerpTime;
        /* 0xEA0 */ public float WingmanVelocityBand;
        /* 0xEA4 */ public float WingmanVelocityBandForce;
        /* 0xEA8 */ public float TraderAtTime;
        /* 0xEAC */ public float TraderAtTimeBack;
        /* 0xEB0 */ public float TraderPerpTime;
        /* 0xEB4 */ public float TraderVelocityBand;
        /* 0xEB8 */ public float TraderVelocityBandForce;
        /* 0xEBC */ public float WingmanAlign;
        /* 0xEC0 */ public float WarpSpeed;
        /* 0xEC4 */ public float WarpForce;
        /* 0xEC8 */ public float TrailSpeedFadeMinSpeed;
        /* 0xECC */ public float TrailSpeedFadeFalloff;
        /* 0xED0 */ public float DockingLandingTime;
        /* 0xED4 */ public float DockingLandingTimeDirectional;
        /* 0xED8 */ public float DockingSpringTime;
        /* 0xEDC */ public float DockingLandingBounceTime;
        /* 0xEE0 */ public float DockingLandingBounceHeight;
        /* 0xEE4 */ public float DockingRotateStartTime;
        /* 0xEE8 */ public float DockingRotateSpeed;
        /* 0xEEC */ public float DockWaitMinTime;
        /* 0xEF0 */ public float DockWaitMaxTime;
        /* 0xEF4 */ public float TakeOffHoverPointReachedDistance;
        /* 0xEF8 */ public float TakeOffExitHeightOffset;
        /* 0xEFC */ public float TakeOffExtraAIHeight;
        /* 0xF00 */ public float LandingManuevreTime;
        /* 0xF04 */ public float LandingManeuvreAlignTime;
        /* 0xF08 */ public float LandingHoverPointReachedDistance;
        /* 0xF0C */ public float LandingDirectionalHoverPointReachedDistance;
        /* 0xF10 */ public float AtmosphereTerminalSpeed;
        /* 0xF14 */ public float CircleApproachDistance;
        /* 0xF18 */ public float TravelMinBoostTime;
        /* 0xF1C */ public float GroundCircleHeight;
        /* 0xF20 */ public float GroundCircleHeightMax;
        /* 0xF24 */ public float OrbitHeight;
        /* 0xF28 */ public float AtmosphereEffectMin;
        /* 0xF2C */ public float AtmosphereEffectMax;
        /* 0xF30 */ public float MaxTorque;
        /* 0xF34 */ public float ShipAngularFactor;
        /* 0xF38 */ public float RollAmount;
        /* 0xF3C */ public float RollMinTurnAngle;
        /* 0xF40 */ public float FinalDeathExplosionScale;
        /* 0xF44 */ public float FinalDeathExplosionTime;
        /* 0xF48 */ public float FinalDeathFadeTime;
        /* 0xF4C */ public GcShipAIDeathData Death;
        /* 0xF68 */ public GcShipAIPlanetPatrolData WingmanPathData;
        /* 0xFA0 */ public List<GcAIShipDebugSpawnData> DebugShipSpawns;
    }
}

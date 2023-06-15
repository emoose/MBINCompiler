using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x70BA238673F067ED, NameHash = 0xE2DEF8CC8775E050)]
    public class GcCreatureGlobals : NMSTemplate
    {
        /* 0x0000 */ public int NumCreaturesRequiredForDiscoveryMission;
        /* 0x0004 */ public int AllCreaturesDiscoveredBonusMul;
        /* 0x0010 */ public Colour AllCreaturesDiscoveredColour;
        /* 0x0020 */ public NMSString0x20A PetCarePuzzleOverrideID;
        /* 0x0040 */ public float CreatureInteractionRangeBoostHuge;
        /* 0x0044 */ public float CreatureInteractionRangeBoostLarge;
        /* 0x0048 */ public float CreatureInteractionRangeBoostMedium;
        /* 0x004C */ public float CreatureInteractionRangeBoostSmall;
        /* 0x0050 */ public float CreatureInteractionRangeBoostRun;
        /* 0x0054 */ public float CreatureInteractionRangeBoostSprint;
        /* 0x0058 */ public float CreatureInteractionRangeReducePredator;
        /* 0x005C */ public bool CreatureInteractWithoutRaycasts;
        /* 0x0060 */ public float CreatureInteractBaseRange;
        /* 0x0064 */ public float PetInteractBaseRange;
        [NMS(Size = 0xB, EnumType = typeof(GcCreatureRoles.CreatureRoleEnum))]
        /* 0x0068 */ public NMSString0x20A[] Temperments;
        [NMS(Size = 0xB, EnumType = typeof(GcCreatureRoles.CreatureRoleEnum))]
        /* 0x01C8 */ public NMSString0x20A[] TempermentDescriptions;
        [NMS(Size = 0x4, EnumType = typeof(GcCreatureDiet.DietEnum))]
        /* 0x0328 */ public NMSString0x20A[] Diets;
        [NMS(Size = 0x4, EnumType = typeof(GcCreatureDiet.DietEnum))]
        /* 0x03A8 */ public NMSString0x20A[] WaterDiets;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x0428 */ public NMSString0x20A[] DietMeat;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x0628 */ public NMSString0x20A[] DietVeg;
        [NMS(Size = 0x4, EnumType = typeof(GcCreatureDiet.DietEnum))]
        /* 0x0828 */ public NMSString0x20A[] DietDescriptions;
        [NMS(Size = 0x4, EnumType = typeof(GcCreatureDiet.DietEnum))]
        /* 0x08A8 */ public NMSString0x20A[] WaterDietDescriptions;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x0928 */ public NMSString0x20A[] BiomeDescriptions;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x0B28 */ public NMSString0x20A[] BiomeWaterDescriptions;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x0D28 */ public NMSString0x20A[] BiomeAirDescriptions;
        [NMS(Size = 0x1B, EnumType = typeof(GcBiomeSubType.BiomeSubTypeEnum))]
        /* 0x0F28 */ public NMSString0x20A[] WeirdBiomeDescriptions;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x1288 */ public NMSString0x20A[] PetBiomeClimates;
        /* 0x1488 */ public bool IsHurtingCreaturesACrime;
        /* 0x1489 */ public bool EnableFlyingSnakeTails;
        /* 0x148A */ public bool EnableNewStuff;
        /* 0x148B */ public bool InstantCreatureRide;
        /* 0x148C */ public bool EnableVRCreatureRide;
        /* 0x148D */ public bool EnableMPCreatureRide;
        /* 0x1490 */ public float RidingReplicationRangeMultiplier;
        /* 0x1494 */ public float RidingRollAdjustMaxAngle;
        /* 0x1498 */ public float RidingRollMaxAngleAt;
        /* 0x149C */ public float RidingFirstPersonOffsetFwd;
        /* 0x14A0 */ public float RidingFirstPersonOffsetUp;
        /* 0x14A4 */ public float CreatureScaleMangle;
        /* 0x14A8 */ public bool CreatureRideDirectControl;
        /* 0x14A9 */ public bool StaticCreatureRide;
        /* 0x14AC */ public float RideSpeedSlow;
        /* 0x14B0 */ public float RideSpeedFast;
        /* 0x14B4 */ public float RideSpeedChangeTime;
        /* 0x14B8 */ public float RiderLeanTime;
        /* 0x14BC */ public float PostRideMoveTime;
        /* 0x14C0 */ public float RideIdleTime;
        /* 0x14C4 */ public float MinRideSize;
        /* 0x14C8 */ public float MaxCreatureSize;
        /* 0x14CC */ public float MaxRideLeanCounterRotate;
        /* 0x14D0 */ public float PetMinSummonDistance;
        /* 0x14D4 */ public float PetMaxSummonDistance;
        /* 0x14D8 */ public float PetSummonRotation;
        /* 0x14DC */ public float PlayerDamageTransferScale;
        /* 0x14E0 */ public GcSeed CreatureSeed;
        /* 0x14F0 */ public NMSString0x20A CreatureFilter;
        /* 0x1510 */ public int MaxEcosystemCreaturesNormal;
        /* 0x1514 */ public int MaxEcosystemCreaturesLow;
        /* 0x1518 */ public int MaxAdditionalEcosystemCreaturesForDiscovery;
        /* 0x151C */ public float LowPerfFlockReduce;
        /* 0x1520 */ public bool UncapSpawningforVideo;
        /* 0x1521 */ public bool AllowSpawningOnscreen;
        /* 0x1524 */ public float ResourceSpawnTime;
        /* 0x1528 */ public float TurnInPlaceIdleTime;
        /* 0x152C */ public float TurnInPlaceMaxAngle;
        /* 0x1530 */ public float TurnInPlaceMinTime;
        /* 0x1534 */ public float TurnInPlaceMaxSpeed;
        /* 0x1538 */ public float TurnInPlaceMaxSpeedIndoor;
        /* 0x153C */ public float SceneTerrainSpawnMinDistance;
        /* 0x1540 */ public float CreatureMinAlignSpeed;
        /* 0x1544 */ public float PatrolMinDist;
        /* 0x1548 */ public float PatrolMaxDist;
        /* 0x154C */ public float PatrolHeightOffset;
        /* 0x1550 */ public float PatrolGradientFactor;
        /* 0x1554 */ public float CreatureWaryTime;
        /* 0x1558 */ public float CreatureMinRunTime;
        /* 0x155C */ public float CreatureHearingRange;
        /* 0x1560 */ public float CreatureSightRange;
        /* 0x1564 */ public float CreatureMoveIdle;
        /* 0x1568 */ public float CreatureTurnMin;
        /* 0x156C */ public float CreatureTurnMax;
        /* 0x1570 */ public float CreatureBrakeForce;
        /* 0x1574 */ public float CreatureMinAnimMoveSpeed;
        /* 0x1578 */ public float CreatureLookBeforeGoingTime;
        /* 0x157C */ public float CreatureLookBeforeFleeingTime;
        /* 0x1580 */ public float CreatureLookBeforeFleeingIfShotTime;
        /* 0x1584 */ public float CreatureLookScaryThingTime;
        /* 0x1588 */ public float CreatureLookPlayerForceLookTime;
        /* 0x158C */ public float LookMaxYawMoving;
        /* 0x1590 */ public float LookMaxYawStatic;
        /* 0x1594 */ public float LookPitchAtMaxYaw;
        /* 0x1598 */ public float LookMaxPitchWhenMoving;
        /* 0x159C */ public float LookRollAtMaxYaw;
        /* 0x15A0 */ public float LookRollWhenMoving;
        /* 0x15A4 */ public float FootPlantError;
        /* 0x15A8 */ public float RecoverHealthTime;
        /* 0x15B0 */ public GcCameraShakeData PainShake;
        /* 0x1670 */ public float PatrolSwitchMinTime;
        /* 0x1674 */ public float ExtraFollowStrength;
        /* 0x1678 */ public float ExtraFollowFreq1;
        /* 0x167C */ public float ExtraFollowFreq2;
        /* 0x1680 */ public float SandWormChangeDirectionTime;
        /* 0x1684 */ public float SandWormSteerAdjustTime;
        /* 0x1688 */ public float SandWormMaxSteer;
        /* 0x168C */ public float SandWormMaxHeightAdjust;
        /* 0x1690 */ public float SandWormJumpHeight;
        /* 0x1694 */ public float SandWormJumpTime;
        /* 0x1698 */ public float SandWormSubmergeDepth;
        /* 0x169C */ public float SandWormSubmergeTime;
        /* 0x16A0 */ public float SandWormSurfaceTime;
        /* 0x16A4 */ public int SandWormMaxJumps;
        /* 0x16A8 */ public float SandWormDespawnDist;
        /* 0x16AC */ public float SandWormSpawnTimer;
        /* 0x16B0 */ public float SandWormSpawnChanceMin;
        /* 0x16B4 */ public float SandWormSpawnChanceMax;
        /* 0x16B8 */ public float SandWormSpawnChanceInfested;
        /* 0x16BC */ public float GroundWormSpawnRadius;
        /* 0x16C0 */ public float GroundWormSpawnSpacing;
        /* 0x16C4 */ public float GroundWormSpawnTimeOut;
        /* 0x16C8 */ public int GroundWormSpawnMin;
        /* 0x16CC */ public int GroundWormSpawnMax;
        /* 0x16D0 */ public float GroundWormSpawnerActivateRadius;
        /* 0x16D4 */ public float GroundWormSpawnerDestroyRadiusActive;
        /* 0x16D8 */ public float GroundWormSpawnerDestroyRadiusInactive;
        /* 0x16DC */ public float GroundWormSpawnChance;
        /* 0x16E0 */ public float GroundWormScaleMin;
        /* 0x16E4 */ public float GroundWormScaleMax;
        /* 0x16E8 */ public float ShieldFadeTime;
        /* 0x16EC */ public float SharkAlongPathSpeed;
        /* 0x16F0 */ public float SwarmBrakingForce;
        /* 0x16F4 */ public float SharkToPathYDamp;
        /* 0x16F8 */ public float SharkAttackSpeed;
        /* 0x16FC */ public float SharkAttackAccel;
        /* 0x1700 */ public float SharkPatrolSpeed;
        /* 0x1704 */ public float SharkPatrolRadius;
        /* 0x1708 */ public float SharkPatrolEnd;
        /* 0x170C */ public float SharkGetToPathSpeed;
        /* 0x1710 */ public float SharkAlignSpeed;
        /* 0x1714 */ public float FishBobFrequency;
        /* 0x1718 */ public float FishBobAmplitude;
        /* 0x171C */ public float FreighterJellyBobFrequency;
        /* 0x1720 */ public float FreighterJellyBobAmplitude;
        /* 0x1724 */ public float InfluenceRadius;
        /* 0x1728 */ public float InfluenceForce;
        /* 0x172C */ public float InfluenceThreshold;
        /* 0x1730 */ public float InfluenceDeflect;
        /* 0x1734 */ public float TargetSearchTimeout;
        /* 0x1738 */ public float AttractMinDistance;
        /* 0x173C */ public float SwarmMoveYFactor;
        /* 0x1740 */ public float DroneExplodeRadius;
        /* 0x1744 */ public float WeaponRepelRange;
        /* 0x1748 */ public float WeaponRepelAmount;
        /* 0x174C */ public float VelocityAlignStrength;
        /* 0x1750 */ public float VelocityAlignSpeed;
        /* 0x1754 */ public float HeightLookAhead;
        /* 0x1758 */ public float MaxHeightTime;
        /* 0x175C */ public float PlayerBirdDistance;
        /* 0x1760 */ public float FishSpeedMin;
        /* 0x1764 */ public float FishSpeedMax;
        /* 0x1768 */ public float FishSwimMaxAcceleration;
        /* 0x176C */ public float AlertDistance;
        /* 0x1770 */ public float RepelRange;
        /* 0x1774 */ public float RepelAmount;
        /* 0x1778 */ public float FishTurn;
        /* 0x177C */ public float TargetReachedDistance;
        /* 0x1780 */ public float MaxSpeed;
        /* 0x1784 */ public float MaxForce;
        /* 0x1788 */ public float MaxTorque;
        /* 0x178C */ public float MinWaterSpawnDepth;
        /* 0x1790 */ public float WaterSpawnOffset;
        /* 0x1794 */ public float SpawnDistanceModifierForUnderwater;
        /* 0x1798 */ public float FootDustGroundTintStrength;
        /* 0x179C */ public float StickToGroundSpeed;
        /* 0x17A0 */ public float StickToGroundCastBegin;
        /* 0x17A4 */ public float StickToGroundCastEnd;
        /* 0x17A8 */ public float AnimationStickToGroundSpeed;
        /* 0x17AC */ public GcFlyingSnakeData FlyingSnakeData;
        /* 0x17F0 */ public List<GcCreatureAlertData> AlertTable;
        /* 0x1800 */ public bool ShowScale;
        /* 0x1804 */ public float PetFootShakeModifier;
        /* 0x1808 */ public float CreatureMedMinSize;
        /* 0x180C */ public float CreatureLargeMinSize;
        /* 0x1810 */ public float CreatureHugeMinSize;
        /* 0x1814 */ public float CreatureRidingMedMinSize;
        /* 0x1818 */ public float CreatureRidingLargeMinSize;
        /* 0x181C */ public float CreatureRidingHugeMinSize;
        /* 0x1820 */ public float CreatureBlobRidingMedMinSize;
        /* 0x1824 */ public float CreatureBlobRidingLargeMinSize;
        /* 0x1828 */ public float CreatureBlobRidingHugeMinSize;
        /* 0x182C */ public int CreatureSmallHealth;
        /* 0x1830 */ public int CreatureMedHealth;
        /* 0x1834 */ public int CreatureLargeHealth;
        /* 0x1838 */ public int CreatureHugeHealth;
        /* 0x1840 */ public NMSString0x10 CreatureLargeWalkShake;
        /* 0x1850 */ public float CreatureLargeWalkMaxShakeDist;
        /* 0x1858 */ public NMSString0x10 CreatureLargeRunShake;
        /* 0x1868 */ public float CreatureLargeRunMaxShakeDist;
        /* 0x1870 */ public NMSString0x10 CreatureHugeWalkShake;
        /* 0x1880 */ public float CreatureHugeWalkMaxShakeDist;
        /* 0x1888 */ public NMSString0x10 CreatureHugeRunShake;
        /* 0x1898 */ public float CreatureHugeRunMaxShakeDist;
        /* 0x189C */ public float SmallCreaturePerceptionDistance;
        /* 0x18A0 */ public float largeCreaturePerceptionDistance;
        /* 0x18A4 */ public float SmallCreatureFleePlayerDistance;
        /* 0x18A8 */ public float LargeCreatureFleePlayerDistance;
        /* 0x18AC */ public float SmallCreatureAvoidPlayerDistance;
        /* 0x18B0 */ public float LargeCreatureAvoidPlayerDistance;
        /* 0x18B4 */ public float PredatorPerceptionDistance;
        /* 0x18B8 */ public float PredatorFishPerceptionDistance;
        /* 0x18BC */ public float PassiveFleePlayerDistance;
        /* 0x18C0 */ public float AdultBabyKilledNoticeDistance;
        /* 0x18C4 */ public float PercentagePlayerPredators;
        /* 0x18C8 */ public int PredatorSmallHealth;
        /* 0x18CC */ public int PredatorMedHealth;
        /* 0x18D0 */ public int PredatorLargeHealth;
        /* 0x18D4 */ public int PredatorHugeHealth;
        /* 0x18D8 */ public float PlayerPredatorHealthModifier;
        /* 0x18DC */ public float PredatorApproachTime;
        /* 0x18E0 */ public float PredatorNoticePauseTime;
        /* 0x18E4 */ public float PredatorStealthDist;
        /* 0x18E8 */ public float PredatorChargeDist;
        /* 0x18EC */ public float PredatorChargeDistScale;
        /* 0x18F0 */ public float FishPredatorChargeDist;
        /* 0x18F4 */ public float FishPredatorChargeDistScale;
        /* 0x18F8 */ public float PredatorBoredomDistance;
        /* 0x18FC */ public float PlayerPredatorBoredomDistance;
        /* 0x1900 */ public float PredatorRegainInterestTime;
        /* 0x1904 */ public float PlayerPredatorRegainInterestTime;
        /* 0x1908 */ public float PredatorRunAwayDist;
        /* 0x190C */ public float PredatorRoarProbAfterHit;
        /* 0x1910 */ public float PredatorRoarProbAfterMiss;
        /* 0x1914 */ public float PredatorRunAwayHealthPercent;
        /* 0x1918 */ public float PredatorEnergyRecoverRate;
        /* 0x191C */ public float PredatorEnergyUseChasing;
        /* 0x1920 */ public bool AggressiveSharks;
        /* 0x1924 */ public float DelayAfterRespawnBeforeAttackable;
        /* 0x1928 */ public float IndoorTurnTime;
        /* 0x192C */ public float IndoorObstacleAvoidStrength;
        /* 0x1930 */ public float IndoorSteeringRayLength;
        /* 0x1934 */ public float IndoorSteeringRaySphereSize;
        /* 0x1938 */ public float IndoorSteeringRaySpread;
        /* 0x193C */ public float FreighterSpawnDist;
        /* 0x1940 */ public float FreighterDespawnDist;
        /* 0x1944 */ public bool ScuttlersCanAttack;
        /* 0x1948 */ public int ScuttlerHealth;
        /* 0x194C */ public float ScuttlerInitialNoAttackTime;
        /* 0x1950 */ public float ScuttlerMoveTimeMin;
        /* 0x1954 */ public float ScuttlerMoveTimeMax;
        /* 0x1958 */ public float ScuttlerIdleTimeMin;
        /* 0x195C */ public float ScuttlerIdleTimeMax;
        /* 0x1960 */ public float ScuttlerZigZagTimeMin;
        /* 0x1964 */ public float ScuttlerZigZagTimeMax;
        /* 0x1968 */ public float ScuttlerZigZagStrength;
        /* 0x196C */ public float ScuttlerSpitDelay;
        /* 0x1970 */ public float ScuttlerSpitChargeTime;
        /* 0x1974 */ public float MiniDroneEnergyRecoverRate;
        /* 0x1978 */ public float MiniDroneEnergyUsePerShot;
        /* 0x197C */ public float MiniDroneShotDelay;
        /* 0x1980 */ public float MiniDroneShotMaxAngle;
        /* 0x1984 */ public bool FiendsCanAttack;
        /* 0x1985 */ public bool FiendOnscreenMarkers;
        /* 0x1988 */ public float FiendPounceDistanceModifier;
        /* 0x198C */ public int FiendHealth;
        /* 0x1990 */ public float FiendPerceptionDistance;
        /* 0x1994 */ public float FiendSpawnDistance;
        /* 0x1998 */ public float FiendDespawnDistance;
        /* 0x199C */ public float FiendReplicateStartDistance;
        /* 0x19A0 */ public float FiendReplicateEndDistance;
        /* 0x19A4 */ public float FiendAggroTime;
        /* 0x19A8 */ public int FiendMaxEngaged;
        /* 0x19AC */ public int FiendMaxAttackers;
        /* 0x19B0 */ public float FiendMaxVerticalForPounce;
        /* 0x19B4 */ public float FiendZigZagSpeed;
        /* 0x19B8 */ public float FiendZigZagStrength;
        /* 0x19BC */ public int FiendEggsToUnlockSpit;
        /* 0x19C0 */ public int MaxFiendsToSpawn;
        /* 0x19C4 */ public float FiendMinSpawnTime;
        /* 0x19C8 */ public float FiendMaxSpawnTime;
        /* 0x19CC */ public float FiendAggroIncreaseDamageEgg;
        /* 0x19D0 */ public float FiendAggroIncreaseDestroyEgg;
        /* 0x19D4 */ public float FiendAggroDecreasePerSpawn;
        /* 0x19D8 */ public float FiendCritAreaSize;
        /* 0x19DC */ public float FiendDistToConsiderTargetSwtich;
        /* 0x19E0 */ public float FiendDistReduceForBeingShot;
        /* 0x19E4 */ public float FiendBeingShotMemoryTime;
        /* 0x19E8 */ public int MaxFishFiends;
        /* 0x19EC */ public int FishFiendSmallHealth;
        /* 0x19F0 */ public int FishFiendBigHealth;
        /* 0x19F4 */ public float FishFiendSmallBoostStrength;
        /* 0x19F8 */ public float FishFiendSmallBoostTime;
        /* 0x19FC */ public float FishFiendSmallScale;
        /* 0x1A00 */ public float FishFiendBigBoostStrength;
        /* 0x1A04 */ public float FishFiendBigBoostTime;
        /* 0x1A08 */ public float FishFiendBigScale;
        /* 0x1A0C */ public float AsteroidCreatureSpawnPercentOverride;
        /* 0x1A10 */ public float AsteroidCreatureRichSystemSpawnPercent;
        /* 0x1A14 */ public float RoutineSpeed;
        /* 0x1A18 */ public float RoutineOffset;
        /* 0x1A1C */ public float RagdollTau;
        /* 0x1A20 */ public float RagdollDamping;
        /* 0x1A24 */ public float RagdollConeLimit;
        /* 0x1A28 */ public float RagdollTwistLimit;
        /* 0x1A2C */ public float RagdollMotorFadeStart;
        /* 0x1A30 */ public float RagdollMotorFadeEnd;
        /* 0x1A34 */ public int MaxRagdollsBeforeDespawnOffscreen;
        /* 0x1A38 */ public int MaxRagdollsBeforeDespawnOnscreen;
        /* 0x1A3C */ public float TurnRadiusMultiplier;
        /* 0x1A40 */ public float MaxTurnRadius;
        /* 0x1A44 */ public float TurnSlowAreaCos;
        /* 0x1A48 */ public float BadTurnPercent;
        /* 0x1A4C */ public float BadTurnWeight;
        /* 0x1A50 */ public float MinScaleForNavMap;
        /* 0x1A54 */ public float ImpassabilityBrakeTime;
        /* 0x1A58 */ public float ImpassabilityUnbrakeTime;
        /* 0x1A5C */ public float ImpassabilityTurnSpeedMultiplier;
        /* 0x1A60 */ public float NavMapLookAhead;
        /* 0x1A64 */ public float VelocityAlignYFactorMin;
        /* 0x1A68 */ public float VelocityAlignYFactorMax;
        /* 0x1A6C */ public float BrakingForce;
        /* 0x1A70 */ public float BrakingForceY;
        /* 0x1A74 */ public float FlowFieldWeight;
        /* 0x1A78 */ public float FollowWeight;
        /* 0x1A7C */ public float RidingSteerWeight;
        /* 0x1A80 */ public float AvoidCreaturesWeight;
        /* 0x1A84 */ public float AvoidImpassableWeight;
        /* 0x1A88 */ public float BaseAndTerrainModImpassableStrength;
        /* 0x1A8C */ public float FollowLeaderAlignWeight;
        /* 0x1A90 */ public float FollowLeaderCohereWeight;
        /* 0x1A94 */ public float SoftenAvoidanceRadiusMod;
        /* 0x1A98 */ public float FreighterJellySwimSpeed;
        /* 0x1A9C */ public float LandJellySwimSpeed;
        /* 0x1AA0 */ public float SpaceJellySwimSpeed;
        /* 0x1AA4 */ public float DefaultSwimSpeed;
        /* 0x1AA8 */ public float FastSwimSpeed;
        /* 0x1AAC */ public float DefaultWalkMoveSpeed;
        /* 0x1AB0 */ public float DefaultTrotMoveSpeed;
        /* 0x1AB4 */ public float DefaultRunMoveSpeed;
        /* 0x1AB8 */ public float PredatorWalkMoveSpeed;
        /* 0x1ABC */ public float PredatorTrotMoveSpeed;
        /* 0x1AC0 */ public float PredatorRunMoveSpeed;
        /* 0x1AC4 */ public float HeightDiffPenalty;
        /* 0x1AC8 */ public float EdgeClosenessPenalty;
        /* 0x1ACC */ public float PelvisIkStrength;
        /* 0x1AD0 */ public float SteeringUpdateRate;
        /* 0x1AD4 */ public float PathOverestimate;
        /* 0x1AD8 */ public float FishWaterSurfaceAnticipate;
        /* 0x1ADC */ public float FishWaterSurfaceAvoidStrength;
        /* 0x1AE0 */ public float FishDesiredDepth;
        /* 0x1AE4 */ public float FishMinHeightAboveSeaBed;
        /* 0x1AE8 */ public float FishSeaBedAvoidStrength;
        /* 0x1AEC */ public float FishObstacleAvoidStrength;
        /* 0x1AF0 */ public float FishPlayerAttractionFrontDist;
        /* 0x1AF4 */ public float FishPlayerAttractionAhead;
        /* 0x1AF8 */ public float FishPlayerAttractionMinDist;
        /* 0x1AFC */ public float FishPlayerAttractionMaxDist;
        /* 0x1B00 */ public float FishPlayerAttractionStrength;
        /* 0x1B04 */ public float AttackPlayerDistance;
        /* 0x1B08 */ public float SpawnCameraAngleCos;
        /* 0x1B0C */ public float SpawnMinDistPercentage;
        /* 0x1B10 */ public float SpawnOnscreenDist;
        /* 0x1B14 */ public float FadeScaleMultiplier;
        /* 0x1B18 */ public float FadeScalePower;
        /* 0x1B1C */ public float FadeDistance;
        /* 0x1B20 */ public float SpawnDistAtMinSize;
        /* 0x1B24 */ public float SpawnDistAtMaxSize;
        /* 0x1B28 */ public float DespawnDistFactor;
        /* 0x1B2C */ public float MinFade;
        /* 0x1B30 */ public float MaxFade;
        /* 0x1B34 */ public bool ProcessPendingSpawnRequests;
        /* 0x1B38 */ public float SpawnsAvoidBaseMultiplier;
        /* 0x1B3C */ public int PerceptionUpdateRate;
        /* 0x1B40 */ public bool AllowSleeping;
        /* 0x1B41 */ public bool DebugDrawTrails;
        /* 0x1B44 */ public float TrailHalfLife;
        /* 0x1B48 */ public bool EnableTrailIk;
        /* 0x1B4C */ public float DetailAnimBlendInTime;
        /* 0x1B50 */ public float DetailAnimBlendOutTime;
        /* 0x1B54 */ public float DetailAnimMinPauseTime;
        /* 0x1B58 */ public float DetailAnimMaxPauseTime;
        /* 0x1B5C */ public bool DetailAnimPlayWhileWalking;
        /* 0x1B60 */ public NMSString0x10 CreatureDeathEffectSmall;
        /* 0x1B70 */ public NMSString0x10 CreatureDeathEffectMedium;
        /* 0x1B80 */ public NMSString0x10 CreatureDeathEffectBig;
        /* 0x1B90 */ public NMSString0x10 FishDeathEffect;
        /* 0x1BA0 */ public float FootParticleTime;
        /* 0x1BA4 */ public bool PiedPiper;
        /* 0x1BA8 */ public float PetInteractTurnToFaceMinAngle;
        /* 0x1BAC */ public float FollowPlayerDistance;
        /* 0x1BB0 */ public float FollowRunPlayerDistance;
        /* 0x1BB4 */ public float FollowRange;
        /* 0x1BB8 */ public float PetPlayerSpeedSmoothTime;
        /* 0x1BBC */ public float PetStickySideBiasAngle;
        /* 0x1BC0 */ public float PetWalkAtHeelChanceDevoted;
        /* 0x1BC4 */ public float PetWalkAtHeelChanceIndependent;
        /* 0x1BC8 */ public float PetWalkAtHeelDistMin;
        /* 0x1BCC */ public float PetWalkAtHeelDistMax;
        /* 0x1BD0 */ public float PetRunAtHeelDistMin;
        /* 0x1BD4 */ public float PetRunAtHeelDistMax;
        /* 0x1BD8 */ public float PetHeelDistSwitchTimeMin;
        /* 0x1BDC */ public float PetHeelDistSwitchTimeMax;
        /* 0x1BE0 */ public float PetRunAtHeelLateralShiftMin;
        /* 0x1BE4 */ public float PetRunAtHeelLateralShiftMax;
        /* 0x1BE8 */ public float PetHeelLateralShiftTimeMin;
        /* 0x1BEC */ public float PetHeelLateralShiftTimeMax;
        /* 0x1BF0 */ public float PetWalkAtHeelLateralShift;
        /* 0x1BF4 */ public float PetHeelPosSpringTime;
        /* 0x1BF8 */ public NMSString0x10 PetScan;
        /* 0x1C08 */ public float PetRadialCentre;
        /* 0x1C0C */ public float PetRadialRadius;
        /* 0x1C10 */ public float PetRadialWidth;
        /* 0x1C14 */ public float PetRadialPulseMul;
        /* 0x1C18 */ public float PetRadialPulseTime;
        /* 0x1C1C */ public float PetHeartMaxSize;
        /* 0x1C20 */ public float PetHeartChangePerLayer;
        /* 0x1C24 */ public float PetHeartResponseLoopTime;
        /* 0x1C28 */ public float PetHeartResponseTotalTime;
        /* 0x1C2C */ public float PetLastActionReportTime;
        /* 0x1C30 */ public float PetMoodSmoothTime;
        /* 0x1C34 */ public float PetFollowRunPlayerDistance;
        /* 0x1C38 */ public float PetFollowRange;
        /* 0x1C40 */ public Colour PetRadialBadColour;
        /* 0x1C50 */ public Colour PetRadialNeutralColour;
        /* 0x1C60 */ public Colour PetRadialGoodColour;
        /* 0x1C70 */ public Colour PetRadialBoostColour;
        /* 0x1C80 */ public float PetChatCooldown;
        /* 0x1C84 */ public float PetChatUseTraitTemplateChance;
        /* 0x1C88 */ public float PetEffectSpawnOffsetSmall;
        /* 0x1C8C */ public float PetEffectSpawnOffsetMed;
        /* 0x1C90 */ public float PetEffectSpawnOffsetLarge;
        /* 0x1C94 */ public float PetEffectSpawnOffsetHuge;
        /* 0x1C98 */ public float PetTickleChatChance;
        /* 0x1C9C */ public float PetTreatChatChance;
        /* 0x1CA0 */ public bool UseCreatureAdoptOSD;
        /* 0x1CA4 */ public float SearchItemDistance;
        /* 0x1CA8 */ public float SearchItemFrequency;
        /* 0x1CAC */ public float SearchItemGiveUpDistance;
        /* 0x1CB0 */ public float SearchItemGiveUpTime;
        /* 0x1CB4 */ public float SearchItemNotifyTime;
        /* 0x1CB8 */ public float SearchSpawnRandomItemProbability;
        /* 0x1CBC */ public float MiningRandomProbability;
        /* 0x1CC0 */ public bool DebugSearch;
        /* 0x1CC4 */ public int FriendlyCreatureLimit;
        /* 0x1CC8 */ public int FeedingTaskAmount;
        /* 0x1CCC */ public float FeedingFollowTime;
        /* 0x1CD0 */ public float FeedingNoticeTime;
        /* 0x1CD4 */ public float FeedingNoticeDistance;
        /* 0x1CD8 */ public float AttractedMinAvoidCreaturesStrength;
        /* 0x1CDC */ public float AttractedMinAvoidCreaturesDist;
        /* 0x1CE0 */ public float AttractedMaxAvoidCreaturesStrength;
        /* 0x1CE4 */ public float AttractedMaxAvoidCreaturesDist;
        /* 0x1CE8 */ public bool PetsShowTraitClassesAsWords;
        /* 0x1CEC */ public int PetSlotsUnlockedByDefault;
        /* 0x1CF0 */ public int PetGrowthTime;
        /* 0x1CF4 */ public int PetIncubationTime;
        /* 0x1CF8 */ public int PetTrustChangeInterval;
        /* 0x1CFC */ public float PetTrustOnAdoption;
        /* 0x1D00 */ public float PetTrustOnHatch;
        /* 0x1D04 */ public float PetTrustIncreaseStep;
        /* 0x1D08 */ public float PetTrustDecreaseStep;
        /* 0x1D0C */ public float PetTrustIncreaseThreshold;
        /* 0x1D10 */ public float PetTrustDecreaseThreshold;
        /* 0x1D14 */ public float PetMinTrust;
        /* 0x1D18 */ public float PetEggLayingDuration;
        /* 0x1D1C */ public int PetEggLayingInterval;
        /* 0x1D20 */ public int PetEggFirstEggDelay;
        /* 0x1D24 */ public int PetEggModificationTime;
        /* 0x1D28 */ public int PetEggModificationItemLimit;
        /* 0x1D30 */ public NMSString0x10 PetEggMaxChangeProduct;
        /* 0x1D40 */ public float PetEggSubstanceModifier;
        /* 0x1D44 */ public float PetEggScaleRangeModifier;
        /* 0x1D48 */ public float PetEggScaleRangeMax;
        /* 0x1D4C */ public float PetEggTraitRangeModifier;
        /* 0x1D50 */ public float PetEggTraitRangeMax;
        /* 0x1D54 */ public float PetEggMinDistStep;
        /* 0x1D58 */ public float PetEggMaxDistStep;
        /* 0x1D5C */ public float PetEggOverdosageModifier;
        /* 0x1D60 */ public float PetEggMaxOverdosage;
        /* 0x1D64 */ public float PetEggMaxTopDescriptorChangeChance;
        /* 0x1D68 */ public float PetEggAccessoryChanceModifier;
        /* 0x1D6C */ public float PetEggMaxAccessoriesChangeChance;
        /* 0x1D70 */ public float PetEggColourChanceModifier;
        /* 0x1D74 */ public float PetEggMaxColourChangeChance;
        /* 0x1D78 */ public float PetEggHatchScaleChange;
        /* 0x1D7C */ public float PetEggHatchTraitChange;
        /* 0x1D80 */ public float PetEggHatchColourChangeChance;
        /* 0x1D84 */ public GcPetBehaviours PetForceBehaviour;
        /* 0x1D88 */ public float PetMaxSizeOffPlanet;
        /* 0x1D8C */ public float PetTeleportDistOffPlanet;
        /* 0x1D90 */ public float PetTeleportDistOnPlanet;
        /* 0x1D94 */ public bool PetCanSummonOnFreighter;
        /* 0x1D98 */ public float PetAnimSpeedBoostSmallerThan;
        /* 0x1D9C */ public float PetAnimSpeedBoostStrength;
        /* 0x1DA0 */ public float PetAnimSpeedMax;
        /* 0x1DA4 */ public float PetAnimSpeedMin;
        /* 0x1DA8 */ public float PetNavRadForMinTurn;
        /* 0x1DAC */ public float PetNavRadForMaxTurn;
        /* 0x1DB0 */ public float PetMinTurnRad;
        /* 0x1DB4 */ public float PetMaxTurnRad;
        /* 0x1DB8 */ public float PetMoodCurvePower;
        /* 0x1DC0 */ public GcScanEffectData PetOffPlanetEffect;
        /* 0x1E10 */ public NMSString0x80 PetEggResourceFile;
        /* 0x1E90 */ public NMSString0x80 PetEggHatchResourceFile;
        /* 0x1F10 */ public float PetEggHatchScale;
        /* 0x1F14 */ public float PetEggHatchOffset;
        /* 0x1F18 */ public float PetEggMaxLonely;
        /* 0x1F1C */ public float PetEggMaxHungry;
        /* 0x1F20 */ public float PetEggMinGrowthToLay;
        /* 0x1F24 */ public bool PetForceSummonFromEgg;
        /* 0x1F28 */ public NMSString0x10 PetEggsplosionEffect;
        /* 0x1F38 */ public bool RidingPositionTest;
        /* 0x1F39 */ public bool PetAnimTest;
        /* 0x1F3A */ public bool UsePetTeleportEffect;
        /* 0x1F3C */ public float PetTeleportEffectTime;
        /* 0x1F40 */ public float PetThrowArcRange;
        /* 0x1F50 */ public Colour PetThrowArcColour;
        /* 0x1F60 */ public float PetOrderMinRange;
        /* 0x1F64 */ public float PetOrderMaxRange;
        /* 0x1F68 */ public float PetAccessoryMoodDisplayThreshold;
        /* 0x1F6C */ public float PetAccessoryStateInterval;
        /* 0x1F70 */ public float PetInteractionLightHeight;
        /* 0x1F74 */ public float PetInteractionLightIntensityMin;
        /* 0x1F78 */ public float PetInteractionLightIntensityMax;
        /* 0x1F80 */ public Colour PetInteractionLightColour;
        /* 0x1F90 */ public float AnimChangeCoolDown;
        /* 0x1F94 */ public float GroupRunProbability;
        /* 0x1F98 */ public float GroupBabyRunProbability;
        /* 0x1F9C */ public float GroupRunStormProbability;
        /* 0x1FA0 */ public float GroupLookAtProbability;
        /* 0x1FA4 */ public float GroupLookAtDurationMin;
        /* 0x1FA8 */ public float GroupLookAtDurationMax;
        /* 0x1FAC */ public float GroupRunDurationMin;
        /* 0x1FB0 */ public float GroupRunDurationMax;
        /* 0x1FB4 */ public float GroupFemaleProportion;
        /* 0x1FB8 */ public float GroupBabyProportion;
        /* 0x1FBC */ public float GroupBabyScale;
        /* 0x1FC0 */ public float GroupBabyHealthMultiplier;
        /* 0x1FC4 */ public float MaxBirdsProportion;
        /* 0x1FC8 */ public float HerdGroupSizeMultiplier;
        /* 0x1FCC */ public bool DrawRoutineFollowDebug;
        /* 0x1FCD */ public bool DrawRoutineInfo;
        /* 0x1FD0 */ public float AdultCorrelationValue;
        /* 0x1FD4 */ public float GrassPushRadius;
        /* 0x1FD8 */ public float GrassPushMaxSize;
        /* 0x1FDC */ public bool DrawGrassPushRadius;
        /* 0x1FE0 */ public float CreatureIndoorSpeedMultiplier;
        /* 0x1FE4 */ public float CreatureSpeedMultiplier;
        /* 0x1FE8 */ public float PredatorSpeedMultiplier;
        /* 0x1FF0 */ public NMSString0x10 DefaultKillingSubstance;
        /* 0x2000 */ public NMSString0x10 AlienShipQuestKillingSubstance;
        /* 0x2010 */ public NMSString0x10 AlienShipQuestCreatureWeapon;
        /* 0x2020 */ public List<NMSString0x10> KillingSubstances;
        /* 0x2030 */ public int CreatureKillRewardAmountSmall;
        /* 0x2034 */ public int CreatureKillRewardAmountMed;
        /* 0x2038 */ public int CreatureKillRewardAmountLarge;
        /* 0x203C */ public int CreatureKillRewardAmountHuge;
        /* 0x2040 */ public List<GcCreatureSubstanceList> KillingProducts;
        /* 0x2050 */ public List<GcCreatureHarvestSubstanceList> HarvestingProducts;
        /* 0x2060 */ public int CreatureHarvestAmountSmall;
        /* 0x2064 */ public int CreatureHarvestAmountMed;
        /* 0x2068 */ public int CreatureHarvestAmountLarge;
        /* 0x206C */ public int CreatureHarvestAmountHuge;
        /* 0x2070 */ public float HarvestCooldownMin;
        /* 0x2074 */ public float HarvestCooldownMax;
        /* 0x2078 */ public NMSString0x10 BasicFeedingProduct;
        /* 0x2088 */ public NMSString0x10 RobotFeedingProduct;
        /* 0x2098 */ public bool AllBaitIsBasic;
        /* 0x2099 */ public bool CanAlwaysLayEgg;
        /* 0x20A0 */ public List<GcCreatureFoodList> HerbivoreFeedingProducts;
        /* 0x20B0 */ public List<GcCreatureFoodList> CarnivoreFeedingProducts;
        /* 0x20C0 */ public GcWeirdCreatureRewardList WeirdKillingRewards;
        /* 0x2270 */ public List<NMSString0x10> LootItems;
        /* 0x2280 */ public float RockTransformGlobalChance;
        /* 0x2288 */ public List<float> RockTransformChanceModifiers;
        /* 0x2298 */ public float AngryRockProportionNormal;
        /* 0x229C */ public float AngryRockProportionSurvival;
        /* 0x22A0 */ public int PauseBetweenCreatureSpawnRequests;
        /* 0x22A4 */ public float CreatureUpdateRateMultiplier;
    }
}

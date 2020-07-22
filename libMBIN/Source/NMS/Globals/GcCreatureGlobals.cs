using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x3370, GUID = 0xFE8B3BE8EF838E19)]
    public class GcCreatureGlobals : NMSTemplate
    {
        [NMS(Size = 0xA, EnumType = typeof(GcCreatureRoles.CreatureRoleEnum))]
        /* 0x0000 */ public NMSString0x20[] Temperments;
        [NMS(Size = 0xA, EnumType = typeof(GcCreatureRoles.CreatureRoleEnum))]
        /* 0x0140 */ public NMSString0x20[] TempermentDescriptions;
        [NMS(Size = 0x3)]
        /* 0x0280 */ public NMSString0x20[] Diets;
        [NMS(Size = 0x3)]
        /* 0x02E0 */ public NMSString0x20[] WaterDiets;
        [NMS(Size = 0xE)]
        /* 0x0340 */ public NMSString0x20[] DietMeat;
        [NMS(Size = 0xE)]
        /* 0x0500 */ public NMSString0x20[] DietVeg;
        [NMS(Size = 0x3)]
        /* 0x06C0 */ public NMSString0x20[] DietDescriptions;
        [NMS(Size = 0x3)]
        /* 0x0720 */ public NMSString0x20[] WaterDietDescriptions;
        [NMS(Size = 0xD)]
        /* 0x0780 */ public NMSString0x20[] BiomeDescriptions;
        [NMS(Size = 0xD)]
        /* 0x0920 */ public NMSString0x20[] BiomeWaterDescriptions;
        [NMS(Size = 0xD)]
        /* 0x0AC0 */ public NMSString0x20[] BiomeAirDescriptions;
        [NMS(Size = 0x14)]
        /* 0x0C60 */ public NMSString0x20[] WeirdBiomeDescriptions;
        /* 0xEE0 */ public bool OverrideIKParams;
        /* 0xEE4 */ public float BodyMassWeight;
        /* 0xEE8 */ public float Omega;
        /* 0xEEC */ public float OmegaDropOff;
        /* 0xEF0 */ public float MovementDamp;
        /* 0xEF4 */ public bool IsHurtingCreaturesACrime;
        /* 0xEF5 */ public bool EnableFlyingSnakeTails;
        /* 0xEF6 */ public bool EnableNewStuff;
        /* 0xEF7 */ public bool InstantCreatureRide;
        /* 0xEF8 */ public bool EnableVRCreatureRide;
        /* 0xEF9 */ public bool EnableMPCreatureRide;
        /* 0xEFC */ public float RidingReplicationRangeMultiplier;
        /* 0xF00 */ public float RidingRollAdjustMaxAngle;
        /* 0xF04 */ public float RidingRollMaxAngleAt;
        /* 0xF08 */ public float RidingFirstPersonOffsetFwd;
        /* 0xF0C */ public float RidingFirstPersonOffsetUp;
        /* 0xF10 */ public float CreatureScaleMangle;
        /* 0xF14 */ public bool CreatureRideDirectControl;
        /* 0xF15 */ public bool StaticCreatureRide;
        /* 0xF18 */ public float RideSpeedSlow;
        /* 0xF1C */ public float RideSpeedFast;
        /* 0xF20 */ public float RideSpeedChangeTime;
        /* 0xF24 */ public float RiderLeanTime;
        /* 0xF28 */ public float PostRideMoveTime;
        /* 0xF2C */ public float RideIdleTime;
        /* 0xF30 */ public float MinRideSize;
        /* 0xF34 */ public float MaxRideLeanCounterRotate;
        /* 0xF38 */ public float PetMinSummonDistance;
        /* 0xF3C */ public float PetMaxSummonDistance;
        /* 0xF40 */ public float PetSummonRotation;
        /* 0xF44 */ public float PlayerDamageTransferScale;
        /* 0xF48 */ public int CreatureSeed;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xF4C */ public byte[] PaddingF4C;
        [NMS(Size = 0x20)]
        /* 0xF50 */ public string CreatureFilter;
        /* 0x0F70 */ public int MaxEcosystemCreaturesNormal;
        /* 0x0F74 */ public int MaxEcosystemCreaturesLow;
        /* 0x0F78 */ public bool UncapSpawningforVideo;
        /* 0x0F79 */ public bool AllowSpawningOnscreen;
        /* 0x0F7C */ public float ResourceSpawnTime;
        /* 0x0F80 */ public float TurnInPlaceIdleTime;
        /* 0x0F84 */ public float TurnInPlaceMaxAngle;
        /* 0x0F88 */ public float TurnInPlaceMinTime;
        /* 0x0F8C */ public float TurnInPlaceMaxSpeed;
        /* 0x0F90 */ public float SceneTerrainSpawnMinDistance;
        /* 0x0F94 */ public float CreatureMinAlignSpeed;
        /* 0x0F98 */ public float PatrolMinDist;
        /* 0x0F9C */ public float PatrolMaxDist;
        /* 0x0FA0 */ public float PatrolHeightOffset;
        /* 0x0FA4 */ public float PatrolGradientFactor;
        /* 0x0FA8 */ public float CreatureWaryTime;
        /* 0x0FAC */ public float CreatureMinRunTime;
        /* 0x0FB0 */ public float CreatureHearingRange;
        /* 0x0FB4 */ public float CreatureSightRange;
        /* 0x0FB8 */ public float CreatureMoveIdle;
        /* 0x0FBC */ public float CreatureTurnMin;
        /* 0x0FC0 */ public float CreatureTurnMax;
        /* 0x0FC4 */ public float CreatureBrakeForce;
        /* 0x0FC8 */ public float CreatureMinAnimMoveSpeed;
        /* 0x0FCC */ public float CreatureLookBeforeGoingTime;
        /* 0x0FD0 */ public float CreatureLookBeforeFleeingTime;
        /* 0x0FD4 */ public float CreatureLookBeforeFleeingIfShotTime;
        /* 0x0FD8 */ public float CreatureLookScaryThingTime;
        /* 0x0FDC */ public float CreatureLookPlayerForceLookTime;
        /* 0x0FE0 */ public float FootPlantError;
        /* 0x0FE4 */ public float RecoverHealthTime;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x0FE8 */ public byte[] PaddingFE8;
        /* 0x0FF0 */ public GcCameraShakeData PainShake;
        /* 0x010B0 */ public float PatrolSwitchMinTime;
        /* 0x010B4 */ public float ExtraFollowStrength;
        /* 0x010B8 */ public float ExtraFollowFreq1;
        /* 0x010BC */ public float ExtraFollowFreq2;
        /* 0x010C0 */ public float GiantSnakeEmergeHeight;
        /* 0x010C4 */ public float GiantSnakeEmergeDeep;
        /* 0x010C8 */ public float GiantSnakeEmergeTime;
        /* 0x010CC */ public float GiantSnakeEmergeWide;
        /* 0x010D0 */ public float GiantSnakeEmergeUnderTime;
        /* 0x010D4 */ public float GiantSnakeEmergeOffset;
        /* 0x010D8 */ public float GiantSnakeRadius;
        /* 0x010DC */ public float GiantSnakeHeadOffset;
        /* 0x010E0 */ public float ShieldFadeTime;
        /* 0x010E4 */ public float SharkAlongPathSpeed;
        /* 0x010E8 */ public float SwarmBrakingForce;
        /* 0x010EC */ public float SharkToPathYDamp;
        /* 0x010F0 */ public float SharkAttackSpeed;
        /* 0x010F4 */ public float SharkAttackAccel;
        /* 0x010F8 */ public float SharkPatrolSpeed;
        /* 0x010FC */ public float SharkPatrolRadius;
        /* 0x01100 */ public float SharkPatrolEnd;
        /* 0x01104 */ public float SharkGetToPathSpeed;
        /* 0x01108 */ public float SharkAlignSpeed;
        /* 0x0110C */ public float FishBobFrequency;
        /* 0x01110 */ public float FishBobAmplitude;
        /* 0x01114 */ public float FreighterJellyBobFrequency;
        /* 0x01118 */ public float FreighterJellyBobAmplitude;
        /* 0x01114 */ public float InfluenceRadius;
        /* 0x01120 */ public float InfluenceForce;
        /* 0x01124 */ public float InfluenceThreshold;
        /* 0x01128 */ public float InfluenceDeflect;
        /* 0x0112C */ public float TargetSearchTimeout;
        /* 0x01130 */ public float AttractMinDistance;
        /* 0x01134 */ public float SwarmMoveYFactor;
        /* 0x01138 */ public float DroneExplodeRadius;
        /* 0x0113C */ public float WeaponRepelRange;
        /* 0x01140 */ public float WeaponRepelAmount;
        /* 0x01144 */ public float VelocityAlignStrength;
        /* 0x01148 */ public float VelocityAlignSpeed;
        /* 0x0114C */ public float HeightLookAhead;
        /* 0x01150 */ public float MaxHeightTime;
        /* 0x01154 */ public float PlayerBirdDistance;
        /* 0x01158 */ public float FishSpeedMin;
        /* 0x0115C */ public float FishSpeedMax;
        /* 0x01160 */ public float FishSwimMaxAcceleration;
        /* 0x01164 */ public float AlertDistance;
        /* 0x01168 */ public float RepelRange;
        /* 0x0116C */ public float RepelAmount;
        /* 0x01170 */ public float FishTurn;
        /* 0x01174 */ public float TargetReachedDistance;
        /* 0x01178 */ public float MaxSpeed;
        /* 0x0117C */ public float MaxForce;
        /* 0x01180 */ public float MaxTorque;
        /* 0x01184 */ public float MinWaterSpawnDepth;
        /* 0x01188 */ public float WaterSpawnOffset;
        /* 0x0118C */ public float SpawnDistanceModifierForUnderwater;
        /* 0x01190 */ public float FootDustGroundTintStrength;
        /* 0x01194 */ public float StickToGroundSpeed;
        /* 0x01198 */ public float StickToGroundCastBegin;
        /* 0x0119C */ public float StickToGroundCastEnd;
        /* 0x011A0 */ public GcFlyingSnakeData FlyingSnakeData;
        [NMS(Size = 0x04)]
        /* 0x011E0 */ public GcCreatureAlertData[] AlertTable;
        /* 0x01240 */ public bool ShowScale;
        /* 0x01244 */ public float CreatureMedMinSize;
        /* 0x01248 */ public float CreatureLargeMinSize;
        /* 0x0124C */ public float CreatureHugeMinSize;
		/* 0x1250 */ public float CreatureRidingMedMinSize;
		/* 0x1254 */ public float CreatureRidingLargeMinSize;
		/* 0x1258 */ public float CreatureRidingHugeMinSize;
		/* 0x125C */ public float CreatureBlobRidingMedMinSize;
		/* 0x1260 */ public float CreatureBlobRidingLargeMinSize;
		/* 0x1264 */ public float CreatureBlobRidingHugeMinSize;
        /* 0x01268 */ public int CreatureSmallHealth;
        /* 0x0126C */ public int CreatureMedHealth;
        /* 0x01270 */ public int CreatureLargeHealth;
        /* 0x01274 */ public int CreatureHugeHealth;
        [NMS(Size = 0x10)]
        /* 0x01278 */ public string CreatureLargeWalkShake;
        /* 0x01288 */ public float CreatureLargeWalkMaxShakeDist;
        [NMS(Size = 0x04, Ignore = true)]
        /* 0x0128C */ public byte[] Padding128C;
        [NMS(Size = 0x10)]
        /* 0x01290 */ public string CreatureLargeRunShake;
        /* 0x012A0 */ public float CreatureLargeRunMaxShakeDist;
        [NMS(Size = 0x04, Ignore = true)]
        /* 0x012A4 */ public byte[] Padding12A4;
        [NMS(Size = 0x10)]
        /* 0x012A8 */ public string CreatureHugeWalkShake;
        /* 0x012B8 */ public float CreatureHugeWalkMaxShakeDist;
        [NMS(Size = 0x04, Ignore = true)]
        /* 0x012BC */ public byte[] Padding12BC;
        [NMS(Size = 0x10)]
        /* 0x012C0 */ public string CreatureHugeRunShake;
        /* 0x012D0 */ public float CreatureHugeRunMaxShakeDist;
        /* 0x012D4 */ public float SmallCreaturePerceptionDistance;
        /* 0x012D8 */ public float largeCreaturePerceptionDistance;
        /* 0x012DC */ public float SmallCreatureFleePlayerDistance;
        /* 0x012E0 */ public float LargeCreatureFleePlayerDistance;
        /* 0x012E4 */ public float SmallCreatureAvoidPlayerDistance;
        /* 0x012E8 */ public float LargeCreatureAvoidPlayerDistance;
        /* 0x012EC */ public float PredatorPerceptionDistance;
        /* 0x012F0 */ public float PredatorFishPerceptionDistance;
        /* 0x012F4 */ public float PassiveFleePlayerDistance;
        /* 0x012F8 */ public float AdultBabyKilledNoticeDistance;
        /* 0x012FC */ public float PercentagePlayerPredators;
        /* 0x01300 */ public int PredatorSmallHealth;
        /* 0x01304 */ public int PredatorMedHealth;
        /* 0x01308 */ public int PredatorLargeHealth;
        /* 0x0130C */ public int PredatorHugeHealth;
        /* 0x01310 */ public float PlayerPredatorHealthModifier;
        /* 0x01314 */ public float PredatorApproachTime;
        /* 0x01318 */ public float PredatorNoticePauseTime;
        /* 0x0131C */ public float PredatorStealthDist;
        /* 0x01320 */ public float PredatorChargeDist;
        /* 0x01324 */ public float PredatorChargeDistScale;
        /* 0x01328 */ public float FishPredatorChargeDist;
        /* 0x0132C */ public float FishPredatorChargeDistScale;
        /* 0x01330 */ public float PredatorBoredomDistance;
        /* 0x01334 */ public float PlayerPredatorBoredomDistance;
        /* 0x01338 */ public float PredatorRegainInterestTime;
        /* 0x0133C */ public float PlayerPredatorRegainInterestTime;
        /* 0x01340 */ public float PredatorRunAwayDist;
        /* 0x01344 */ public float PredatorRoarProbAfterHit;
        /* 0x01348 */ public float PredatorRoarProbAfterMiss;
        /* 0x0134C */ public float PredatorRunAwayHealthPercent;
        /* 0x01350 */ public float PredatorEnergyRecoverRate;
        /* 0x01354 */ public float PredatorEnergyUseChasing;
        /* 0x01358 */ public bool AggressiveSharks;
		/* 0x135C */ public float DelayAfterRespawnBeforeAttackable;
		/* 0x1360 */ public float IndoorTurnTime;
		/* 0x1364 */ public float IndoorObstacleAvoidStrength;
		/* 0x1368 */ public float IndoorSteeringRayLength;
		/* 0x136C */ public float IndoorSteeringRaySphereSize;
		/* 0x1370 */ public float IndoorSteeringRaySpread;
		/* 0x1374 */ public float FreighterSpawnDist;
		/* 0x1378 */ public float FreighterDespawnDist;
		/* 0x137C */ public bool ScuttlersCanAttack;
		/* 0x1380 */ public int ScuttlerHealth;
		/* 0x1384 */ public float ScuttlerInitialNoAttackTime;
		/* 0x1388 */ public float ScuttlerMoveTimeMin;
		/* 0x138C */ public float ScuttlerMoveTimeMax;
		/* 0x1390 */ public float ScuttlerIdleTimeMin;
		/* 0x1394 */ public float ScuttlerIdleTimeMax;
		/* 0x1398 */ public float ScuttlerZigZagTimeMin;
		/* 0x139C */ public float ScuttlerZigZagTimeMax;
		/* 0x13A0 */ public float ScuttlerZigZagStrength;
		/* 0x13A4 */ public float ScuttlerSpitDelay;
		/* 0x13A8 */ public float ScuttlerSpitChargeTime;
		/* 0x13AC */ public float MiniDroneEnergyRecoverRate;
		/* 0x13B0 */ public float MiniDroneEnergyUsePerShot;
		/* 0x13B4 */ public float MiniDroneShotDelay;
		/* 0x13B8 */ public float MiniDroneShotMaxAngle;
		/* 0x13BC */ public bool FiendsCanAttack;
		/* 0x13BD */ public bool FiendOnscreenMarkers;
		/* 0x13C0 */ public int FiendHealth;
		/* 0x13C4 */ public float FiendPerceptionDistance;
		/* 0x13C8 */ public float FiendSpawnDistance;
		/* 0x13CC */ public float FiendDespawnDistance;
		/* 0x13D0 */ public float FiendReplicateStartDistance;
		/* 0x13D4 */ public float FiendReplicateEndDistance;
		/* 0x13D8 */ public float FiendAggroTime;
		/* 0x13DC */ public int FiendMaxEngaged;
		/* 0x13E0 */ public int FiendMaxAttackers;
		/* 0x13E4 */ public float DelayBetweenPounceAttacks;
		/* 0x13E8 */ public float DelayBetweenSpitAttacks;
		/* 0x13EC */ public float FiendMaxVerticalForPounce;
		/* 0x13F0 */ public float FiendZigZagSpeed;
		/* 0x13F4 */ public float FiendZigZagStrength;
		/* 0x13F8 */ public int FiendEggsToUnlockSpit;
		/* 0x13FC */ public int MaxFiendsToSpawn;
		/* 0x1400 */ public float FiendMinSpawnTime;
		/* 0x1404 */ public float FiendMaxSpawnTime;
		/* 0x1408 */ public float FiendAggroIncreaseDamageEgg;
		/* 0x140C */ public float FiendAggroIncreaseDestroyEgg;
		/* 0x1410 */ public float FiendAggroDecreasePerSpawn;
		/* 0x1414 */ public float FiendCritAreaSize;
		/* 0x1418 */ public float FiendDistToConsiderTargetSwtich;
		/* 0x141C */ public float FiendDistReduceForBeingShot;
		/* 0x1420 */ public float FiendBeingShotMemoryTime;
		/* 0x1424 */ public int MaxFishFiends;
		/* 0x1428 */ public int FishFiendSmallHealth;
		/* 0x142C */ public int FishFiendBigHealth;
		/* 0x1430 */ public float FishFiendSmallBoostStrength;
		/* 0x1434 */ public float FishFiendSmallBoostTime;
		/* 0x1438 */ public float FishFiendSmallScale;
		/* 0x143C */ public float FishFiendBigBoostStrength;
		/* 0x1440 */ public float FishFiendBigBoostTime;
		/* 0x1444 */ public float FishFiendBigScale;
		/* 0x1448 */ public float RoutineSpeed;
		/* 0x144C */ public float RoutineOffset;
		/* 0x1450 */ public float RagdollTau;
		/* 0x1454 */ public float RagdollDamping;
		/* 0x1458 */ public float RagdollConeLimit;
		/* 0x145C */ public float RagdollTwistLimit;
		/* 0x1460 */ public float RagdollMotorFadeStart;
		/* 0x1464 */ public float RagdollMotorFadeEnd;
		/* 0x1468 */ public int MaxRagdollsBeforeDespawnOffscreen;
		/* 0x146C */ public int MaxRagdollsBeforeDespawnOnscreen;
		/* 0x1470 */ public float RidingTurnRadiusMultiplier;
		/* 0x1474 */ public float TurnRadiusMultiplier;
		/* 0x1478 */ public float MaxTurnRadius;
		/* 0x147C */ public float TurnSlowAreaCos;
		/* 0x1480 */ public float BadTurnPercent;
		/* 0x1484 */ public float BadTurnWeight;
		/* 0x1488 */ public float MinScaleForNavMap;
		/* 0x148C */ public float ImpassabilityBrakeTime;
		/* 0x1490 */ public float ImpassabilityUnbrakeTime;
		/* 0x1494 */ public float ImpassabilityTurnSpeedMultiplier;
		/* 0x1498 */ public float NavMapLookAhead;
		/* 0x149C */ public float VelocityAlignYFactorMin;
		/* 0x14A0 */ public float VelocityAlignYFactorMax;
		/* 0x14A4 */ public float BrakingForce;
		/* 0x14A8 */ public float BrakingForceY;
		/* 0x14AC */ public float FlowFieldWeight;
		/* 0x14B0 */ public float FollowWeight;
		/* 0x14B4 */ public float RidingSteerWeight;
		/* 0x14B8 */ public float AvoidCreaturesWeight;
		/* 0x14BC */ public float AvoidImpassableWeight;
		/* 0x14C0 */ public float BaseAndTerrainModImpassableStrength;
		/* 0x14C4 */ public float FollowLeaderAlignWeight;
		/* 0x14C8 */ public float FollowLeaderCohereWeight;
		/* 0x14CC */ public float SoftenAvoidanceRadiusMod;
		/* 0x14D0 */ public float FreighterJellySwimSpeed;
		/* 0x14D4 */ public float DefaultSwimSpeed;
		/* 0x14D8 */ public float FastSwimSpeed;
		/* 0x14DC */ public float DefaultWalkMoveSpeed;
		/* 0x14E0 */ public float DefaultTrotMoveSpeed;
		/* 0x14E4 */ public float DefaultRunMoveSpeed;
		/* 0x14E8 */ public float PredatorWalkMoveSpeed;
		/* 0x14EC */ public float PredatorTrotMoveSpeed;
		/* 0x14F0 */ public float PredatorRunMoveSpeed;
		/* 0x14F4 */ public float HeightDiffPenalty;
		/* 0x14F8 */ public float EdgeClosenessPenalty;
		/* 0x14FC */ public float PelvisIkStrength;
		/* 0x1500 */ public float SteeringUpdateRate;
		/* 0x1504 */ public float PathOverestimate;
		/* 0x1508 */ public float FishWaterSurfaceAnticipate;
		/* 0x150C */ public float FishWaterSurfaceAvoidStrength;
		/* 0x1510 */ public float FishDesiredDepth;
		/* 0x1514 */ public float FishMinHeightAboveSeaBed;
		/* 0x1518 */ public float FishSeaBedAvoidStrength;
		/* 0x151C */ public float FishObstacleAvoidStrength;
		/* 0x1520 */ public float FishPlayerAttractionFrontDist;
		/* 0x1524 */ public float FishPlayerAttractionAhead;
		/* 0x1528 */ public float FishPlayerAttractionMinDist;
		/* 0x152C */ public float FishPlayerAttractionMaxDist;
		/* 0x1530 */ public float FishPlayerAttractionStrength;
		/* 0x1534 */ public float AttackPlayerDistance;
		/* 0x1538 */ public float SpawnCameraAngleCos;
		/* 0x153C */ public float SpawnMinDistPercentage;
		/* 0x1540 */ public float SpawnOnscreenDist;
		/* 0x1544 */ public float FadeScaleMultiplier;
		/* 0x1548 */ public float FadeScalePower;
		/* 0x154C */ public float FadeDistance;
		/* 0x1550 */ public float MinFade;
		/* 0x1554 */ public float MaxFade;
		/* 0x1558 */ public bool ProcessPendingSpawnRequests;
		/* 0x155C */ public float SpawnsAvoidBaseMultiplier;
		/* 0x1560 */ public int PerceptionUpdateRate;
		/* 0x1564 */ public bool AllowSleeping;
		/* 0x1565 */ public bool DebugDrawTrails;
		/* 0x1568 */ public float TrailHalfLife;
		/* 0x156C */ public bool EnableTrailIk;
		/* 0x1570 */ public float DetailAnimBlendInTime;
		/* 0x1574 */ public float DetailAnimBlendOutTime;
		/* 0x1578 */ public float DetailAnimMinPauseTime;
		/* 0x157C */ public float DetailAnimMaxPauseTime;
		/* 0x1580 */ public bool DetailAnimPlayWhileWalking;
        [NMS(Size = 0x07, Ignore = true)]
        /* 0x01581 */ public byte[] Padding1581;

        [NMS(Size = 0x10)]
        /* 0x01588 */ public string CreatureDeathEffectSmall;
        [NMS(Size = 0x10)]
        /* 0x01598 */ public string CreatureDeathEffectMedium;
        [NMS(Size = 0x10)]
        /* 0x015A8 */ public string CreatureDeathEffectBig;
        [NMS(Size = 0x10)]
        /* 0x015B8 */ public string FishDeathEffect;

        /* 0x015C8 */ public float FootParticleTime;
        /* 0x015CC */ public bool PiedPiper;
        /* 0x015D0 */ public float FollowPlayerDistance;
        /* 0x015D4 */ public float FollowRunPlayerDistance;
        /* 0x015D8 */ public float FollowRange;
        /* 0x015DC */ public float SearchItemDistance;
        /* 0x015E0 */ public float SearchItemFrequency;
        /* 0x015E4 */ public float SearchItemGiveUpDistance;
        /* 0x015E8 */ public float SearchItemGiveUpTime;
        /* 0x015EC */ public float SearchItemNotifyTime;
        /* 0x015F0 */ public float SearchSpawnRandomItemProbability;
        /* 0x015F4 */ public float MiningRandomProbability;
        /* 0x015F8 */ public bool DebugSearch;
        /* 0x015FC */ public int FriendlyCreatureLimit;
        /* 0x01600 */ public int FeedingTaskAmount;
        /* 0x01604 */ public float FeedingFollowTime;
        /* 0x01608 */ public float FeedingNoticeTime;
        /* 0x0160C */ public float FeedingNoticeDistance;
        /* 0x01610 */ public float AttractedMinAvoidCreaturesStrength;
        /* 0x01614 */ public float AttractedMinAvoidCreaturesDist;
        /* 0x01618 */ public float AttractedMaxAvoidCreaturesStrength;
        /* 0x0161C */ public float AttractedMaxAvoidCreaturesDist;
        /* 0x01620 */ public float AnimChangeCoolDown;
        /* 0x01624 */ public float GroupRunProbability;
        /* 0x01628 */ public float GroupBabyRunProbability;
        /* 0x0162C */ public float GroupRunStormProbability;
        /* 0x01630 */ public float GroupLookAtProbability;
        /* 0x01634 */ public float GroupLookAtDurationMin;
        /* 0x01638 */ public float GroupLookAtDurationMax;
        /* 0x0163C */ public float GroupRunDurationMin;
        /* 0x01640 */ public float GroupRunDurationMax;
        /* 0x01644 */ public float GroupFemaleProportion;
        /* 0x01648 */ public float GroupBabyProportion;
        /* 0x0164C */ public float GroupBabyScale;
        /* 0x01650 */ public float GroupBabyHealthMultiplier;
        /* 0x01654 */ public float MaxBirdsProportion;
        /* 0x01658 */ public float HerdGroupSizeMultiplier;
        /* 0x0165C */ public bool DrawRoutineFollowDebug;
        /* 0x01660 */ public float AdultCorrelationValue;
        /* 0x01664 */ public float GrassPushRadius;
        /* 0x01668 */ public float GrassPushStrength;
        /* 0x0166C */ public float GrassPushMaxSize;
        /* 0x01670 */ public bool DrawGrassPushRadius;

        [NMS(Size = 0x80)]
        /* 0x01671 */ public string DefaultCreatureSettings;
        [NMS(Size = 0x80)]
        /* 0x016F1 */ public string DefaultAirCreatureSettings;
        [NMS(Size = 0x80)]
        /* 0x01771 */ public string DefaultWaterCreatureSettings;

        /* 0x017F4 */ public float CreatureIndoorSpeedMultiplier;
        /* 0x017F8 */ public float CreatureSpeedMultiplier;
        /* 0x017FC */ public float PredatorSpeedMultiplier;
        [NMS(Size = 0x10)]
        /* 0x01800 */ public string DefaultKillingSubstance;
        [NMS(Size = 0x10)]
        /* 0x01810 */ public string AlienShipQuestKillingSubstance;
        [NMS(Size = 0x10)]
        /* 0x01820 */ public string AlienShipQuestCreatureWeapon;
        [NMS(Size = 0x3)]
        /* 0x01830 */ public NMSString0x10[] KillingSubstances;

        /* 0x01860 */ public int CreatureKillRewardAmountSmall;
        /* 0x01864 */ public int CreatureKillRewardAmountMed;
        /* 0x01868 */ public int CreatureKillRewardAmountLarge;
        /* 0x0186C */ public int CreatureKillRewardAmountHuge;
        // This enum is the GcCreatureTypes.CreatureTypeEnum with a few entries removed.
        public enum CreatureTypesEnum  { Fish, Antelope, Bird, Butterfly, FlyingSnake, FlyingLizard, Diplo, Triceratops, Rodent, Cow, Cat, Strider,
            Trex, Shark, TwoLegAntelope, SixLegCat, SixLegCow, Grunt, Blob, Spider, FloatSpider, SwimCow, SwimRodent, Jellyfish, Crab, RockCreature };
        [NMS(Size = 0x1A, EnumType = typeof(CreatureTypesEnum))]
        /* 0x01870 */ public GcCreatureSubstanceList[] KillingProducts;
        [NMS(Size = 0x1A, EnumType = typeof(CreatureTypesEnum))]
        /* 0x1BB0 */ public GcCreatureHarvestSubstanceList[] HarvestingProducts;
        /* 0x2CC0 */ public int CreatureHarvestAmountSmall;
        /* 0x2CC4 */ public int CreatureHarvestAmountMed;
        /* 0x2CC8 */ public int CreatureHarvestAmountLarge;
        /* 0x2CCC */ public int CreatureHarvestAmountHuge;
        /* 0x2CD0 */ public float HarvestCooldownMin;
        /* 0x2CD4 */ public float HarvestCooldownMax;
        [NMS(Size = 0x10)]
        /* 0x2CD8 */ public string BasicFeedingProduct;
        [NMS(Size = 0x4)]
        /* 0x2CE8 */ public GcCreatureFoodList[] HerbivoreFeedingProducts;
        [NMS(Size = 0x4)]
        /* 0x2F68 */ public GcCreatureFoodList[] CarnivoreFeedingProducts;

        /* 0x31E8 */ public GcWeirdCreatureRewardList WeirdKillingRewards;
        [NMS(Size = 0x3)]
        /* 0x3328 */ public NMSString0x10[] LootItems;
        /* 0x3358 */ public float RockTransformGlobalChance;
        [NMS(Size = 0x4)]
        /* 0x335C */ public float[] RockTransformChanceModifiers;
        /* 0x336C */ public int PauseBetweenCreatureSpawnRequests;
    }
}
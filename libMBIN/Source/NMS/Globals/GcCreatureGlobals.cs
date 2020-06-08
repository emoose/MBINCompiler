using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x32A0, GUID = 0xFF62BD70C8231C78)]
    public class GcCreatureGlobals : NMSTemplate
    {
        [NMS(Size = 0xA)]
        /* 0x0000 */ public NMSString0x20[] Temperments;
        [NMS(Size = 0xA)]
        /* 0x0140 */ public NMSString0x20[] TempermentDescriptions;
        [NMS(Size = 0x3)]
        /* 0x0280 */ public NMSString0x20[] Diets;
        [NMS(Size = 0x3)]
        /* 0x02E0 */ public NMSString0x20[] WaterDiets;
        [NMS(Size = 0xD)]
        /* 0x0340 */ public NMSString0x20[] DietMeat;
        [NMS(Size = 0xD)]
        /* 0x04E0 */ public NMSString0x20[] DietVeg;
        [NMS(Size = 0x3)]
        /* 0x0680 */ public NMSString0x20[] DietDescriptions;
        [NMS(Size = 0x3)]
        /* 0x06E0 */ public NMSString0x20[] WaterDietDescriptions;
        [NMS(Size = 0xD)]
        /* 0x0740 */ public NMSString0x20[] BiomeDescriptions;
        [NMS(Size = 0xD)]
        /* 0x08E0 */ public NMSString0x20[] BiomeWaterDescriptions;
        [NMS(Size = 0xD)]
        /* 0x0A80 */ public NMSString0x20[] BiomeAirDescriptions;
        [NMS(Size = 0x14)]
        /* 0x0C20 */ public NMSString0x20[] WeirdBiomeDescriptions;
        /* 0xEA0 */ public bool OverrideIKParams;
        /* 0xEA4 */ public float BodyMassWeight;
        /* 0xEA8 */ public float Omega;
        /* 0xEAC */ public float OmegaDropOff;
        /* 0xEB0 */ public float MovementDamp;
        /* 0xEB4 */ public bool IsHurtingCreaturesACrime;
        /* 0xEB5 */ public bool EnableFlyingSnakeTails;
        /* 0xEB6 */ public bool EnableNewStuff;
        /* 0xEB7 */ public bool InstantCreatureRide;
        /* 0xEB8 */ public bool EnableVRCreatureRide;
        /* 0xEB9 */ public bool EnableMPCreatureRide;
        /* 0xEBC */ public float RidingReplicationRangeMultiplier;
        /* 0xEC0 */ public float RidingRollAdjustMaxAngle;
        /* 0xEC4 */ public float RidingRollMaxAngleAt;
        /* 0xEC8 */ public float RidingFirstPersonOffsetFwd;
        /* 0xECC */ public float RidingFirstPersonOffsetUp;
        /* 0xED0 */ public float CreatureScaleMangle;
        /* 0xED4 */ public bool CreatureRideDirectControl;
        /* 0xED5 */ public bool StaticCreatureRide;
        /* 0xED8 */ public float RideSpeedSlow;
        /* 0xEDC */ public float RideSpeedFast;
        /* 0xEE0 */ public float RideSpeedChangeTime;
        /* 0xEE4 */ public float RiderLeanTime;
        /* 0xEE8 */ public float PostRideMoveTime;
        /* 0xEEC */ public float RideIdleTime;
        /* 0xEF0 */ public float MinRideSize;
        /* 0xEF4 */ public float MaxRideLeanCounterRotate;
        /* 0xEF8 */ public float PlayerDamageTransferScale;
        /* 0xEFC */ public int CreatureSeed;
        [NMS(Size = 0x20)]
        /* 0xF00 */ public string CreatureFilter;
        /* 0x0F20 */ public int MaxEcosystemCreaturesNormal;
        /* 0x0F24 */ public int MaxEcosystemCreaturesLow;
        /* 0x0F28 */ public bool UncapSpawningforVideo;
        /* 0x0F29 */ public bool AllowSpawningOnscreen;
        /* 0x0F2C */ public float ResourceSpawnTime;
        /* 0x0F30 */ public float TurnInPlaceIdleTime;
        /* 0x0F34 */ public float TurnInPlaceMaxAngle;
        /* 0x0F38 */ public float TurnInPlaceMinTime;
        /* 0x0F3C */ public float TurnInPlaceMaxSpeed;
        /* 0x0F40 */ public float SceneTerrainSpawnMinDistance;
        /* 0x0F44 */ public float CreatureMinAlignSpeed;
        /* 0x0F48 */ public float PatrolMinDist;
        /* 0x0F4C */ public float PatrolMaxDist;
        /* 0x0F50 */ public float PatrolHeightOffset;
        /* 0x0F54 */ public float PatrolGradientFactor;
        /* 0x0F58 */ public float CreatureWaryTime;
        /* 0x0F5C */ public float CreatureMinRunTime;
        /* 0x0F60 */ public float CreatureHearingRange;
        /* 0x0F64 */ public float CreatureSightRange;
        /* 0x0F68 */ public float CreatureMoveIdle;
        /* 0x0F6C */ public float CreatureTurnMin;
        /* 0x0F70 */ public float CreatureTurnMax;
        /* 0x0F74 */ public float CreatureBrakeForce;
        /* 0x0F78 */ public float CreatureMinAnimMoveSpeed;
        /* 0x0F7C */ public float CreatureLookBeforeGoingTime;
        /* 0x0F80 */ public float CreatureLookBeforeFleeingTime;
        /* 0x0F84 */ public float CreatureLookBeforeFleeingIfShotTime;
        /* 0x0F88 */ public float CreatureLookScaryThingTime;
        /* 0x0F8C */ public float CreatureLookPlayerForceLookTime;
        /* 0x0F90 */ public float FootPlantError;
        /* 0x0F94 */ public float RecoverHealthTime;
        [NMS(Size = 0x08, Ignore = true)]
        /* 0x0F98 */ public byte[] PaddingF98;
        /* 0x0FA0 */ public GcCameraShakeData PainShake;
        /* 0x01060 */ public float PatrolSwitchMinTime;
        /* 0x01064 */ public float ExtraFollowStrength;
        /* 0x01068 */ public float ExtraFollowFreq1;
        /* 0x0106C */ public float ExtraFollowFreq2;
        /* 0x01070 */ public float GiantSnakeEmergeHeight;
        /* 0x01074 */ public float GiantSnakeEmergeDeep;
        /* 0x01078 */ public float GiantSnakeEmergeTime;
        /* 0x0107C */ public float GiantSnakeEmergeWide;
        /* 0x01080 */ public float GiantSnakeEmergeUnderTime;
        /* 0x01084 */ public float GiantSnakeEmergeOffset;
        /* 0x01088 */ public float GiantSnakeRadius;
        /* 0x0108C */ public float GiantSnakeHeadOffset;
        /* 0x01090 */ public float ShieldFadeTime;
        /* 0x01094 */ public float SharkAlongPathSpeed;
        /* 0x01098 */ public float SwarmBrakingForce;
        /* 0x0109C */ public float SharkToPathYDamp;
        /* 0x010A0 */ public float SharkAttackSpeed;
        /* 0x010A4 */ public float SharkAttackAccel;
        /* 0x010A8 */ public float SharkPatrolSpeed;
        /* 0x010AC */ public float SharkPatrolRadius;
        /* 0x010B0 */ public float SharkPatrolEnd;
        /* 0x010B4 */ public float SharkGetToPathSpeed;
        /* 0x010B8 */ public float SharkAlignSpeed;
        /* 0x010BC */ public float FishBobFrequency;
        /* 0x010C0 */ public float FishBobAmplitude;
        /* 0x010C4 */ public float InfluenceRadius;
        /* 0x010C8 */ public float InfluenceForce;
        /* 0x010CC */ public float InfluenceThreshold;
        /* 0x010D0 */ public float InfluenceDeflect;
        /* 0x010D4 */ public float TargetSearchTimeout;
        /* 0x010D8 */ public float AttractMinDistance;
        /* 0x010DC */ public float SwarmMoveYFactor;
        /* 0x010E0 */ public float DroneExplodeRadius;
        /* 0x010E4 */ public float WeaponRepelRange;
        /* 0x010E8 */ public float WeaponRepelAmount;
        /* 0x010EC */ public float VelocityAlignStrength;
        /* 0x010F0 */ public float VelocityAlignSpeed;
        /* 0x010F4 */ public float HeightLookAhead;
        /* 0x010F8 */ public float MaxHeightTime;
        /* 0x010FC */ public float PlayerBirdDistance;
        /* 0x01100 */ public float FishSpeedMin;
        /* 0x01104 */ public float FishSpeedMax;
        /* 0x01108 */ public float FishSwimMaxAcceleration;
        /* 0x0110C */ public float AlertDistance;
        /* 0x01110 */ public float RepelRange;
        /* 0x01114 */ public float RepelAmount;
        /* 0x01118 */ public float FishTurn;
        /* 0x0111C */ public float TargetReachedDistance;
        /* 0x01120 */ public float MaxSpeed;
        /* 0x01124 */ public float MaxForce;
        /* 0x01128 */ public float MaxTorque;
        /* 0x0112C */ public float MinWaterSpawnDepth;
        /* 0x01130 */ public float WaterSpawnOffset;
        /* 0x01134 */ public float SpawnDistanceModifierForUnderwater;
        /* 0x01138 */ public float FootDustGroundTintStrength;
        /* 0x0113C */ public float StickToGroundSpeed;
        /* 0x01140 */ public float StickToGroundCastBegin;
        /* 0x01144 */ public float StickToGroundCastEnd;
        /* 0x01148 */ public GcFlyingSnakeData FlyingSnakeData;
        [NMS(Size = 0x04)]
        /* 0x01188 */ public GcCreatureAlertData[] AlertTable;
        /* 0x011E8 */ public bool ShowScale;
        /* 0x011EC */ public float CreatureMedMinSize;
        /* 0x011F0 */ public float CreatureLargeMinSize;
        /* 0x011F4 */ public float CreatureHugeMinSize;
		/* 0x11F8 */ public float CreatureRidingMedMinSize;
		/* 0x11FC */ public float CreatureRidingLargeMinSize;
		/* 0x1200 */ public float CreatureRidingHugeMinSize;
		/* 0x1204 */ public float CreatureBlobRidingMedMinSize;
		/* 0x1208 */ public float CreatureBlobRidingLargeMinSize;
		/* 0x120C */ public float CreatureBlobRidingHugeMinSize;
        /* 0x01210 */ public int CreatureSmallHealth;
        /* 0x01214 */ public int CreatureMedHealth;
        /* 0x01218 */ public int CreatureLargeHealth;
        /* 0x0121C */ public int CreatureHugeHealth;
        [NMS(Size = 0x10)]
        /* 0x01220 */ public string CreatureLargeWalkShake;
        /* 0x01230 */ public float CreatureLargeWalkMaxShakeDist;
        [NMS(Size = 0x04, Ignore = true)]
        /* 0x01234 */ public byte[] Padding1234;
        [NMS(Size = 0x10)]
        /* 0x01238 */ public string CreatureLargeRunShake;
        /* 0x01248 */ public float CreatureLargeRunMaxShakeDist;
        [NMS(Size = 0x04, Ignore = true)]
        /* 0x0124C */ public byte[] Padding124C;
        [NMS(Size = 0x10)]
        /* 0x01250 */ public string CreatureHugeWalkShake;
        /* 0x01260 */ public float CreatureHugeWalkMaxShakeDist;
        [NMS(Size = 0x04, Ignore = true)]
        /* 0x01264 */ public byte[] Padding1264;
        [NMS(Size = 0x10)]
        /* 0x01268 */ public string CreatureHugeRunShake;
        /* 0x01278 */ public float CreatureHugeRunMaxShakeDist;
        /* 0x0127C */ public float SmallCreaturePerceptionDistance;
        /* 0x01280 */ public float largeCreaturePerceptionDistance;
        /* 0x01284 */ public float SmallCreatureFleePlayerDistance;
        /* 0x01288 */ public float LargeCreatureFleePlayerDistance;
        /* 0x0128C */ public float SmallCreatureAvoidPlayerDistance;
        /* 0x01290 */ public float LargeCreatureAvoidPlayerDistance;
        /* 0x01294 */ public float PredatorPerceptionDistance;
        /* 0x01298 */ public float PredatorFishPerceptionDistance;
        /* 0x0129C */ public float PassiveFleePlayerDistance;
        /* 0x012A0 */ public float AdultBabyKilledNoticeDistance;
        /* 0x012A4 */ public float PercentagePlayerPredators;
        /* 0x012A8 */ public int PredatorSmallHealth;
        /* 0x012AC */ public int PredatorMedHealth;
        /* 0x012B0 */ public int PredatorLargeHealth;
        /* 0x012B4 */ public int PredatorHugeHealth;
        /* 0x012B8 */ public float PlayerPredatorHealthModifier;
        /* 0x012BC */ public float PredatorApproachTime;
        /* 0x012C0 */ public float PredatorNoticePauseTime;
        /* 0x012C4 */ public float PredatorStealthDist;
        /* 0x012C8 */ public float PredatorChargeDist;
        /* 0x012CC */ public float PredatorChargeDistScale;
        /* 0x012D0 */ public float FishPredatorChargeDist;
        /* 0x012D4 */ public float FishPredatorChargeDistScale;
        /* 0x012D8 */ public float PredatorBoredomDistance;
        /* 0x012DC */ public float PlayerPredatorBoredomDistance;
        /* 0x012E0 */ public float PredatorRegainInterestTime;
        /* 0x012E4 */ public float PlayerPredatorRegainInterestTime;
        /* 0x012E8 */ public float PredatorRunAwayDist;
        /* 0x012EC */ public float PredatorRoarProbAfterHit;
        /* 0x012F0 */ public float PredatorRoarProbAfterMiss;
        /* 0x012F4 */ public float PredatorRunAwayHealthPercent;
        /* 0x012F8 */ public float PredatorEnergyRecoverRate;
        /* 0x012FC */ public float PredatorEnergyUseChasing;
        /* 0x01300 */ public bool AggressiveSharks;
        /* 0x01304 */ public float DelayAfterRespawnBeforeAttackable;
        /* 0x01308 */ public bool FiendsCanAttack;
        /* 0x01309 */ public bool FiendOnscreenMarkers;
        /* 0x0130C */ public int FiendHealth;
        /* 0x01310 */ public float FiendPerceptionDistance;
        /* 0x01314 */ public float FiendSpawnDistance;
        /* 0x01318 */ public float FiendDespawnDistance;
        /* 0x0131C */ public float FiendReplicateStartDistance;
        /* 0x01320 */ public float FiendReplicateEndDistance;
        /* 0x01324 */ public float FiendAggroTime;
        /* 0x01328 */ public int FiendMaxEngaged;
        /* 0x0132C */ public int FiendMaxAttackers;
        /* 0x01330 */ public float DelayBetweenPounceAttacks;
        /* 0x01334 */ public float DelayBetweenSpitAttacks;
        /* 0x01338 */ public float FiendMaxVerticalForPounce;
        /* 0x0133C */ public float FiendZigZagSpeed;
        /* 0x01340 */ public float FiendZigZagStrength;
        /* 0x01344 */ public int FiendEggsToUnlockSpit;
        /* 0x01348 */ public int MaxFiendsToSpawn;
        /* 0x0134C */ public float FiendMinSpawnTime;
        /* 0x01350 */ public float FiendMaxSpawnTime;
        /* 0x01354 */ public float FiendAggroIncreaseDamageEgg;
        /* 0x01358 */ public float FiendAggroIncreaseDestroyEgg;
        /* 0x0135C */ public float FiendAggroDecreasePerSpawn;
        /* 0x01360 */ public float FiendCritAreaSize;
        /* 0x01364 */ public float FiendDistToConsiderTargetSwtich;
        /* 0x01368 */ public float FiendDistReduceForBeingShot;
        /* 0x0136C */ public float FiendBeingShotMemoryTime;
        /* 0x01370 */ public int MaxFishFiends;
        /* 0x01374 */ public int FishFiendSmallHealth;
        /* 0x01378 */ public int FishFiendBigHealth;
        /* 0x0137C */ public float FishFiendSmallBoostStrength;
        /* 0x01380 */ public float FishFiendSmallBoostTime;
        /* 0x01384 */ public float FishFiendSmallScale;
        /* 0x01388 */ public float FishFiendBigBoostStrength;
        /* 0x0138C */ public float FishFiendBigBoostTime;
        /* 0x01390 */ public float FishFiendBigScale;
        /* 0x01394 */ public float RoutineSpeed;
        /* 0x01398 */ public float RoutineOffset;
        /* 0x0139C */ public float RagdollTau;
        /* 0x013A0 */ public float RagdollDamping;
        /* 0x013A4 */ public float RagdollConeLimit;
        /* 0x013A8 */ public float RagdollTwistLimit;
        /* 0x013AC */ public float RagdollMotorFadeStart;
        /* 0x013B0 */ public float RagdollMotorFadeEnd;
        /* 0x013B4 */ public int MaxRagdollsBeforeDespawnOffscreen;
        /* 0x013B8 */ public int MaxRagdollsBeforeDespawnOnscreen;
        /* 0x013BC */ public float RidingTurnRadiusMultiplier;
        /* 0x013C0 */ public float TurnRadiusMultiplier;
        /* 0x013C4 */ public float MaxTurnRadius;
        /* 0x013C8 */ public float TurnSlowAreaCos;
        /* 0x013CC */ public float BadTurnPercent;
        /* 0x013D0 */ public float BadTurnWeight;
        /* 0x013D4 */ public float MinScaleForNavMap;
        /* 0x013D8 */ public float ImpassabilityBrakeTime;
        /* 0x013DC */ public float ImpassabilityUnbrakeTime;
        /* 0x013E0 */ public float ImpassabilityTurnSpeedMultiplier;
        /* 0x013E4 */ public float NavMapLookAhead;
        /* 0x013E8 */ public float VelocityAlignYFactorMin;
        /* 0x013EC */ public float VelocityAlignYFactorMax;
        /* 0x013F0 */ public float BrakingForce;
        /* 0x013F4 */ public float BrakingForceY;
        /* 0x013F8 */ public float FlowFieldWeight;
        /* 0x013FC */ public float FollowWeight;
        /* 0x01400 */ public float RidingSteerWeight;
        /* 0x01404 */ public float AvoidCreaturesWeight;
        /* 0x01408 */ public float AvoidImpassableWeight;
        /* 0x0140C */ public float BaseAndTerrainModImpassableStrength;
        /* 0x01410 */ public float FollowLeaderAlignWeight;
        /* 0x01414 */ public float FollowLeaderCohereWeight;
        /* 0x01418 */ public float SoftenAvoidanceRadiusMod;
        /* 0x0141C */ public float DefaultSwimSpeed;
        /* 0x01420 */ public float FastSwimSpeed;
        /* 0x01424 */ public float DefaultWalkMoveSpeed;
        /* 0x01428 */ public float DefaultTrotMoveSpeed;
        /* 0x0142C */ public float DefaultRunMoveSpeed;
        /* 0x01430 */ public float PredatorWalkMoveSpeed;
        /* 0x01434 */ public float PredatorTrotMoveSpeed;
        /* 0x01438 */ public float PredatorRunMoveSpeed;
        /* 0x0143C */ public float HeightDiffPenalty;
        /* 0x01440 */ public float EdgeClosenessPenalty;
        /* 0x01444 */ public float PelvisIkStrength;
        /* 0x01448 */ public float SteeringUpdateRate;
        /* 0x0144C */ public float PathOverestimate;
        /* 0x01450 */ public float FishWaterSurfaceAnticipate;
        /* 0x01454 */ public float FishWaterSurfaceAvoidStrength;
        /* 0x01458 */ public float FishDesiredDepth;
        /* 0x0145C */ public float FishMinHeightAboveSeaBed;
        /* 0x01460 */ public float FishSeaBedAvoidStrength;
        /* 0x01464 */ public float FishObstacleAvoidStrength;
        /* 0x01468 */ public float FishPlayerAttractionFrontDist;
        /* 0x0146C */ public float FishPlayerAttractionAhead;
        /* 0x01470 */ public float FishPlayerAttractionMinDist;
        /* 0x01474 */ public float FishPlayerAttractionMaxDist;
        /* 0x01478 */ public float FishPlayerAttractionStrength;
        /* 0x0147C */ public float AttackPlayerDistance;
        /* 0x01480 */ public float SpawnCameraAngleCos;
        /* 0x01484 */ public float SpawnMinDistPercentage;
        /* 0x01488 */ public float SpawnOnscreenDist;
        /* 0x0148C */ public float FadeScaleMultiplier;
        /* 0x01490 */ public float FadeScalePower;
        /* 0x01494 */ public float FadeDistance;
        /* 0x01498 */ public float MinFade;
        /* 0x0149C */ public float MaxFade;
        /* 0x014A0 */ public bool ProcessPendingSpawnRequests;
        /* 0x014A4 */ public float SpawnsAvoidBaseMultiplier;
        /* 0x014A8 */ public int PerceptionUpdateRate;
        /* 0x014AC */ public bool AllowSleeping;
        /* 0x014AD */ public bool DebugDrawTrails;
        /* 0x014B0 */ public float TrailHalfLife;
        /* 0x014B4 */ public bool EnableTrailIk;
        /* 0x014B8 */ public float DetailAnimBlendInTime;
        /* 0x014BC */ public float DetailAnimBlendOutTime;
        /* 0x014C0 */ public float DetailAnimMinPauseTime;
        /* 0x014C4 */ public float DetailAnimMaxPauseTime;
        /* 0x014C8 */ public bool DetailAnimPlayWhileWalking;
        [NMS(Size = 0x07, Ignore = true)]
        /* 0x014C9 */ public byte[] Padding14C9;

        [NMS(Size = 0x10)]
        /* 0x014D0 */ public string CreatureDeathEffectSmall;
        [NMS(Size = 0x10)]
        /* 0x014E0 */ public string CreatureDeathEffectMedium;
        [NMS(Size = 0x10)]
        /* 0x014F0 */ public string CreatureDeathEffectBig;
        [NMS(Size = 0x10)]
        /* 0x01500 */ public string FishDeathEffect;

        /* 0x01510 */ public float FootParticleTime;
        /* 0x01514 */ public bool PiedPiper;
        /* 0x01518 */ public float FollowPlayerDistance;
        /* 0x0151C */ public float FollowRunPlayerDistance;
        /* 0x01520 */ public float FollowRange;
        /* 0x01524 */ public float SearchItemDistance;
        /* 0x01528 */ public float SearchItemFrequency;
        /* 0x0152C */ public float SearchItemGiveUpDistance;
        /* 0x01530 */ public float SearchItemGiveUpTime;
        /* 0x01534 */ public float SearchItemNotifyTime;
        /* 0x01538 */ public float SearchSpawnRandomItemProbability;
        /* 0x0153C */ public float MiningRandomProbability;
        /* 0x01540 */ public bool DebugSearch;
        /* 0x01544 */ public int FriendlyCreatureLimit;
        /* 0x01548 */ public int FeedingTaskAmount;
        /* 0x0154C */ public float FeedingFollowTime;
        /* 0x01550 */ public float FeedingNoticeTime;
        /* 0x01554 */ public float FeedingNoticeDistance;
        /* 0x01558 */ public float AttractedMinAvoidCreaturesStrength;
        /* 0x0155C */ public float AttractedMinAvoidCreaturesDist;
        /* 0x01560 */ public float AttractedMaxAvoidCreaturesStrength;
        /* 0x01564 */ public float AttractedMaxAvoidCreaturesDist;
        /* 0x01568 */ public float AnimChangeCoolDown;
        /* 0x0156C */ public float GroupRunProbability;
        /* 0x01570 */ public float GroupBabyRunProbability;
        /* 0x01574 */ public float GroupRunStormProbability;
        /* 0x01578 */ public float GroupLookAtProbability;
        /* 0x0157C */ public float GroupLookAtDurationMin;
        /* 0x01580 */ public float GroupLookAtDurationMax;
        /* 0x01584 */ public float GroupRunDurationMin;
        /* 0x01588 */ public float GroupRunDurationMax;
        /* 0x0158C */ public float GroupFemaleProportion;
        /* 0x01590 */ public float GroupBabyProportion;
        /* 0x01594 */ public float GroupBabyScale;
        /* 0x01598 */ public float GroupBabyHealthMultiplier;
        /* 0x0159C */ public float MaxBirdsProportion;
        /* 0x015A0 */ public float HerdGroupSizeMultiplier;
        /* 0x015A4 */ public bool DrawRoutineFollowDebug;
        [NMS(Size = 0x03, Ignore = true)]
        /* 0x015A5 */ public byte[] Padding15A5;
        /* 0x015A8 */ public float AdultCorrelationValue;
        /* 0x015AC */ public float GrassPushRadius;
        /* 0x015B0 */ public float GrassPushStrength;
        /* 0x015B4 */ public float GrassPushMaxSize;
        /* 0x015B8 */ public bool DrawGrassPushRadius;

        [NMS(Size = 0x80)]
        /* 0x015B9 */ public string DefaultCreatureSettings;
        [NMS(Size = 0x80)]
        /* 0x01639 */ public string DefaultAirCreatureSettings;
        [NMS(Size = 0x80)]
        /* 0x016B9 */ public string DefaultWaterCreatureSettings;

        [NMS(Size = 0x03, Ignore = true)]
        /* 0x01739 */ public byte[] Padding1739;
        /* 0x0173C */ public float CreatureSpeedMultiplier;
        /* 0x01740 */ public float PredatorSpeedMultiplier;
        [NMS(Size = 0x04, Ignore = true)]
        /* 0x01744 */ public byte[] Padding1744;
        [NMS(Size = 0x6)]
        /* 0x01748 */ public NMSString0x10[] KillingSubstances;

        /* 0x017A8 */ public int CreatureKillRewardAmountSmall;
        /* 0x017AC */ public int CreatureKillRewardAmountMed;
        /* 0x017B0 */ public int CreatureKillRewardAmountLarge;
        /* 0x017B4 */ public int CreatureKillRewardAmountHuge;
        // This enum is the GcCreatureTypes.CreatureTypeEnum with a few entries removed.
        public enum CreatureTypesEnum  { Fish, Antelope, Bird, Butterfly, FlyingSnake, FlyingLizard, Diplo, Triceratops, Rodent, Cow, Cat, Strider,
            Trex, Shark, TwoLegAntelope, SixLegCat, SixLegCow, Grunt, Blob, Spider, FloatSpider, SwimCow, SwimRodent, Jellyfish, Crab, RockCreature };
        [NMS(Size = 0x1A, EnumType = typeof(CreatureTypesEnum))]
        /* 0x017B8 */ public GcCreatureSubstanceList[] KillingProducts;
        [NMS(Size = 0x1A, EnumType = typeof(CreatureTypesEnum))]
        /* 0x1AF8 */ public GcCreatureHarvestSubstanceList[] HarvestingProducts;
        /* 0x2C08 */ public int CreatureHarvestAmountSmall;
        /* 0x2C0C */ public int CreatureHarvestAmountMed;
        /* 0x2C10 */ public int CreatureHarvestAmountLarge;
        /* 0x2C14 */ public int CreatureHarvestAmountHuge;
        /* 0x2C18 */ public float HarvestCooldownMin;
        /* 0x2C1C */ public float HarvestCooldownMax;
        // NOTE: In the exe the "BasicFeedingProduct" is listed first, however this doesn't match the file so...
        [NMS(Size = 0x4)]
        /* 0x2C20 */ public GcCreatureFoodList[] HerbivoreFeedingProducts;
        [NMS(Size = 0x4)]
        /* 0x2EA0 */ public GcCreatureFoodList[] CarnivoreFeedingProducts;
        [NMS(Size = 0x10)]
        /* 0x3120 */ public string BasicFeedingProduct;
        /* 0x3130 */ public GcWeirdCreatureRewardList WeirdKillingRewards;
        [NMS(Size = 0x3)]
        /* 0x3270 */ public NMSString0x10[] LootItems;
        /* 0x32A0 */ public float RockTransformGlobalChance;
        [NMS(Size = 0x4)]
        /* 0x32A4 */ public float[] RockTransformChanceModifiers;
        /* 0x32B4 */ public int PauseBetweenCreatureSpawnRequests;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x32B8 */ public byte[] EndPadding;
    }
}
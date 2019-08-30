using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS( GUID = 0xBE62E572462B9D7D)]
    public class GcCreatureGlobals : NMSTemplate
    {
        [NMS(Size = 0x5B)]
        /* 0x0000 */ public NMSString0x20[] Unknown0x0;
        /* 0x0B60 */ public bool IsHurtingCreaturesACrime;
        /* 0x0B61 */ public bool EnableFlyingSnakeTails;
        /* 0x0B62 */ public bool EnableNewStuff;
        /* 0x0B63 */ public bool Unknown0xB63;
        /* 0x0B64 */ public bool Unknown0xB64;
        /* 0x0B65 */ public bool Unknown0xB65;
        /* 0x0B66 */ public bool Unknown0xB66;
        /* 0x0B68 */ public float Unknown0xB68;
        /* 0x0B6C */ public float Unknown0xB6C;
        /* 0x0B70 */ public float Unknown0xB70;
        /* 0x0B74 */ public float Unknown0xB74;
        /* 0x0B78 */ public bool Unknown0xB78;
        /* 0x0B7C */ public float Unknown0xB7C;
        /* 0x0B80 */ public float Unknown0xB80;
        /* 0x0B84 */ public float Unknown0xB84;
        /* 0x0B88 */ public float Unknown0xB88;
        /* 0x0B8C */ public float Unknown0xB8C;
        /* 0x0B90 */ public float Unknown0xB90;
        /* 0x0B94 */ public float Unknown0xB94;
        /* 0x0B98 */ public float Unknown0xB98;
        /* 0x0B9C */ public float Unknown0xB9C;
        /* 0x0BA0 */ public float Unknown0xBA0;
        /* 0x0BA4 */ public float Unknown0xBA4;
        /* 0x0BA8 */ public float Unknown0xBA8;
        /* 0x0BAC */ public float Unknown0xBAC;
        /* 0x0BB0 */ public float Unknown0xBB0;
        /* 0x0BB4 */ public float Unknown0xBB4;
        /* 0x0BB8 */ public float Unknown0xBB8;
        /* 0x0BBC */ public int CreatureSeed;
        /* 0x0BC0 */ public int MaxEcosystemCreatures;
        /* 0x0BC4 */ public int UnknownInt0xBC4;
        /* 0x0BC8 */ public bool UncapSpawningforVideo;
        /* 0x0BC9 */ public bool AllowSpawningOnscreen;
        /* 0x0BCC */ public float ResourceSpawnTime;
        /* 0x0BD0 */ public float TurnInPlaceIdleTime;
        /* 0x0BD4 */ public float TurnInPlaceMaxAngle;
        /* 0x0BD8 */ public float TurnInPlaceMinTime;
        /* 0x0BDC */ public float TurnInPlaceMaxSpeed;
        /* 0x0BE0 */ public float SceneTerrainSpawnMinDistance;
        /* 0x0BE4 */ public float CreatureMinAlignSpeed;
        /* 0x0BE8 */ public float PatrolMinDist;
        /* 0x0BEC */ public float PatrolMaxDist;
        /* 0x0BF0 */ public float PatrolHeightOffset;
        /* 0x0BF4 */ public float PatrolGradientFactor;
        /* 0x0BF8 */ public float CreatureWaryTime;
        /* 0x0BFC */ public float CreatureMinRunTime;
        /* 0x0C00 */ public float CreatureHearingRange;
        /* 0x0C04 */ public float CreatureSightRange;
        /* 0x0C08 */ public float CreatureMoveIdle;         // this value may be swapped with the following two as the order looks wrong now...
        /* 0x0C0C */ public float CreatureTurnMin;
        /* 0x0C10 */ public float CreatureTurnMax;
        /* 0x0C14 */ public float CreatureBrakeForce;
        /* 0x0C18 */ public float CreatureMinAnimMoveSpeed;
        /* 0x0C1C */ public float CreatureLookBeforeGoingTime;
        /* 0x0C20 */ public float CreatureLookBeforeFleeingTime;
        /* 0x0C24 */ public float CreatureLookBeforeFleeingIfShotTime;
        /* 0x0C28 */ public float CreatureLookScaryThingTime;
        /* 0x0C2C */ public float CreatureLookPlayerForceLookTime;
        /* 0x0C30 */ public float FootPlantError;
        /* 0x0C34 */ public float RecoverHealthTime;
        [NMS(Size = 0x08, Ignore = true)]
        /* 0x0C38 */ public byte[] PaddingC38;
        /* 0x0C40 */ public GcCameraShakeData PainShake;
        /* 0x0D00 */ public float PatrolSwitchMinTime;
        /* 0x0D04 */ public float ExtraFollowStrength;
        /* 0x0D08 */ public float ExtraFollowFreq1;
        /* 0x0D0C */ public float ExtraFollowFreq2;
        /* 0x0D10 */ public float GiantSnakeEmergeHeight;
        /* 0x0D14 */ public float GiantSnakeEmergeDeep;
        /* 0x0D18 */ public float GiantSnakeEmergeTime;
        /* 0x0D1C */ public float GiantSnakeEmergeWide;
        /* 0x0D20 */ public float GiantSnakeEmergeUnderTime;
        /* 0x0D24 */ public float GiantSnakeEmergeOffset;
        /* 0x0D28 */ public float GiantSnakeRadius;
        /* 0x0D2C */ public float GiantSnakeHeadOffset;
        /* 0x0D30 */ public float ShieldFadeTime;
        /* 0x0D34 */ public float SharkAlongPathSpeed;
        /* 0x0D38 */ public float SwarmBrakingForce;
        /* 0x0D3C */ public float SharkToPathYDamp;
        /* 0x0D40 */ public float SharkAttackSpeed;
        /* 0x0D44 */ public float SharkAttackAccel;
        /* 0x0D48 */ public float SharkPatrolSpeed;
        /* 0x0D4C */ public float SharkPatrolRadius;
        /* 0x0D50 */ public float SharkPatrolEnd;
        /* 0x0D54 */ public float SharkGetToPathSpeed;
        /* 0x0D58 */ public float SharkAlignSpeed;
        /* 0x0D5C */ public float FishBobFrequency;
        /* 0x0D60 */ public float FishBobAmplitude;
        /* 0x0D64 */ public float InfluenceRadius;
        /* 0x0D68 */ public float InfluenceForce;
        /* 0x0D6C */ public float InfluenceThreshold;
        /* 0x0D70 */ public float InfluenceDeflect;
        /* 0x0D74 */ public float TargetSearchTimeout;
        /* 0x0D78 */ public float AttractMinDistance;
        /* 0x0D7C */ public float SwarmMoveYFactor;
        /* 0x0D80 */ public float DroneExplodeRadius;
        /* 0x0D84 */ public float WeaponRepelRange;
        /* 0x0D88 */ public float WeaponRepelAmount;
        /* 0x0D8C */ public float VelocityAlignStrength;
        /* 0x0D90 */ public float VelocityAlignSpeed;
        /* 0x0D94 */ public float HeightLookAhead;
        /* 0x0D98 */ public float MaxHeightTime;
        /* 0x0D9C */ public float PlayerBirdDistance;
        /* 0x0DA0 */ public float FishSpeedMin;
        /* 0x0DA4 */ public float FishSpeedMax;
        /* 0x0DA8 */ public float FishSwimMaxAcceleration;
        /* 0x0DAC */ public float AlertDistance;
        /* 0x0DB0 */ public float RepelRange;
        /* 0x0DB4 */ public float RepelAmount;
        /* 0x0DB8 */ public float FishTurn;
        /* 0x0DBC */ public float TargetReachedDistance;
        /* 0x0DC0 */ public float MaxSpeed;
        /* 0x0DC4 */ public float MaxForce;
        /* 0x0DC8 */ public float MaxTorque;
        /* 0x0DCC */ public float MinWaterSpawnDepth;
        /* 0x0DD0 */ public float WaterSpawnOffset;
        /* 0x0DD4 */ public float SpawnDistanceModifierForUnderwater;
        /* 0x0DD8 */ public float FootDustGroundTintStrength;
        /* 0x0DDC */ public GcFlyingSnakeData FlyingSnakeData;
        [NMS(Size = 0x04)]
        /* 0x0E1C */ public GcCreatureAlertData[] AlertTable;
        /* 0x0E7C */ public bool ShowScale;
        /* 0x0E80 */ public float CreatureMedMinSize;
        /* 0x0E84 */ public float CreatureLargeMinSize;
        /* 0x0E88 */ public float CreatureHugeMinSize;
        /* 0x0E8C */ public float Unknown0xE8C;
        /* 0x0E90 */ public float Unknown0xE90;
        /* 0x0E94 */ public float Unknown0xE94;
        /* 0x0E98 */ public int CreatureSmallHealth;
        /* 0x0E9C */ public int CreatureMedHealth;
        /* 0x0EA0 */ public int CreatureLargeHealth;
        /* 0x0EA4 */ public int CreatureHugeHealth;
        [NMS(Size = 0x10)]
        /* 0x0EA8 */ public string CreatureLargeWalkShake;
        /* 0x0EB8 */ public float CreatureLargeWalkMaxShakeDist;
        [NMS(Size = 0x04, Ignore = true)]
        /* 0x0EBC */ public byte[] PaddingEBC;
        [NMS(Size = 0x10)]
        /* 0x0EC0 */ public string CreatureLargeRunShake;
        /* 0x0ED0 */ public float CreatureLargeRunMaxShakeDist;
        [NMS(Size = 0x04, Ignore = true)]
        /* 0x0ED4 */ public byte[] PaddingED4;
        [NMS(Size = 0x10)]
        /* 0x0ED8 */ public string CreatureHugeWalkShake;
        /* 0x0EE8 */ public float CreatureHugeWalkMaxShakeDist;
        [NMS(Size = 0x04, Ignore = true)]
        /* 0x0EEC */ public byte[] PaddingEEC;
        [NMS(Size = 0x10)]
        /* 0x0EF0 */ public string CreatureHugeRunShake;
        /* 0x0F00 */ public float CreatureHugeRunMaxShakeDist;
        /* 0x0F04 */ public float SmallCreaturePerceptionDistance;
        /* 0x0F08 */ public float largeCreaturePerceptionDistance;
        /* 0x0F0C */ public float SmallCreatureFleePlayerDistance;
        /* 0x0F10 */ public float LargeCreatureFleePlayerDistance;
        /* 0x0F14 */ public float SmallCreatureAvoidPlayerDistance;
        /* 0x0F18 */ public float LargeCreatureAvoidPlayerDistance;
        /* 0x0F1C */ public float PredatorPerceptionDistance;
        /* 0x0F20 */ public float PredatorFishPerceptionDistance;
        /* 0x0F24 */ public float PassiveFleePlayerDistance;
        /* 0x0F28 */ public float AdultBabyKilledNoticeDistance;
        /* 0x0F2C */ public float PercentagePlayerPredators;
        /* 0x0F30 */ public int PredatorSmallHealth;
        /* 0x0F34 */ public int PredatorMedHealth;
        /* 0x0F38 */ public int PredatorLargeHealth;
        /* 0x0F3C */ public int PredatorHugeHealth;
        /* 0x0F40 */ public float Unknown0xF40;
        /* 0x0F44 */ public float PredatorApproachTime;
        /* 0x0F48 */ public float PredatorNoticePauseTime;
        /* 0x0F4C */ public float PredatorStealthDist;
        /* 0x0F50 */ public float PredatorChargeDist;
        /* 0x0F54 */ public float PredatorChargeDistScale;
        /* 0x0F58 */ public float FishPredatorChargeDist;
        /* 0x0F5C */ public float FishPredatorChargeDistScale;
        /* 0x0F60 */ public float PredatorBoredomDistance;
        /* 0x0F64 */ public float PlayerPredatorBoredomDistance;
        /* 0x0F68 */ public float PredatorRegainInterestTime;
        /* 0x0F6C */ public float PlayerPredatorRegainInterestTime;
        /* 0x0F70 */ public float PredatorRunAwayDist;
        /* 0x0F74 */ public float PredatorRoarProbAfterHit;
        /* 0x0F78 */ public float PredatorRoarProbAfterMiss;
        /* 0x0F7C */ public float PredatorRunAwayHealthPercent;
        /* 0x0F80 */ public float PredatorEnergyRecoverRate;
        /* 0x0F84 */ public float PredatorEnergyUseChasing;
        /* 0x0F88 */ public float Unknown0xF88;
        /* 0x0F8C */ public float Unknown0xF8C;
        /* 0x0F90 */ public bool AggressiveSharks;
        /* 0x0F91 */ public bool FiendsCanAttack;
        /* 0x0F94 */ public int FiendHealth;
        /* 0x0F98 */ public float FiendPerceptionDistance;
        /* 0x0F9C */ public float FiendSpawnDistance;
        /* 0x0FA0 */ public float FiendDespawnDistance;
        /* 0x0FA4 */ public float FiendReplicateStartDistance;
        /* 0x0FA8 */ public float FiendReplicateEndDistance;
        /* 0x0FAC */ public float FiendAggroTime;
        /* 0x0FB0 */ public int FiendMaxEngaged;
        /* 0x0FB4 */ public int FiendMaxAttackers;
        /* 0x0FB8 */ public float DelayBetweenPounceAttacks;
        /* 0x0FBC */ public float DelayBetweenSpitAttacks;
        /* 0x0FC0 */ public float FiendMaxVerticalForPounce;
        /* 0x0FC4 */ public float FiendZigZagSpeed;
        /* 0x0FC8 */ public float FiendZigZagStrength;
        /* 0x0FCC */ public int FiendEggsToUnlockSpit;
        /* 0x0FD0 */ public int MaxFiendsToSpawn;
        /* 0x0FD4 */ public float FiendMinSpawnTime;
        /* 0x0FD8 */ public float FiendMaxSpawnTime;
        /* 0x0FDC */ public float FiendAggroIncreaseDamageEgg;
        /* 0x0FE0 */ public float FiendAggroIncreaseDestroyEgg;
        /* 0x0FE4 */ public float FiendAggroDecreasePerSpawn;
        /* 0x0FE8 */ public float FiendCritAreaSize;
        /* 0x0FEC */ public float Unknown0xFEC;
        /* 0x0FF0 */ public float Unknown0xFF0;
        /* 0x0FF4 */ public float Unknown0xFF4;
        /* 0x0FF8 */ public int MaxFishFiends;
        /* 0x0FFC */ public int FishFiendSmallHealth;
        /* 0x01000 */ public int FishFiendBigHealth;
        /* 0x01004 */ public float FishFiendSmallBoostStrength;
        /* 0x01008 */ public float FishFiendSmallBoostTime;
        /* 0x0100C */ public float FishFiendSmallScale;
        /* 0x01010 */ public float FishFiendBigBoostStrength;
        /* 0x01014 */ public float FishFiendBigBoostTime;
        /* 0x01018 */ public float FishFiendBigScale;
        /* 0x0101C */ public float RoutineSpeed;
        /* 0x01020 */ public float RoutineOffset;
        /* 0x01024 */ public float RagdollTau;
        /* 0x01028 */ public float RagdollDamping;
        /* 0x0102C */ public float RagdollConeLimit;
        /* 0x01030 */ public float RagdollTwistLimit;
        /* 0x01034 */ public float RagdollMotorFadeStart;
        /* 0x01038 */ public float RagdollMotorFadeEnd;
        /* 0x0103C */ public int MaxRagdollsBeforeDespawnOffscreen;
        /* 0x01040 */ public int MaxRagdollsBeforeDespawnOnscreen;
        /* 0x01044 */ public float TurnRadiusMultiplier;
        /* 0x01048 */ public float Unknown0x1048;          // TODO: determine if this value or the one above is the unknown/known
        /* 0x0104C */ public float Unknown0x104C;          // Probably the later one so two new unkowns are together... Would still be good to have confirmation 
        /* 0x01050 */ public float TurnSlowAreaCos;
        /* 0x01054 */ public float BadTurnPercent;
        /* 0x01058 */ public float BadTurnWeight;
        /* 0x0105C */ public float MinScaleForNavMap;
        /* 0x01060 */ public float ImpassabilityBrakeTime;
        /* 0x01064 */ public float ImpassabilityUnbrakeTime;
        /* 0x01068 */ public float ImpassabilityTurnSpeedMultiplier;
        /* 0x0106C */ public float NavMapLookAhead;
        /* 0x01070 */ public float VelocityAlignYFactorMin;
        /* 0x01074 */ public float VelocityAlignYFactorMax;
        /* 0x01078 */ public float BrakingForce;
        /* 0x0107C */ public float BrakingForceY;
        /* 0x01080 */ public float FlowFieldWeight;
        /* 0x01084 */ public float FollowWeight;
        /* 0x01088 */ public float Unknown0x1088;       // TODO: determine if this value or the one above is the unknown/known
        /* 0x0108C */ public float AvoidCreaturesWeight;
        /* 0x01090 */ public float AvoidImpassableWeight;
        /* 0x01094 */ public float FollowLeaderAlignWeight;
        /* 0x01098 */ public float Unknown0x1098;       // TODO: determine if this value or the one above is the unknown/known
        /* 0x0109C */ public float FollowLeaderCohereWeight;
        /* 0x010A0 */ public float Unknown0x10A0;
        /* 0x010A4 */ public float DefaultSwimSpeed;
        /* 0x010A8 */ public float FastSwimSpeed;
        /* 0x010AC */ public float DefaultWalkMoveSpeed;
        /* 0x010B0 */ public float DefaultTrotMoveSpeed;
        /* 0x010B4 */ public float DefaultRunMoveSpeed;
        /* 0x010B8 */ public float PredatorWalkMoveSpeed;
        /* 0x010BC */ public float PredatorTrotMoveSpeed;
        /* 0x010C0 */ public float PredatorRunMoveSpeed;
        /* 0x010C4 */ public float HeightDiffPenalty;
        /* 0x010C8 */ public float EdgeClosenessPenalty;
        /* 0x010CC */ public float PelvisIkStrength;
        /* 0x010D0 */ public float SteeringUpdateRate;
        /* 0x010D4 */ public float PathOverestimate;
        /* 0x010D8 */ public float FishWaterSurfaceAnticipate;
        /* 0x010DC */ public float FishWaterSurfaceAvoidStrength;
        /* 0x010E0 */ public float FishDesiredDepth;
        /* 0x010E4 */ public float FishMinHeightAboveSeaBed;
        /* 0x010E8 */ public float FishSeaBedAvoidStrength;
        /* 0x010EC */ public float FishObstacleAvoidStrength;
        /* 0x010F0 */ public float FishPlayerAttractionFrontDist;
        /* 0x010F4 */ public float FishPlayerAttractionAhead;
        /* 0x010F8 */ public float FishPlayerAttractionMinDist;
        /* 0x010FC */ public float FishPlayerAttractionMaxDist;
        /* 0x01100 */ public float FishPlayerAttractionStrength;
        /* 0x01104 */ public float AttackPlayerDistance;
        /* 0x01108 */ public float SpawnCameraAngleCos;
        /* 0x0110C */ public float SpawnMinDistPercentage;
        /* 0x01110 */ public float SpawnOnscreenDist;
        /* 0x01114 */ public float FadeScaleMultiplier;
        /* 0x01118 */ public float FadeScalePower;
        /* 0x0111C */ public float FadeDistance;
        /* 0x01120 */ public float MinFade;
        /* 0x01124 */ public float MaxFade;
        /* 0x01128 */ public bool ProcessPendingSpawnRequests;
        /* 0x0112C */ public float SpawnsAvoidBaseMultiplier;
        /* 0x01130 */ public int PerceptionUpdateRate;
        /* 0x01134 */ public bool AllowSleeping;
        /* 0x01135 */ public bool DebugDrawTrails;
        /* 0x01138 */ public float TrailHalfLife;
        /* 0x0113C */ public bool EnableTrailIk;
        /* 0x01140 */ public float DetailAnimBlendInTime;
        /* 0x01144 */ public float DetailAnimBlendOutTime;
        /* 0x01148 */ public float DetailAnimMinPauseTime;
        /* 0x0114C */ public float DetailAnimMaxPauseTime;
        /* 0x01150 */ public bool DetailAnimPlayWhileWalking;
        [NMS(Size = 0x07, Ignore = true)]
        /* 0x01151 */ public byte[] Padding1151;

        [NMS(Size = 0x10)]
        /* 0x01158 */ public string CreatureDeathEffectSmall;
        [NMS(Size = 0x10)]
        /* 0x01168 */ public string CreatureDeathEffectMedium;
        [NMS(Size = 0x10)]
        /* 0x01178 */ public string CreatureDeathEffectBig;
        [NMS(Size = 0x10)]
        /* 0x01188 */ public string FishDeathEffect;

        /* 0x01198 */ public float FootParticleTime;
        /* 0x0119C */ public bool PiedPiper;
        /* 0x011A0 */ public float FollowPlayerDistance;
        /* 0x011A4 */ public float FollowRunPlayerDistance;
        /* 0x011A8 */ public float FollowRange;
        /* 0x011AC */ public float SearchItemDistance;
        /* 0x011B0 */ public float SearchItemFrequency;
        /* 0x011B4 */ public float SearchItemGiveUpDistance;
        /* 0x011B8 */ public float SearchItemGiveUpTime;
        /* 0x011BC */ public float SearchItemNotifyTime;
        /* 0x011C0 */ public float SearchSpawnRandomItemProbability;
        /* 0x011C4 */ public float MiningRandomProbability;
        /* 0x011C8 */ public bool DebugSearch;
        /* 0x011CC */ public int FriendlyCreatureLimit;
        /* 0x011D0 */ public int FeedingTaskAmount;
        /* 0x011D4 */ public float FeedingFollowTime;
        /* 0x011D8 */ public float FeedingNoticeTime;
        /* 0x011DC */ public float FeedingNoticeDistance;
        /* 0x011E0 */ public float Unknown0x11E0;
        /* 0x011E4 */ public float Unknown0x11E4;
        /* 0x011E8 */ public float Unknown0x11E8;
        /* 0x011EC */ public float Unknown0x11EC;
        /* 0x011F0 */ public float AnimChangeCoolDown;
        /* 0x011F4 */ public float GroupRunProbability;
        /* 0x011F8 */ public float GroupBabyRunProbability;
        /* 0x011FC */ public float GroupRunStormProbability;
        /* 0x01200 */ public float GroupLookAtProbability;
        /* 0x01204 */ public float GroupLookAtDurationMin;
        /* 0x01208 */ public float GroupLookAtDurationMax;
        /* 0x0120C */ public float GroupRunDurationMin;
        /* 0x01210 */ public float GroupRunDurationMax;
        /* 0x01214 */ public float GroupFemaleProportion;
        /* 0x01218 */ public float GroupBabyProportion;
        /* 0x0121C */ public float GroupBabyScale;
        /* 0x01220 */ public float GroupBabyHealthMultiplier;
        /* 0x01224 */ public float MaxBirdsProportion;
        /* 0x01228 */ public float HerdGroupSizeMultiplier;
        /* 0x0122C */ public bool DrawRoutineFollowDebug;
        [NMS(Size = 0x03, Ignore = true)]
        /* 0x0122D */ public byte[] Padding122D;
        /* 0x01230 */ public float AdultCorrelationValue;
        /* 0x01234 */ public float GrassPushRadius;
        /* 0x01238 */ public float GrassPushStrength;
        /* 0x0123C */ public float GrassPushMaxSize;
        /* 0x01240 */ public bool DrawGrassPushRadius;

        [NMS(Size = 0x80)]
        /* 0x01241 */ public string DefaultCreatureSettings;
        [NMS(Size = 0x80)]
        /* 0x012C1 */ public string DefaultAirCreatureSettings;
        [NMS(Size = 0x80)]
        /* 0x01341 */ public string DefaultWaterCreatureSettings;

        [NMS(Size = 0x03, Ignore = true)]
        /* 0x013C1 */ public byte[] Padding13C1;
        /* 0x013C4 */ public float CreatureSpeedMultiplier;
        /* 0x013C8 */ public float PredatorSpeedMultiplier;
        [NMS(Size = 0x04, Ignore = true)]
        /* 0x013CC */ public byte[] Padding13CC;
        [NMS(Size = 0x4)]
        /* 0x013D0 */ public NMSString0x10[] KillingSubstances;

        /* 0x01410 */ public int UnknownInt0x1410;
        /* 0x01414 */ public int UnknownInt0x1414;
        /* 0x01418 */ public int UnknownInt0x1418;
        /* 0x0141C */ public int UnknownInt0x141C;
        [NMS(Size = 0x1A, EnumValue = new string[0x1A] { "Fish", "Antelope", "Bird", "Butterfly", "FlyingSnake", "FlyingLizard", "Diplo", "Triceratops", "Rodent", "Cow", "Cat", "Strider",
                                                         "Trex", "Shark", "TwoLegAntelope", "SixLegCat", "SixLegCow", "Grunt", "Blob", "Spider", "FloatSpider", "SwimCow", "SwimRodent",
                                                         "Jellyfish", "Crab", "RockCreature" })]
        /* 0x01420 */ public GcCreatureSubstanceList[] CreatureSubstanceLists;
        [NMS(Size = 0x1A, EnumValue = new string[0x1A] { "Fish", "Antelope", "Bird", "Butterfly", "FlyingSnake", "FlyingLizard", "Diplo", "Triceratops", "Rodent", "Cow", "Cat", "Strider",
                                                         "Trex", "Shark", "TwoLegAntelope", "SixLegCat", "SixLegCow", "Grunt", "Blob", "Spider", "FloatSpider", "SwimCow", "SwimRodent",
                                                         "Jellyfish", "Crab", "RockCreature" })]
        /* 0x01760 */ public GcCreatureHarvestSubstanceList[] CreatureHarvestSubstanceLists;
        /* 0x02870 */ public int UnknownInt0x2870;
        /* 0x02874 */ public int UnknownInt0x2874;
        /* 0x02878 */ public int UnknownInt0x2878;
        /* 0x0287C */ public int UnknownInt0x287C;
        /* 0x02880 */ public float Unknown0x2884;
        /* 0x02884 */ public float Unknown0x2888;
        [NMS(Size = 0x8)]
        /* 0x02888 */ public GcCreatureFoodList[] CreatureFoodLists;
        [NMS(Size = 0x10)]
        /* 0x02D88 */ public string Unknown0x2D90;
        /* 0x02D98 */ public GcWeirdCreatureRewardList WeirdKillingRewards;
        [NMS(Size = 0x03)]
        /* 0x02ED8 */ public NMSString0x10[] LootItems;
        /* 0x02F08 */ public float RockTransformGlobalChance;
        [NMS(Size = 0x04)]
        /* 0x02F0C */ public float[] RockTransformChanceModifiers;
        /* 0x02F1C */ public int PauseBetweenCreatureSpawnRequests;
    }
}
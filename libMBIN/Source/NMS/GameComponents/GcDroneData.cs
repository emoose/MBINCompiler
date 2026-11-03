using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8EF1031FA66644DD, NameHash = 0x5516BAF9)]
    public class GcDroneData : NMSTemplate
    {
        [NMS(Index = 39)]
        /* 0x000 */ public Colour EyeColourAlert;
        [NMS(Index = 41)]
        /* 0x010 */ public Colour EyeColourPatrol;
        [NMS(Index = 40)]
        /* 0x020 */ public Colour EyeColourSearch;
        [NMS(Index = 68)]
        /* 0x030 */ public GcSentinelResource CoverResource;
        [NMS(Index = 55)]
        /* 0x058 */ public NMSString0x10 DamageEffect;
        [NMS(Index = 52)]
        /* 0x068 */ public NMSString0x10 MeleeAttackDamageType;
        [NMS(Index = 49)]
        /* 0x078 */ public NMSString0x10 SpinAttackDamageType;
        [NMS(Index = 1)]
        /* 0x088 */ public GcDroneControlData Attack;
        [NMS(Index = 10)]
        /* 0x0C0 */ public GcDroneControlData Friendly;
        [NMS(Index = 11)]
        /* 0x0F8 */ public GcDroneControlData FriendlyFast;
        [NMS(Index = 9)]
        /* 0x130 */ public GcDroneControlData GrabbedByGravGun;
        [NMS(Index = 2)]
        /* 0x168 */ public GcDroneControlData MeleeAttack;
        [NMS(Index = 0)]
        /* 0x1A0 */ public GcDroneControlData Patrol;
        [NMS(Index = 5)]
        /* 0x1D8 */ public GcDroneControlData Repair;
        [NMS(Index = 4)]
        /* 0x210 */ public GcDroneControlData Scan;
        [NMS(Index = 3)]
        /* 0x248 */ public GcDroneControlData Search;
        [NMS(Index = 8)]
        /* 0x280 */ public GcDroneControlData Stun;
        [NMS(Index = 6)]
        /* 0x2B8 */ public GcDroneControlData Summon;
        [NMS(Index = 7)]
        /* 0x2F0 */ public GcDroneControlData ToCover;
        [NMS(Index = 32)]
        /* 0x328 */ public float AttackActivateTime;
        [NMS(Index = 38)]
        /* 0x32C */ public float AttackAlertFailTime;
        [NMS(Index = 30)]
        /* 0x330 */ public float AttackAngle;
        [NMS(Index = 33)]
        /* 0x334 */ public float AttackBobAmount;
        [NMS(Index = 34)]
        /* 0x338 */ public float AttackBobRotation;
        [NMS(Index = 37)]
        /* 0x33C */ public float AttackMaxDistanceFromAlert;
        [NMS(Index = 31)]
        /* 0x340 */ public float AttackMinSpeed;
        [NMS(Index = 36)]
        /* 0x344 */ public float AttackMoveAngle;
        [NMS(Index = 29)]
        /* 0x348 */ public float AttackMoveLookDistanceMin;
        [NMS(Index = 28)]
        /* 0x34C */ public float AttackMoveLookDistanceRange;
        [NMS(Index = 35)]
        /* 0x350 */ public float AttackMoveMinChoiceTime;
        [NMS(Index = 27)]
        /* 0x354 */ public float BaseAnimationSpeed;
        [NMS(Index = 12)]
        /* 0x358 */ public float CollisionAvoidOffset;
        [NMS(Index = 60)]
        /* 0x35C */ public float CoverPlacementActivateTime;
        [NMS(Index = 61)]
        /* 0x360 */ public float CoverPlacementActivateTimeMaxRandomExtra;
        [NMS(Index = 62)]
        /* 0x364 */ public float CoverPlacementCooldownTime;
        [NMS(Index = 67)]
        /* 0x368 */ public int CoverPlacementMaxActiveCover;
        [NMS(Index = 65)]
        /* 0x36C */ public float CoverPlacementMaxDistanceFromSelf;
        [NMS(Index = 64)]
        /* 0x370 */ public float CoverPlacementMinDistanceFromSelf;
        [NMS(Index = 63)]
        /* 0x374 */ public float CoverPlacementMinDistanceFromTarget;
        [NMS(Index = 66)]
        /* 0x378 */ public float CoverPlacementUpOffset;
        [NMS(Index = 56)]
        /* 0x37C */ public float DamageEffectHealthPercentThreshold;
        [NMS(Index = 26)]
        /* 0x380 */ public float DroneAlertTime;
        [NMS(Index = 14)]
        /* 0x384 */ public float DronePatrolDistanceMax;
        [NMS(Index = 13)]
        /* 0x388 */ public float DronePatrolDistanceMin;
        [NMS(Index = 25)]
        /* 0x38C */ public int DronePatrolHonkProbability;
        [NMS(Index = 23)]
        /* 0x390 */ public float DronePatrolHonkRadius;
        [NMS(Index = 24)]
        /* 0x394 */ public float DronePatrolHonkTime;
        [NMS(Index = 17)]
        /* 0x398 */ public float DronePatrolInspectDistanceMax;
        [NMS(Index = 16)]
        /* 0x39C */ public float DronePatrolInspectDistanceMin;
        [NMS(Index = 20)]
        /* 0x3A0 */ public float DronePatrolInspectRadius;
        [NMS(Index = 19)]
        /* 0x3A4 */ public float DronePatrolInspectSwitchTime;
        [NMS(Index = 18)]
        /* 0x3A8 */ public float DronePatrolInspectTargetTime;
        [NMS(Index = 21)]
        /* 0x3AC */ public float DronePatrolRepelDistance;
        [NMS(Index = 22)]
        /* 0x3B0 */ public float DronePatrolRepelStrength;
        [NMS(Index = 15)]
        /* 0x3B4 */ public float DronePatrolTargetDistance;
        [NMS(Index = 75)]
        /* 0x3B8 */ public float DroneScanPlayerTime;
        [NMS(Index = 72)]
        /* 0x3BC */ public float DroneSearchCriminalScanRadius;
        [NMS(Index = 74)]
        /* 0x3C0 */ public float DroneSearchCriminalScanRadiusInShip;
        [NMS(Index = 73)]
        /* 0x3C4 */ public float DroneSearchCriminalScanRadiusWanted;
        [NMS(Index = 71)]
        /* 0x3C8 */ public float DroneSearchPauseTime;
        [NMS(Index = 70)]
        /* 0x3CC */ public float DroneSearchRadius;
        [NMS(Index = 69)]
        /* 0x3D0 */ public float DroneSearchTime;
        [NMS(Index = 87)]
        /* 0x3D4 */ public float EngineDirAngleMax;
        [NMS(Index = 86)]
        /* 0x3D8 */ public float EngineDirSpeedMin;
        [NMS(Index = 85)]
        /* 0x3DC */ public float EyeAngleMax;
        [NMS(Index = 80)]
        /* 0x3E0 */ public float EyeFocusTime;
        [NMS(Index = 82)]
        /* 0x3E4 */ public int EyeNumRandomsMax;
        [NMS(Index = 81)]
        /* 0x3E8 */ public int EyeNumRandomsMin;
        [NMS(Index = 79)]
        /* 0x3EC */ public float EyeOffset;
        [NMS(Index = 84)]
        /* 0x3F0 */ public float EyeTimeMax;
        [NMS(Index = 83)]
        /* 0x3F4 */ public float EyeTimeMin;
        [NMS(Index = 57)]
        /* 0x3F8 */ public float HideBehindCoverHealthPercentThreshold;
        [NMS(Index = 58)]
        /* 0x3FC */ public float HideBehindCoverSearchRadius;
        [NMS(Index = 76)]
        /* 0x400 */ public float LeanAmount;
        [NMS(Index = 77)]
        /* 0x404 */ public float LeanSpeedMin;
        [NMS(Index = 78)]
        /* 0x408 */ public float LeanSpeedRange;
        [NMS(Index = 51)]
        /* 0x40C */ public float MeleeAttackDamageRadius;
        [NMS(Index = 53)]
        /* 0x410 */ public float MeleeAttackHomingStrength;
        [NMS(Index = 54)]
        /* 0x414 */ public float MeleeAttackMaxTime;
        [NMS(Index = 50)]
        /* 0x418 */ public float MeleeAttackWindUpTime;
        [NMS(Index = 43)]
        /* 0x41C */ public float SpinAttackCooldown;
        [NMS(Index = 48)]
        /* 0x420 */ public float SpinAttackDamageRadius;
        [NMS(Index = 44)]
        /* 0x424 */ public float SpinAttackDuration;
        [NMS(Index = 47)]
        /* 0x428 */ public float SpinAttackHomingStrength;
        [NMS(Index = 42)]
        /* 0x42C */ public float SpinAttackRange;
        [NMS(Index = 45)]
        /* 0x430 */ public float SpinAttackRevolutions;
        [NMS(Index = 59)]
        /* 0x434 */ public bool EnableCoverPlacement;
        [NMS(Index = 46)]
        /* 0x435 */ public TkCurveType SpinAttackRevolutionCurve;
    }
}

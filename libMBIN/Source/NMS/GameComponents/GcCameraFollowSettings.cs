namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2897D0E4AFDCF52E, NameHash = 0x932D2ED5)]
    public class GcCameraFollowSettings : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public NMSString0x10 Name;
        [NMS(Index = 62)]
        /* 0x010 */ public float AvoidCollisionLRSpeed;
        [NMS(Index = 64)]
        /* 0x014 */ public float AvoidCollisionPushSpeed;
        [NMS(Index = 63)]
        /* 0x018 */ public float AvoidCollisionUDSpeed;
        [NMS(Index = 12)]
        /* 0x01C */ public float BackMaxDistance;
        [NMS(Index = 11)]
        /* 0x020 */ public float BackMinDistance;
        [NMS(Index = 13)]
        /* 0x024 */ public float BackSlopeAdjust;
        [NMS(Index = 14)]
        /* 0x028 */ public float BackSlopeRotationAdjust;
        [NMS(Index = 42)]
        /* 0x02C */ public float CenterBlendTime;
        [NMS(Index = 44)]
        /* 0x030 */ public float CenterMaxSpeed;
        [NMS(Index = 43)]
        /* 0x034 */ public float CenterMaxSpring;
        [NMS(Index = 48)]
        /* 0x038 */ public float CenterStartSpeed;
        [NMS(Index = 41)]
        /* 0x03C */ public float CenterStartTime;
        [NMS(Index = 69)]
        /* 0x040 */ public float CustomBlendTime;
        [NMS(Index = 36)]
        /* 0x044 */ public float DistSpeed;
        [NMS(Index = 37)]
        /* 0x048 */ public float DistSpeedOutsideMainRange;
        [NMS(Index = 38)]
        /* 0x04C */ public float DistStiffness;
        [NMS(Index = 26)]
        /* 0x050 */ public float HorizRotationAngleMaxPerFrame;
        [NMS(Index = 21)]
        /* 0x054 */ public float LeftMaxDistance;
        [NMS(Index = 20)]
        /* 0x058 */ public float LeftMinDistance;
        [NMS(Index = 50)]
        /* 0x05C */ public float LookStickLimitAngle;
        [NMS(Index = 51)]
        /* 0x060 */ public float LookStickOffset;
        [NMS(Index = 55)]
        /* 0x064 */ public float LRProbesRadius;
        [NMS(Index = 54)]
        /* 0x068 */ public float LRProbesRange;
        [NMS(Index = 49)]
        /* 0x06C */ public float MinMoveVelToTriggerSpring;
        [NMS(Index = 1)]
        /* 0x070 */ public float MinSpeed;
        [NMS(Index = 53)]
        /* 0x074 */ public int NumLRProbes;
        [NMS(Index = 56)]
        /* 0x078 */ public int NumUDProbes;
        [NMS(Index = 3)]
        /* 0x07C */ public float OffsetX;
        [NMS(Index = 4)]
        /* 0x080 */ public float OffsetY;
        [NMS(Index = 6)]
        /* 0x084 */ public float OffsetYAlt;
        [NMS(Index = 22)]
        /* 0x088 */ public float OffsetYExtraMaxDistance;
        [NMS(Index = 5)]
        /* 0x08C */ public float OffsetYMinSpeed;
        [NMS(Index = 8)]
        /* 0x090 */ public float OffsetYSlopeExtra;
        [NMS(Index = 9)]
        /* 0x094 */ public float OffsetZFlat;
        [NMS(Index = 24)]
        /* 0x098 */ public float PanFar;
        [NMS(Index = 23)]
        /* 0x09C */ public float PanNear;
        [NMS(Index = 58)]
        /* 0x0A0 */ public float ProbeCenterX;
        [NMS(Index = 59)]
        /* 0x0A4 */ public float ProbeCenterY;
        [NMS(Index = 60)]
        /* 0x0A8 */ public float PushForwardDropoffLR;
        [NMS(Index = 61)]
        /* 0x0AC */ public float PushForwardDropoffUD;
        [NMS(Index = 7)]
        /* 0x0B0 */ public float SpaceCombatYExtra;
        [NMS(Index = 2)]
        /* 0x0B4 */ public float SpeedRange;
        [NMS(Index = 39)]
        /* 0x0B8 */ public float SpringSpeed;
        [NMS(Index = 57)]
        /* 0x0BC */ public float UDProbesRange;
        [NMS(Index = 25)]
        /* 0x0C0 */ public float UpGamma;
        [NMS(Index = 16)]
        /* 0x0C4 */ public float UpMaxDistance;
        [NMS(Index = 15)]
        /* 0x0C8 */ public float UpMinDistance;
        [NMS(Index = 17)]
        /* 0x0CC */ public float UpSlopeAdjust;
        [NMS(Index = 18)]
        /* 0x0D0 */ public float UpWaveAdjust;
        [NMS(Index = 19)]
        /* 0x0D4 */ public float UpWaveAdjustMaxHeight;
        [NMS(Index = 45)]
        /* 0x0D8 */ public float VelocityAnticipate;
        [NMS(Index = 46)]
        /* 0x0DC */ public float VelocityAnticipateSpringSpeed;
        [NMS(Index = 47)]
        /* 0x0E0 */ public float VertMaxSpring;
        [NMS(Index = 35)]
        /* 0x0E4 */ public float VertResetRotationOverride;
        [NMS(Index = 29)]
        /* 0x0E8 */ public float VertRotationMax;
        [NMS(Index = 28)]
        /* 0x0EC */ public float VertRotationMin;
        [NMS(Index = 30)]
        /* 0x0F0 */ public float VertRotationOffset;
        [NMS(Index = 32)]
        /* 0x0F4 */ public float VertRotationOffsetMaxAngle;
        [NMS(Index = 31)]
        /* 0x0F8 */ public float VertRotationOffsetMinAngle;
        [NMS(Index = 27)]
        /* 0x0FC */ public float VertRotationSpeed;
        [NMS(Index = 66)]
        /* 0x100 */ public bool AvoidCollisionLRUseStickDelay;
        [NMS(Index = 65)]
        /* 0x101 */ public bool AvoidCollisionUDUseStickDelay;
        [NMS(Index = 52)]
        /* 0x102 */ public bool EnableCollisionDetection;
        [NMS(Index = 40)]
        /* 0x103 */ public bool LockToObjectOnIdle;
        [NMS(Index = 68)]
        /* 0x104 */ public bool UseCustomBlendTime;
        [NMS(Index = 10)]
        /* 0x105 */ public bool UseMinSpeedYOffset;
        [NMS(Index = 67)]
        /* 0x106 */ public bool UseSpeedBasedSpring;
        [NMS(Index = 34)]
        /* 0x107 */ public bool VertResetRotationOverrideEnabled;
        [NMS(Index = 33)]
        /* 0x108 */ public bool VertStartLookingDown;
    }
}

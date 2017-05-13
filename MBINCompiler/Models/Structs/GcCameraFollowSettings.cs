namespace MBINCompiler.Models.Structs
{
    public class GcCameraFollowSettings : NMSTemplate           // size: 0xD0
    {
        [NMS(Size =  0x10)]
        /* 0x00 */ public string Name;
        /* 0x10 */ public float MinSpeed;
        /* 0x14 */ public float SpeedRange;
        /* 0x18 */ public float OffsetY;
        /* 0x1C */ public float OffsetZFlat;
        /* 0x20 */ public float BackMinDistance;
        /* 0x24 */ public float UpMinDistance;
        /* 0x28 */ public float BackMaxDistance;
        /* 0x2C */ public float UpMaxDistance;
        /* 0x30 */ public float PanNear;
        /* 0x34 */ public float PanFar;
        /* 0x38 */ public float UpGamma;
        /* 0x3C */ public float CenterSpeed;
        /* 0x40 */ public float VertRotationSpeed;
        /* 0x44 */ public float VertRotationMin;
        /* 0x48 */ public float VertRotationMax;
        /* 0x4C */ public float VertRotationOffset;
        /* 0x50 */ public float VertRotationOffsetMinAngle;
        /* 0x54 */ public float VertRotationOffsetMaxAngle;
        /* 0x58 */ public float DistSpeed;
        /* 0x5C */ public float DistSpeedOutsideMainRange;
        /* 0x60 */ public float DistStiffness;
        /* 0x64 */ public float SpringSpeed;
        /* 0x68 */ public float CenterStartTime;
        /* 0x6C */ public float CenterBlendTime;
        /* 0x70 */ public float CenterMaxSpring;
        /* 0x74 */ public float CenterMaxSpeed;
        /* 0x78 */ public float VelocityAnticipate;
        /* 0x7C */ public float VelocityAnticipateSpringSpeed;
        /* 0x80 */ public float VertMaxSpring;
        /* 0x84 */ public float CenterStartSpeed;
        /* 0x88 */ public float MinClose;
        /* 0x8C */ public float MaxClose;
        /* 0x90 */ public float CloseSpring;
        /* 0x94 */ public int NumLRProbes;
        /* 0x98 */ public float LRProbesRange;
        /* 0x9C */ public float LRProbesRadius;
        /* 0xA0 */ public int NumUDProbes;
        /* 0xA4 */ public float UDProbesRange;
        /* 0xA8 */ public float UDProbesRadius;
        /* 0xAC */ public float ProbeCenterUp;
        /* 0xB0 */ public float ProbeExtraDistance;
        /* 0xB4 */ public float PushForwardDropoffLR;
        /* 0xB8 */ public float PushForwardDropoffUD;
        /* 0xBC */ public float AvoidCollisionLRSpeed;
        /* 0xC0 */ public float AvoidCollisionUDSpeed;
        /* 0xC4 */ public float AvoidCollisionPushSpeed;
        /* 0xC8 */ public bool AvoidCollisionUDUseStickDelay;
        /* 0xC9 */ public bool AvoidCollisionLRUseStickDelay;

        [NMS(Size = 0x6, Ignore = true)]
        public byte[] EndPadding;
    }
}

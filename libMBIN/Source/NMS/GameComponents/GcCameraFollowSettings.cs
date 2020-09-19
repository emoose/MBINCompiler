using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xE8, GUID = 0x4550EA39EC836543, NameHash = 0x200FDA306DC86654)]
    public class GcCameraFollowSettings : NMSTemplate
    {
        [NMS(Size =  0x10)]
        /* 0x00 */ public string Name;
        /* 0x10 */ public float MinSpeed;
        /* 0x14 */ public float SpeedRange;
        [NMSDescription("Horizontal offset relative to the center (0). Negative values move the camera left, positive values move it right")]
        /* 0x18 */ public float OffsetX;
        [NMSDescription("Vertical offset relative to the center (0). Negative values lower the camera, positive values raise it")]
        /* 0x1C */ public float OffsetY;
        /* 0x20 */ public float OffsetYAlt;
        /* 0x24 */ public float OffsetZFlat;
        /* 0x28 */ public float BackMinDistance;
        /* 0x2C */ public float UpMinDistance;
        /* 0x30 */ public float BackMaxDistance;
        /* 0x34 */ public float UpMaxDistance;
        /* 0x38 */ public float PanNear;
        /* 0x3C */ public float PanFar;
        /* 0x40 */ public float UpGamma;
        /* 0x44 */ public float HorizRotationAngleMaxPerFrame;
        /* 0x48 */ public float VertRotationSpeed;
        /* 0x4C */ public float VertRotationMin;
        /* 0x50 */ public float VertRotationMax;
        /* 0x54 */ public float VertRotationOffset;
        /* 0x58 */ public float VertRotationOffsetMinAngle;
        /* 0x5C */ public float VertRotationOffsetMaxAngle;
        /* 0x60 */ public bool VertStartLookingDown;
        /* 0x64 */ public float DistSpeed;
        /* 0x68 */ public float DistSpeedOutsideMainRange;
        /* 0x6C */ public float DistStiffness;
        /* 0x70 */ public float SpringSpeed;
        /* 0x74 */ public bool LockToObjectOnIdle;
        /* 0x78 */ public float CenterStartTime;
        /* 0x7C */ public float CenterBlendTime;
        /* 0x80 */ public float CenterMaxSpring;
        /* 0x84 */ public float CenterMaxSpeed;
        /* 0x88 */ public float VelocityAnticipate;
        /* 0x8C */ public float VelocityAnticipateSpringSpeed;
        /* 0x90 */ public float VertMaxSpring;
        /* 0x94 */ public float CenterStartSpeed;
        /* 0x98 */ public float MinClose;
        /* 0x9C */ public float MaxClose;
        /* 0xA0 */ public float CloseSpring;
        /* 0xA4 */ public float LookStickLimitAngle;
        [NMSDescription("Specifies whether the camera should collide with the world. Setting to False will make the camera clip through objects and the ground")]
        /* 0xA8 */ public bool EnableCollisionDetection;
        /* 0xAC */ public int NumLRProbes;
        /* 0xB0 */ public float LRProbesRange;
        /* 0xB4 */ public float LRProbesRadius;
        /* 0xB8 */ public int NumUDProbes;
        /* 0xBC */ public float UDProbesRange;
        /* 0xC0 */ public float ProbeCenterX;
        /* 0xC4 */ public float ProbeCenterY;
        /* 0xC8 */ public float PushForwardDropoffLR;
        /* 0xCC */ public float PushForwardDropoffUD;
        /* 0xD0 */ public float AvoidCollisionLRSpeed;
        /* 0xD4 */ public float AvoidCollisionUDSpeed;
        /* 0xD8 */ public float AvoidCollisionPushSpeed;
        /* 0xDC */ public bool AvoidCollisionUDUseStickDelay;
        /* 0xDD */ public bool AvoidCollisionLRUseStickDelay;
        /* 0xDE */ public bool UseSpeedBasedSpring;
        /* 0xDF */ public bool UseCustomBlendTime;
        /* 0xE0 */ public float CustomBlendTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xE4 */ public byte[] EndPadding;
    }
}

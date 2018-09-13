using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x50, GUID = 0x8ABF8AF5472E941C)]
    public class GcThirdPersonAnimParams : NMSTemplate
    {
		/* 0x00 */ public Vector2f Velocity;
        /* 0x08 */ public Vector2f VelocityXY;
        /* 0x10 */ public float VelocityY;
        /* 0x14 */ public float VelocityZ;
        /* 0x18 */ public Vector2f MoveForce;
        /* 0x20 */ public float MoveForceApplied;
        /* 0x24 */ public Vector2f AimDirection;
        /* 0x2C */ public float Speed;
        /* 0x30 */ public float Foot;
        /* 0x34 */ public float AimPitch;
        /* 0x38 */ public float AimYaw;
        /* 0x3C */ public float TurnAngle;
        /* 0x40 */ public float DistanceFromGround;
        /* 0x44 */ public float Uphill;
        /* 0x48 */ public float SlopeAngle;
        /* 0x4C */ public float TimeSinceJetpackEngaged;
    }
}

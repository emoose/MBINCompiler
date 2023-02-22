using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC52A83607CC704B8, NameHash = 0xEF85A351ABA84D63)]
    public class GcGrabbableData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 LocatorName;
        /* 0x20 */ public float GrabRadius;
        /* 0x24 */ public float AttachTime;
        /* 0x28 */ public float ReleaseRadius;
        /* 0x2C */ public float DetachTime;
        /* 0x30 */ public GcHand Hand;
        /* 0x34 */ public Vector2f RotationLimits;
        /* 0x3C */ public bool AllowOtherWayUp;
        /* 0x3D */ public bool AutoGrab;
        /* 0x40 */ public float ToggleGrabTime;
        // size: 0x4
        public enum GrabTypeEnum {
            Default,
            EjectHandle,
            ControlStickLeft,
            ControlStickRight,
        }
        /* 0x44 */ public GrabTypeEnum GrabType;
        /* 0x48 */ public NMSString0x10 HandPose;
        /* 0x58 */ public NMSString0x20 MovementStartLocator;
        /* 0x78 */ public NMSString0x20 MovementEndLocator;
        /* 0x98 */ public float MovementMaxSpeed;
        /* 0x9C */ public float MovementReturnSpeed;
        /* 0xA0 */ public float MovementRequiredForActivation;
    }
}

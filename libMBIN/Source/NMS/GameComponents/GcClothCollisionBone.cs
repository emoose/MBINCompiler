using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1DC689F860E9E48F, NameHash = 0x3183C2CA4E0D9600)]
    public class GcClothCollisionBone : NMSTemplate
    {
        /* 0x00 */ public bool Enabled;
        /* 0x01 */ public NMSString0x40 DebugName;
        /* 0x41 */ public NMSString0x40 BoneName;
        /* 0x90 */ public Vector3f CapsuleCentre;
        /* 0xA0 */ public AxisSpecification CapsuleAxis;
        /* 0xC0 */ public float CapsuleRadius;
        /* 0xC4 */ public float CapsuleLength;
        /* 0xC8 */ public bool ImproveCollisionForNarrowCapsule;
    }
}

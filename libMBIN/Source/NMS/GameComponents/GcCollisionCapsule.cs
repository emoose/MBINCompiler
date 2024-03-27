using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6900D314A3A5E2D6, NameHash = 0xF0A6F41B4CF7E771)]
    public class GcCollisionCapsule : NMSTemplate
    {
        /* 0x00 */ public bool Enabled;
        /* 0x01 */ public NMSString0x40 Name;
        /* 0x41 */ public NMSString0x40 NodeName;
        /* 0x90 */ public Vector3f CapsuleCentre;
        /* 0xA0 */ public AxisSpecification CapsuleAxis;
        /* 0xC0 */ public float CapsuleRadius;
        /* 0xC4 */ public float CapsuleLength;
        /* 0xC8 */ public bool ImproveCollisionForNarrowCapsule;
    }
}

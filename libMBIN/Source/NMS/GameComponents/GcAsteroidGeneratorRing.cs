using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAB9A00B42E8007C4, NameHash = 0x79403B157D846B70)]
    public class GcAsteroidGeneratorRing : NMSTemplate
    {
        /* 0x00 */ public GcAsteroidGeneratorAssignment Assignment;
        /* 0x48 */ public float LowerRadius;
        /* 0x4C */ public float UpperRadius;
        /* 0x50 */ public float PushRadius;
        /* 0x54 */ public int OffBalance;
        /* 0x60 */ public Vector3f Rotation;
        /* 0x70 */ public float USpread;
        /* 0x74 */ public float PushAmount;
        /* 0x78 */ public bool FlipPush;
    }
}

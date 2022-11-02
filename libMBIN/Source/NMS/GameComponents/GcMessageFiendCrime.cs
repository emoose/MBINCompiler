using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB3EC8EF6991EE6CA, NameHash = 0x37D134945C6DC0E)]
    public class GcMessageFiendCrime : NMSTemplate
    {
        /* 0x00 */ public Vector3f Position;
        /* 0x10 */ public GcNodeID Victim;
        /* 0x14 */ public GcFiendCrime FiendCrimeType;
        /* 0x18 */ public float Value;
    }
}

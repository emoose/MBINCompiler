using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x9AEF34B9C6C1635A, NameHash = 0x5BFC087E90D1520B)]
    public class TkNoiseFlattenFixedPosition : NMSTemplate
    {
        /* 0x00 */ public Vector3f Position;
        /* 0x10 */ public TkNoiseFlattenPoint FlattenPoint;
    }
}

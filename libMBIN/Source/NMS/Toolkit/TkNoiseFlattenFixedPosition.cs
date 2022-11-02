using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC616DB8CF827ED85, NameHash = 0x5BFC087E90D1520B)]
    public class TkNoiseFlattenFixedPosition : NMSTemplate
    {
        /* 0x00 */ public Vector3f Position;
        /* 0x10 */ public TkNoiseFlattenPoint FlattenPoint;
    }
}

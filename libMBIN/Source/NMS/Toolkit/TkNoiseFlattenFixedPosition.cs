using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x612EA45E317D5020, NameHash = 0x44B89EA2)]
    public class TkNoiseFlattenFixedPosition : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public Vector3f Position;
        [NMS(Index = 1)]
        /* 0x10 */ public TkNoiseFlattenPoint FlattenPoint;
    }
}

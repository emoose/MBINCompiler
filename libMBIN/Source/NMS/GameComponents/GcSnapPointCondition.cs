using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5A472B0478D3F41E, NameHash = 0x396BC2038766C20F)]
    public class GcSnapPointCondition : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 SnapPoint;
        /* 0x80 */ public GcBaseSnapState SnapState;
        /* 0x88 */ public NMSString0x10 ObjectId;
        /* 0x98 */ public int SnapPointIndex;
    }
}

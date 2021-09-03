using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x88, GUID = 0xBFB1E4127073097F, NameHash = 0x396BC2038766C20F)]
    public class GcSnapPointCondition : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 SnapPoint;
        /* 0x80 */ public GcBaseSnapState SnapState;
        /* 0x84 */ public int SnapPointIndex;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10C, GUID = 0x7A4C81B04BE3526A, NameHash = 0xC8A6AD07D6C1D49E)]
    public class GcOutSnapSocketCondition : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 SnapPoint;
        /* 0x080 */ public NMSString0x80 OutSocket;
        /* 0x100 */ public GcBaseSnapState SnapState;
        /* 0x104 */ public int SnapPointIndex;
        /* 0x108 */ public int OutSocketIndex;
    }
}

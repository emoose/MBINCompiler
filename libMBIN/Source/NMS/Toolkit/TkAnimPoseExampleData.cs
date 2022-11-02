using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4AFCDA9554B639A, NameHash = 0xC5A7760BFBE38FA1)]
    public class TkAnimPoseExampleData : NMSTemplate
    {
        /* 0x0 */ public List<TkAnimPoseExampleElement> Elements;
    }
}

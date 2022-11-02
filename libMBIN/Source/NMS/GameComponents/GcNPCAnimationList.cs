using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x75A7CF8A2D48D8BE, NameHash = 0xE02B8846C8E8134E)]
    public class GcNPCAnimationList : NMSTemplate
    {
        /* 0x0 */ public List<GcNPCProbabilityAnimationData> Animations;
    }
}

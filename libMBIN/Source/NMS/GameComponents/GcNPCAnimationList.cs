using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x284D3E915855883C, NameHash = 0xE02B8846C8E8134E)]
    public class GcNPCAnimationList : NMSTemplate
    {
        /* 0x0 */ public List<GcNPCProbabilityAnimationData> Animations;
    }
}

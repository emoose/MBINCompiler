using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1132F41C75B0DD7A, NameHash = 0x53C414A21BE5AF34)]
    public class GcNPCWordReactionList : NMSTemplate
    {
        /* 0x0 */ public List<GcNPCProbabilityWordReactionData> Reactions;
    }
}

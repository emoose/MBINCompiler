using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4062FA29D51FD3EA, NameHash = 0x1C80E29B339A41B9)]
    public class GcCreatureBehaviourTrees : NMSTemplate
    {
        /* 0x0 */ public List<GcCreatureBehaviourTreeData> BehaviourTree;
    }
}

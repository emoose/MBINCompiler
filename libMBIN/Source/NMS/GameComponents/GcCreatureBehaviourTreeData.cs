using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9E7BC658C104F1D8, NameHash = 0xC79C527C)]
    public class GcCreatureBehaviourTreeData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 1)]
        /* 0x10 */ public List<NMSTemplate> Nodes;
    }
}

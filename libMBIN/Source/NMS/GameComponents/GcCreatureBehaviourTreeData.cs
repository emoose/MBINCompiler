using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEADD2351E10A3DDC, NameHash = 0xC0220D51AA0E426)]
    public class GcCreatureBehaviourTreeData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public List<NMSTemplate> Nodes;
    }
}

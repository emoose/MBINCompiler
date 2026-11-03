using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF430399C0BBABCAA, NameHash = 0x18118681)]
    public class GcEasyRagdollSetUpData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<NMSString0x20> ChainEnds;
        [NMS(Index = 1)]
        /* 0x10 */ public List<NMSString0x20> ExcludeJoints;
        [NMS(Index = 2)]
        /* 0x20 */ public List<GcEasyRagdollSetUpBodyDimensions> ForceBodyDimensions;
    }
}

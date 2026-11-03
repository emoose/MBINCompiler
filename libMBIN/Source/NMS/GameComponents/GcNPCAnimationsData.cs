using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFC0EA02C026F918E, NameHash = 0x9F906ED9)]
    public class GcNPCAnimationsData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x000 */ public GcNPCAnimationSetData SittingAnimatons;
        [NMS(Index = 5)]
        /* 0x190 */ public GcNPCAnimationSetData SittingIPadAnimatons;
        [NMS(Index = 1)]
        /* 0x320 */ public GcNPCAnimationSetData StandingAnimatons;
        [NMS(Index = 2)]
        /* 0x4B0 */ public GcNPCAnimationSetData StandingIPadAnimatons;
        [NMS(Index = 3)]
        /* 0x640 */ public GcNPCAnimationSetData StandingStaffAnimatons;
        [NMS(Index = 0)]
        /* 0x7D0 */ public List<NMSString0x10> NPCGenericAnimIds;
    }
}

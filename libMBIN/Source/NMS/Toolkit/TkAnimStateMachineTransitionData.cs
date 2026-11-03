using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xCAACF39509FE2C9B, NameHash = 0x910781C3)]
    public class TkAnimStateMachineTransitionData : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public List<NMSTemplate> Conditions;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 DestinationStateDebugName;
        [NMS(Index = 0)]
        /* 0x20 */ public ulong DestinationState;
        [NMS(Index = 6)]
        /* 0x28 */ public TkAnimBlendType BlendType;
        [NMS(Index = 3)]
        /* 0x2C */ public float ExitTime;
        [NMS(Index = 4)]
        /* 0x30 */ public float TransitionTime;
        [NMS(Index = 5)]
        /* 0x34 */ public TkAnimStateMachineBlendTimeMode TransitionTimeMode;
        [NMS(Index = 2)]
        /* 0x38 */ public bool HasTimedExit;
    }
}

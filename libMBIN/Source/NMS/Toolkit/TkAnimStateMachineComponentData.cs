using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2A2A70C374C82F6D, NameHash = 0xFA972E8C)]
    public class TkAnimStateMachineComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A InitialStateMachine;
        [NMS(Index = 2)]
        /* 0x20 */ public List<NMSTemplate> Parameters;
        [NMS(Index = 1)]
        /* 0x30 */ public List<TkLayeredAnimStateMachineData> StateMachines;
    }
}

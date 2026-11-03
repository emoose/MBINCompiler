using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2542B2260D4C908D, NameHash = 0x30C6F48D)]
    public class TkAnimStateMachineData : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public List<TkAnimStateMachineTransitionData> EntryTransitions;
        [NMS(Index = 3)]
        /* 0x10 */ public NMSString0x10 LayerId;
        [NMS(Index = 8)]
        /* 0x20 */ public List<TkAnimStateMachineStateData> States;
        [NMS(Index = 6)]
        /* 0x30 */ public ulong DefaultState;
        [NMS(Index = 4)]
        /* 0x38 */ public int EntryPosX;
        [NMS(Index = 5)]
        /* 0x3C */ public int EntryPosY;
        [NMS(Index = 0)]
        /* 0x40 */ public float ScrollX;
        [NMS(Index = 1)]
        /* 0x44 */ public float ScrollY;
        [NMS(Index = 2)]
        /* 0x48 */ public float Zoom;
    }
}

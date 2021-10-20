using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0x231601B847B2CAAF, NameHash = 0xD1618D63DA15668C)]
    public class GcAudioAreaTriggerComponentData : NMSTemplate
    {
        /* 0x0 */ public GcAudioWwiseEvents EventEnter;
        /* 0x4 */ public GcAudioWwiseEvents EventExit;
        /* 0x8 */ public float EnterDistance;
        /* 0xC */ public float ExitDistance;
    }
}

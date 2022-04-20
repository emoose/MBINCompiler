using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x84, GUID = 0x356C2CC5235C0367, NameHash = 0x4B1DBAB6A4BE391D)]
    public class GcMissionSequenceAudioEvent : NMSTemplate
    {
        /* 0x0 */ public GcAudioWwiseEvents AudioEvent;
        /* 0x4 */ public NMSString0x80 DebugText;
    }
}

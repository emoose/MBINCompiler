using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x120, GUID = 0x2C29B14EDD2AEC6D, NameHash = 0xEAC7A07BBA50D64B)]
    public class GcMechAudioEventTable : NMSTemplate
    {
        /* 0x000 */ public GcMechAudioEvent MechEnter;
        /* 0x018 */ public GcMechAudioEvent MechExit;
        /* 0x030 */ public GcMechAudioEvent StepWalk;
        /* 0x048 */ public GcMechAudioEvent StepRun;
        /* 0x060 */ public GcMechAudioEvent TitanFallLanding;
        /* 0x078 */ public GcMechAudioEvent JumpLanding;
        /* 0x090 */ public GcMechAudioEvent JumpLandingSkid;
        /* 0x0A8 */ public GcMechAudioEvent TitanFallPoseIntro;
        /* 0x0C0 */ public GcMechAudioEvent JetpackTrigger;
        /* 0x0D8 */ public GcMechAudioEvent JetpackRetrigger;
        /* 0x0F0 */ public GcMechAudioEvent JetpackLP;
        /* 0x108 */ public GcMechAudioEvent JetpackLPEnd;
    }
}

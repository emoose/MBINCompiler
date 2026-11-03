using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB7598875DBA786B7, NameHash = 0x1CF33F48)]
    public class TkAudioComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public NMSString0x10 AmbientState;
        [NMS(Index = 7)]
        /* 0x010 */ public List<TkAudioAnimTrigger> AnimTriggers;
        [NMS(Index = 8)]
        /* 0x020 */ public List<NMSTemplate> Emitters;
        [NMS(Index = 3)]
        /* 0x030 */ public int MaxDistance;
        [NMS(Index = 4)]
        /* 0x034 */ public float OcclusionRadius;
        [NMS(Index = 5)]
        /* 0x038 */ public float OcclusionRange;
        [NMS(Index = 0)]
        /* 0x03C */ public NMSString0x80 Ambient;
        [NMS(Index = 2)]
        /* 0x0BC */ public NMSString0x80 Shutdown;
        [NMS(Index = 6)]
        /* 0x13C */ public bool LocalOnly;
    }
}

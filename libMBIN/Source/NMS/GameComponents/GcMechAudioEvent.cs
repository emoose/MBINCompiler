using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0x9C70F618EF11A610, NameHash = 0x58C0C35FA839BA96)]
    public class GcMechAudioEvent : NMSTemplate
    {
        /* 0x0 */ public GcAudioWwiseEvents DefaultEvent;
        /* 0x8 */ public List<GcMechPartAudioEventOverride> MeshPartOverrides;
    }
}

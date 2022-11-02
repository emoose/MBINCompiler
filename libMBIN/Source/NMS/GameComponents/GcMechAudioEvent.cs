using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA92321A9F87064D0, NameHash = 0x58C0C35FA839BA96)]
    public class GcMechAudioEvent : NMSTemplate
    {
        /* 0x0 */ public GcAudioWwiseEvents DefaultEvent;
        /* 0x8 */ public List<GcMechPartAudioEventOverride> MeshPartOverrides;
    }
}

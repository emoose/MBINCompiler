using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC15F7E7695D86642, NameHash = 0x77C3FF3D0260D091)]
    public class GcSentinelSpawnNamedSequence : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public List<GcSentinelSpawnSequenceStep> Waves;
    }
}

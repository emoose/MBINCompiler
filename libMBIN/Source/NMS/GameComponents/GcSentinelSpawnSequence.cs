using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEC7AFEEE03C00641, NameHash = 0xA8EFE022A74D3291)]
    public class GcSentinelSpawnSequence : NMSTemplate
    {
        /* 0x0 */ public List<GcSentinelSpawnSequenceStep> Waves;
    }
}

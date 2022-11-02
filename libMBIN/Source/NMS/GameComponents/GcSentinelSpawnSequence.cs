using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5C8D1FA8B7AE665E, NameHash = 0xA8EFE022A74D3291)]
    public class GcSentinelSpawnSequence : NMSTemplate
    {
        /* 0x0 */ public List<GcSentinelSpawnSequenceStep> Waves;
    }
}

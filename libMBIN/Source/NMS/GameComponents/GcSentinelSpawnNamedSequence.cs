using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x528C947C7D9E48ED, NameHash = 0xE031F2E5)]
    public class GcSentinelSpawnNamedSequence : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 1)]
        /* 0x10 */ public List<GcSentinelSpawnSequenceStep> Waves;
    }
}

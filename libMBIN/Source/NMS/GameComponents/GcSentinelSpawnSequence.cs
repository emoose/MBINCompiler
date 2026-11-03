using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x83A010E23FDF390D, NameHash = 0xBDBD1D49)]
    public class GcSentinelSpawnSequence : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcSentinelSpawnSequenceStep> Waves;
    }
}

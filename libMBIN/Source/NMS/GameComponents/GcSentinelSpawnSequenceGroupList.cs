using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1504D07F20F2659A, NameHash = 0xA4724D07435E3B7C)]
    public class GcSentinelSpawnSequenceGroupList : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> Sequences;
        /* 0x10 */ public List<NMSString0x10> ExtremeSequences;
    }
}

using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9CE39F8717BA45CC, NameHash = 0xA4724D07435E3B7C)]
    public class GcSentinelSpawnSequenceGroupList : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> Sequences;
        /* 0x10 */ public List<NMSString0x10> ExtremeSequences;
    }
}

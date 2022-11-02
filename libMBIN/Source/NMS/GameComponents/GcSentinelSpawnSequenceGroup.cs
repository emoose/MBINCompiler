using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA500E1C35DA17EF, NameHash = 0x3E0D2E6A5C1DE7AD)]
    public class GcSentinelSpawnSequenceGroup : NMSTemplate
    {
        /* 0x00 */ public GcSentinelSpawnSequence Sequence;
        /* 0x10 */ public GcSentinelSpawnSequence ExtremeSequence;
    }
}

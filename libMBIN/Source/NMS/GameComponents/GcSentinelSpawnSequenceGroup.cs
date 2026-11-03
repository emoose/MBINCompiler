using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x309C53DC394DE0CC, NameHash = 0x273660EC)]
    public class GcSentinelSpawnSequenceGroup : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcSentinelSpawnSequence ExtremeSequence;
        [NMS(Index = 0)]
        /* 0x10 */ public GcSentinelSpawnSequence Sequence;
    }
}

using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9C37BB9C92BD45AE, NameHash = 0x1611798444BC0C13)]
    public class GcPlayerMissionProgress : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Mission;
        /* 0x10 */ public int Progress;
        /* 0x18 */ public ulong Seed;
        /* 0x20 */ public ulong Data;
        /* 0x28 */ public ulong Stat;
        [NMS(Size = 0xD, EnumType = typeof(GcPlayerMissionParticipantType.ParticipantTypeEnum))]
        /* 0x30 */ public GcPlayerMissionParticipant[] Participants;
    }
}

using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD2740B9C47F05A27, NameHash = 0x1611798444BC0C13)]
    public class GcPlayerMissionProgress : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Mission;
        /* 0x10 */ public int Progress;
        /* 0x18 */ public ulong Seed;
        /* 0x20 */ public ulong Data;
        // size: 0xD
        public enum ParticipantsEnum {
            None,
            MissionGiver,
            MissionGiverReference,
            Primary,
            Secondary1,
            Secondary2,
            Secondary3,
            Secondary4,
            Secondary5,
            Secondary6,
            Secondary7,
            Secondary8,
            Secondary9
        }
        [NMS(Size = 0xD, EnumType = typeof(ParticipantsEnum))]
        /* 0x30 */ public GcPlayerMissionParticipant[] Participants;
    }
}

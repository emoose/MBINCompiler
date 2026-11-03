namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2BC4F0838C385E15, NameHash = 0x2433765D)]
    public class GcPlayerMissionParticipantType : NMSTemplate
    {
        // size: 0xD
        public enum ParticipantTypeEnum : uint {
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
            Secondary9,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ParticipantTypeEnum ParticipantType;
    }
}

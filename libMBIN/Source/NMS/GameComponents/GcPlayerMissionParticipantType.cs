namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x997B7F96D702D54C, NameHash = 0x233DD65A730CE9DF)]
    public class GcPlayerMissionParticipantType : NMSTemplate
    {
        // size: 0xD
        public enum ParticipantTypeEnum {
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
        /* 0x0 */ public ParticipantTypeEnum ParticipantType;
    }
}

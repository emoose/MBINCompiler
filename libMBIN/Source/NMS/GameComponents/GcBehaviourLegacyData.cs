namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD3C9EAA8F0D4C581, NameHash = 0xE727C698F36AF1CA)]
    public class GcBehaviourLegacyData : NMSTemplate
    {
        // size: 0x9
        public enum LegacyBehaviourEnum {
            Riding,
            Interaction,
            Attracted,
            Flee,
            Defend,
            FollowPlayer,
            AvoidPlayer,
            NoticePlayer,
            FollowRoutine,
        }
        /* 0x0 */ public LegacyBehaviourEnum LegacyBehaviour;
    }
}

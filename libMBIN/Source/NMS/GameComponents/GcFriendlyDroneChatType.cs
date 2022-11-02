namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB6EA81161254F2AA, NameHash = 0x6E9F63DB3D3055)]
    public class GcFriendlyDroneChatType : NMSTemplate
    {
        // size: 0x5
        public enum FriendlyDroneChatTypeEnum {
            Summoned,
            Unsummoned,
            BecomeWanted,
            LoseWanted,
            Idle
        }
        /* 0x0 */ public FriendlyDroneChatTypeEnum FriendlyDroneChatType;
    }
}

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5A6BAE9E6CE843DC, NameHash = 0x44854637)]
    public class GcFriendlyDroneChatType : NMSTemplate
    {
        // size: 0x5
        public enum FriendlyDroneChatTypeEnum : uint {
            Summoned,
            Unsummoned,
            BecomeWanted,
            LoseWanted,
            Idle,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public FriendlyDroneChatTypeEnum FriendlyDroneChatType;
    }
}

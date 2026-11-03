namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2F2CD8D5F2548511, NameHash = 0x6D3885F9)]
    public class GcSpecialPetChatType : NMSTemplate
    {
        // size: 0x3
        public enum SpecialPetChatTypeEnum : uint {
            Monster,
            Quad,
            MiniRobo,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SpecialPetChatTypeEnum SpecialPetChatType;
    }
}

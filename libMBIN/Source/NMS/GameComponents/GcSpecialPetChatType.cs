namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4FDA1EC6477A8B8C, NameHash = 0x3748852F6280E90F)]
    public class GcSpecialPetChatType : NMSTemplate
    {
        // size: 0x3
        public enum SpecialPetChatTypeEnum {
            Monster,
            Quad,
            MiniRobo,
        }
        /* 0x0 */ public SpecialPetChatTypeEnum SpecialPetChatType;
    }
}

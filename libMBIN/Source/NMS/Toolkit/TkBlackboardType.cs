namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x226208268B8D1EF3, NameHash = 0x490DAD35C9B137EF)]
    public class TkBlackboardType : NMSTemplate
    {
        // size: 0x7
        public enum BlackboardTypeEnum {
            Invalid,
            Float,
            Integer,
            Bool,
            Id,
            Vector,
            Attachment,
        }
        /* 0x0 */ public BlackboardTypeEnum BlackboardType;
    }
}

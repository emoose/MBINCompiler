namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xBCE8E25F6EA4507E, NameHash = 0xF02414A33F663A2)]
    public class TkEqualityEnum : NMSTemplate
    {
        // size: 0x5
        public enum EqualityEnumEnum {
            Equal,
            Greater,
            Less,
            GreaterEqual,
            LessEqual
        }
        /* 0x0 */ public EqualityEnumEnum EqualityEnum;
    }
}

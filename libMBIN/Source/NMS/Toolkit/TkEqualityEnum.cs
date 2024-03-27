namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xF39FA9E801BF0081, NameHash = 0xF02414A33F663A2)]
    public class TkEqualityEnum : NMSTemplate
    {
        // size: 0x5
        public enum EqualityEnumEnum : uint {
            Equal,
            Greater,
            Less,
            GreaterEqual,
            LessEqual,
        }
        /* 0x0 */ public EqualityEnumEnum EqualityEnum;
    }
}

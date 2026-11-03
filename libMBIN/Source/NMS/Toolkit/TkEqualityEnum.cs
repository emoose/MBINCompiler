namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xFB1E900128A58DD8, NameHash = 0x140F0D00)]
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
        [NMS(Index = 0)]
        /* 0x0 */ public EqualityEnumEnum EqualityEnum;
    }
}

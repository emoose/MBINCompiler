namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD39783A62EFAAC70, NameHash = 0x1FC756C2E641CC49)]
    public class GcByteBeatToken : NMSTemplate
    {
        // size: 0x12
        public enum ByteBeatTokenEnum {
            T,
            AND,
            OR,
            XOR,
            Plus,
            Minus,
            Multiply,
            Divide,
            Modulo,
            ShiftLeft,
            ShiftRight,
            Greater,
            GreaterEqual,
            Less,
            LessEqual,
            Number,
            OpenParenthesis,
            CloseParenthesis
        }
        /* 0x0 */ public ByteBeatTokenEnum ByteBeatToken;
    }
}

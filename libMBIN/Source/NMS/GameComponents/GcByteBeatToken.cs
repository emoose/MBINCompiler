namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC8EDA75443C60FCD, NameHash = 0xDF04CB7)]
    public class GcByteBeatToken : NMSTemplate
    {
        // size: 0x12
        public enum ByteBeatTokenEnum : uint {
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
            CloseParenthesis,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ByteBeatTokenEnum ByteBeatToken;
    }
}

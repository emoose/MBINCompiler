namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF47704AA47CFE60E, NameHash = 0xEBF66E98)]
    public class GcHand : NMSTemplate
    {
        // size: 0x2
        public enum HandEnum : uint {
            Right,
            Left,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public HandEnum Hand;
    }
}

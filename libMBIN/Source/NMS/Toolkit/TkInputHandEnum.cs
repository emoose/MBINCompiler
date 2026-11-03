namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x30F2E80541BB7A95, NameHash = 0xBB6D663E)]
    public class TkInputHandEnum : NMSTemplate
    {
        // size: 0x3
        public enum InputHandEnum : uint {
            None,
            Left,
            Right,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public InputHandEnum InputHand;
    }
}

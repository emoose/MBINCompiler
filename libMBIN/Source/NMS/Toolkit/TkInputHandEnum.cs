namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA63EFCA0252EEBBD, NameHash = 0xC47947D0C35F984E)]
    public class TkInputHandEnum : NMSTemplate
    {
        // size: 0x3
        public enum InputHandEnum {
            None,
            Left,
            Right
        }
        /* 0x0 */ public InputHandEnum InputHand;
    }
}

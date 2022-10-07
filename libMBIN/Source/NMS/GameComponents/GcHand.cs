namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAB044AA8311F68AD, NameHash = 0xDF2E636EA66DCE65)]
    public class GcHand : NMSTemplate
    {
        // size: 0x2
        public enum HandEnum {
            Right,
            Left
        }
        /* 0x0 */ public HandEnum Hand;
    }
}

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8F10A74717B2F0F1, NameHash = 0xB90A6A8C6ACFE0BC)]
    public class TkNGuiForcedStyle : NMSTemplate
    {
        // size: 0x4
        public enum NGuiForcedStyleEnum {
            None,
            Default,
            Highlight,
            Active
        }
        /* 0x0 */ public NGuiForcedStyleEnum NGuiForcedStyle;
    }
}

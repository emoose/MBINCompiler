namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xAC4F83C955B06A08, NameHash = 0x89B44B6A)]
    public class TkNGuiForcedStyle : NMSTemplate
    {
        // size: 0x5
        public enum NGuiForcedStyleEnum : uint {
            None,
            Default,
            Highlight,
            Active,
            Disabled,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NGuiForcedStyleEnum NGuiForcedStyle;
    }
}

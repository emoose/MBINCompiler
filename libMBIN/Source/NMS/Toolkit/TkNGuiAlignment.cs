namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x71FA853C1F36341F, NameHash = 0xD1E7F0BE0B98FD48)]
    public class TkNGuiAlignment : NMSTemplate
    {
        // size: 0x3
        public enum VerticalEnum : byte {
            Top,
            Middle,
            Bottom,
        }
        /* 0x0 */ public VerticalEnum Vertical;
        // size: 0x3
        public enum HorizontalEnum : byte {
            Left,
            Center,
            Right,
        }
        /* 0x1 */ public HorizontalEnum Horizontal;
    }
}

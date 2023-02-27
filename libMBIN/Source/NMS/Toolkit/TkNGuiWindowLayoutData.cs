namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x80CA7ECB56702722, NameHash = 0x9650958F04D49C46)]
    public class TkNGuiWindowLayoutData : NMSTemplate
    {
        /* 0x0000 */ public NMSString0x80 Name;
        [NMS(Size = 0x20)]
        /* 0x0080 */ public NMSString0x80[] Tabs;
        /* 0x1080 */ public float PositionX;
        /* 0x1084 */ public float PositionY;
        /* 0x1088 */ public float SizeX;
        /* 0x108C */ public float SizeY;
        /* 0x1090 */ public float Separator;
        /* 0x1094 */ public int ActiveTabIdx;
        /* 0x1098 */ public float ScrollX;
        /* 0x109C */ public float ScrollY;
        // size: 0x3
        public enum WindowStateEnum : byte {
            Open,
            Minimised,
            Closed,
        }
        /* 0x10A0 */ public WindowStateEnum WindowState;
    }
}

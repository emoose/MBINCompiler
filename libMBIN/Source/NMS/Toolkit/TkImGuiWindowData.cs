namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x159F70DC858BFEB9, NameHash = 0x431A784D584CBE50)]
    public class TkImGuiWindowData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Type;
        /* 0x80 */ public int WindowX;
        /* 0x84 */ public int WindowY;
        /* 0x88 */ public int WindowW;
        /* 0x8C */ public int WindowH;
        /* 0x90 */ public int WindowMinW;
        /* 0x94 */ public int WindowMinH;
        /* 0x98 */ public bool WindowResize;
        /* 0x9C */ public int WindowScroll;
        /* 0xA0 */ public int WindowTab;
        /* 0xA4 */ public bool WindowOpen;
        /* 0xA5 */ public bool WindowMinimised;
        /* 0xA6 */ public bool WindowUsed;
    }
}

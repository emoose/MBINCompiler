using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD93E7BCFFAC67831, NameHash = 0xE8F15AD4B3CB30AC)]
    public class TkImGuiData : NMSTemplate
    {
        /* 0x0000 */ public TkImGuiWindowData MainWindow;
        /* 0x00A8 */ public bool Maximised;
        /* 0x00AC */ public int DimensionX;
        /* 0x00B0 */ public int DimensionY;
        [NMS(Size = 0xA)]
        /* 0x00B4 */ public NMSString0x80[] RecentToolbox;
        [NMS(Size = 0x80)]
        /* 0x05B4 */ public TkImGuiWindowData[] WindowTable;
        /* 0x59B4 */ public int WindowCount;
    }
}

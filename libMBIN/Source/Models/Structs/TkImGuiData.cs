namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0EAAFDE92AF042A96)]
    public class TkImGuiData : NMSTemplate
    {
        public TkImGuiWindowData MainWindow;
        public bool Maximised;
        public int DimensionX;
        public int DimensionY;
        [NMS(Size = 0xA)]
        public NMSString0x80[] RecentToolbox;
        [NMS(Size = 0x80)]
        public TkImGuiWindowData[] WindowTable;
        public int WindowCount;
    }
}

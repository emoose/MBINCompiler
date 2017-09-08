namespace MBINCompiler.Models.Structs
{
    public class TkImGuiWindowData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Type;

        public int WindowX;
        public int WindowY;
        public int WindowW;
        public int WindowH;
        public int WindowMinW;
        public int WindowMinH;
        public bool WindowResize;
        public int WindowScroll;
        public int WindowTab;
        public bool WindowOpen;
        public bool WindowMinimised;
        public bool WindowUsed;

        [NMS(Size = 1, Ignore = true)]
        public byte[] PaddingA7;
    }
}

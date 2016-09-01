namespace MBINCompiler.Models.Structs
{
    public class TkNGuiLayoutListData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Name;
        [NMS(Size = 0x80)]
        public string Filename;
        [NMS(Size = 0x80)]
        public string Default;
    }
}

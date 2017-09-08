namespace MBINCompiler.Models.Structs
{
    [NMS(Size = 0x88B80)]
    public class TkInputFrameArray : NMSTemplate
    {
        [NMS(Size = 0x4E20)] // INPUTTEST.MBIN has a different count of these? uncertain because we can't tell the MBIN header size..
        public TkInputFrame[] Array;
    }
}

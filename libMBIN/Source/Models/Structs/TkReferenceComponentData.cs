namespace MBINCompiler.Models.Structs
{
    public class TkReferenceComponentData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Reference;
        [NMS(Size = 0x80)]
        public string LSystem;
    }
}

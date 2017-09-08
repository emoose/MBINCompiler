namespace MBINCompiler.Models.Structs // 0x48
{
    public class EmptyNode : NMSTemplate
    {

        [NMS(Size = 0x0, Ignore = true)]
        public byte[] Padding;
    }
}
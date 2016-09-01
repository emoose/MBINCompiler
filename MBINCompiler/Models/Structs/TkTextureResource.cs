using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class TkTextureResource : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Filename;
        [NMSAttribute(Ignore = true)]
        public int EmptyNode1;
    }
}

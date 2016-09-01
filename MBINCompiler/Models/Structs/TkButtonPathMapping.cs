using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class TkButtonPathMapping : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        [NMS(Size = 0x80)]
        public string Path;
    }
}

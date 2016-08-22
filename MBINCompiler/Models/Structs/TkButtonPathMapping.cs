using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class TkButtonPathMapping : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Id;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string Path;
    }
}

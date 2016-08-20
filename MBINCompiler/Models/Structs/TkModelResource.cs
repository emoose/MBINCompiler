using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class TkModelResource : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string Filename;
        public int EmptyNode1;
    }
}

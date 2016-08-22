using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcCreatureFilename : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string ID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string Filename;
    }
}

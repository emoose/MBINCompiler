using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class TkNGuiLayoutListData : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string Name;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string Filename;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string Default;
    }
}

using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class TkLanguageFontTableEntry : NMSTemplate
    {
        public TkLanguages Language;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string GameFont;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string GameFont2;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string ConsoleFont;
    }
}

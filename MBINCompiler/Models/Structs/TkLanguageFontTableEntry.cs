using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class TkLanguageFontTableEntry : NMSTemplate
    {
        public TkLanguages Language;
        [NMS(Size = 0x80)]
        public string GameFont;
        [NMS(Size = 0x80)]
        public string GameFont2;
        [NMS(Size = 0x80)]
        public string ConsoleFont;
    }
}

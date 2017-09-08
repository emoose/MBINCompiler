namespace libMBIN.Models.Structs
{
    public class TkLanguageFontTableEntry : NMSTemplate     // size: 0x184
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

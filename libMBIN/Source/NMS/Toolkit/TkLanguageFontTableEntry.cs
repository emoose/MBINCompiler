using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x7B2B5D630B5FF0F9, NameHash = 0x703BD36A)]
    public class TkLanguageFontTableEntry : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public GcFilename ConsoleFont;
        [NMS(Index = 4)]
        /* 0x10 */ public GcFilename ConsoleFont2;
        [NMS(Index = 1)]
        /* 0x20 */ public GcFilename GameFont;
        [NMS(Index = 2)]
        /* 0x30 */ public GcFilename GameFont2;
        [NMS(Index = 0)]
        /* 0x40 */ public TkLanguages Language;
    }
}

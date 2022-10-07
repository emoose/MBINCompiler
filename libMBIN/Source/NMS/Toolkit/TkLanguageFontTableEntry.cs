using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x31EF165D0298C2F1, NameHash = 0x5D212FC5B6A065A4)]
    public class TkLanguageFontTableEntry : NMSTemplate
    {
        /* 0x000 */ public TkLanguages Language;
        /* 0x004 */ public NMSString0x80 GameFont;
        /* 0x084 */ public NMSString0x80 GameFont2;
        /* 0x104 */ public NMSString0x80 ConsoleFont;
        /* 0x184 */ public NMSString0x80 ConsoleFont2;
    }
}

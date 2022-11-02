using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x60AD27FC2FAE9EBD, NameHash = 0x55D8E71C0A29B511)]
    public class TkNGuiTextStyle : NMSTemplate
    {
        /* 0x00 */ public TkNGuiTextStyleData Default;
        /* 0x70 */ public TkNGuiTextStyleData Highlight;
        /* 0xE0 */ public TkNGuiTextStyleData Active;
    }
}

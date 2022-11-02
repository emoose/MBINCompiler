using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x19695D4EC5683F06, NameHash = 0x633D54FB94B2C6A4)]
    public class GcNGuiPresetText : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 PresetID;
        /* 0x010 */ public GcNGuiLayoutData Layout;
        /* 0x060 */ public TkNGuiTextStyle Style;
        /* 0x1B0 */ public TkNGuiGraphicStyle GraphicStyle;
        /* 0x3D0 */ public NMSString0x80 Image;
    }
}

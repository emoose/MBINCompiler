using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x420, GUID = 0x8F41F68129C80E1D, NameHash = 0x633D54FB94B2C6A4)]
    public class GcNGuiPresetText : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 PresetID;
        /* 0x010 */ public GcNGuiLayoutData Layout;
        /* 0x060 */ public TkNGuiTextStyle Style;
        /* 0x180 */ public TkNGuiGraphicStyle GraphicStyle;
        /* 0x3A0 */ public NMSString0x80 Image;
    }
}

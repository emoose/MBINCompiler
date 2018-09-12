using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x360, GUID = 0x0E68E3A6E41FA4306)]
    public class GcNGuiPresetText : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string PresetID;
        /* 0x010 */ public GcNGuiLayoutData Layout;
        [NMS(Size = 0x4)]
        /* 0x03C */ public byte[] Padding3C;

        /* 0x040 */ public TkNGuiTextStyle Style;
        /* 0x130 */ public TkNGuiGraphicStyle GraphicStyle;
        [NMS(Size = 0x80)]
        /* 0x2E0 */ public string Image;
    }
}

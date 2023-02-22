using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC63CBB76AABD52D4, NameHash = 0x247C56DDB7B4E25A)]
    public class GcNGuiPresetGraphic : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 PresetID;
        /* 0x010 */ public GcNGuiLayoutData Layout;
        /* 0x060 */ public TkNGuiGraphicStyle Style;
        /* 0x240 */ public NMSString0x80 Image;
    }
}

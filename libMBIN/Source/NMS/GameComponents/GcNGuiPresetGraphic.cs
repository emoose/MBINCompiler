using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x2F0, GUID = 0x8D88612A416E1523, NameHash = 0x247C56DDB7B4E25A)]
    public class GcNGuiPresetGraphic : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string PresetID;
        /* 0x010 */ public GcNGuiLayoutData Layout;
        /* 0x050 */ public TkNGuiGraphicStyle Style;
        [NMS(Size = 0x80)]
        /* 0x270 */ public string Image;
    }
}

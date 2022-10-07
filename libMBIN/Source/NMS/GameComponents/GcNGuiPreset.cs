using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1225935C0558A39, NameHash = 0x31B2A19D40422178)]
    public class GcNGuiPreset : NMSTemplate
    {
        /* 0x0000 */ public NMSString0x80 Font;
        [NMS(Size = 0xA)]
        /* 0x0080 */ public GcNGuiPresetGraphic[] Layer;
        [NMS(Size = 0xA)]
        /* 0x1E80 */ public GcNGuiPresetGraphic[] Graphic;
        [NMS(Size = 0xA)]
        /* 0x3C80 */ public GcNGuiPresetText[] Text;
        /* 0x67A0 */ public GcNGuiLayoutData SpacingLayout;
    }
}

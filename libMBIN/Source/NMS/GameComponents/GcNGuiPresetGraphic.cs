using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF248560A87D31853, NameHash = 0xA40EDAE)]
    public class GcNGuiPresetGraphic : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcNGuiLayoutData Layout;
        [NMS(Index = 3)]
        /* 0x48 */ public GcFilename Image;
        [NMS(Index = 0)]
        /* 0x58 */ public NMSString0x10 PresetID;
        [NMS(Index = 2)]
        /* 0x68 */ public TkNGuiGraphicStyle Style;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x310, GUID = 0xD7FF7F65F0573913, NameHash = 0x264B878043DA20B3)]
    public class GcNGuiGraphicData : NMSTemplate
    {
        /* 0x000 */ public GcNGuiElementData ElementData;
        /* 0x070 */ public TkNGuiGraphicStyle Style;
        /* 0x290 */ public NMSString0x80 Image;
    }
}

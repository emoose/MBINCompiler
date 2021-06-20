using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x650, GUID = 0x62F5488712061AE6, NameHash = 0x4C5F02B93CB08B1A)]
    public class GcNGuiTextData : NMSTemplate
    {
        /* 0x000 */ public GcNGuiElementData ElementData;
        /* 0x070 */ public TkNGuiTextStyle Style;
        /* 0x190 */ public TkNGuiGraphicStyle GraphicStyle;
        /* 0x3B0 */ public NMSString0x80 Image;
        /* 0x430 */ public NMSString0x200 Text;
        /* 0x630 */ public bool Special;
        /* 0x638 */ public List<GcVROverride_Text> VROverrides;
    }
}

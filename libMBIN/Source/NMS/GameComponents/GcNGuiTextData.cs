using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x399A33599C8EC1D3, NameHash = 0x4C5F02B93CB08B1A)]
    public class GcNGuiTextData : NMSTemplate
    {
        /* 0x000 */ public GcNGuiElementData ElementData;
        /* 0x070 */ public TkNGuiTextStyle Style;
        /* 0x190 */ public TkNGuiGraphicStyle GraphicStyle;
        /* 0x370 */ public NMSString0x200 Text;
        /* 0x570 */ public NMSString0x80 Image;
        /* 0x5F0 */ public float ForcedOffset;
        /* 0x5F8 */ public List<GcVROverride_Text> VROverrides;
        /* 0x608 */ public List<GcAccessibleOverride_Text> AccessibleOverrides;
        /* 0x618 */ public bool Special;
        /* 0x619 */ public bool ForcedAllowScroll;
    }
}

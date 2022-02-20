using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x670, GUID = 0xAF4F2518484D05BA, NameHash = 0x4C5F02B93CB08B1A)]
    public class GcNGuiTextData : NMSTemplate
    {
        /* 0x000 */ public GcNGuiElementData ElementData;
        /* 0x080 */ public TkNGuiTextStyle Style;
        /* 0x1A0 */ public TkNGuiGraphicStyle GraphicStyle;
        /* 0x3C0 */ public NMSString0x80 Image;
        /* 0x440 */ public NMSString0x200 Text;
        /* 0x640 */ public bool Special;
        /* 0x648 */ public List<GcVROverride_Text> VROverrides;
        /* 0x658 */ public List<GcAccessibleOverride_Text> AccessibleOverrides;
    }
}

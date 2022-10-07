using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1379A81E9E55045F, NameHash = 0x4C5F02B93CB08B1A)]
    public class GcNGuiTextData : NMSTemplate
    {
        /* 0x000 */ public GcNGuiElementData ElementData;
        /* 0x080 */ public TkNGuiTextStyle Style;
        /* 0x1D0 */ public TkNGuiGraphicStyle GraphicStyle;
        /* 0x3F0 */ public NMSString0x80 Image;
        /* 0x470 */ public NMSString0x200 Text;
        /* 0x670 */ public bool Special;
        /* 0x674 */ public float ForcedOffset;
        /* 0x678 */ public bool ForcedAllowScroll;
        /* 0x680 */ public List<GcVROverride_Text> VROverrides;
        /* 0x690 */ public List<GcAccessibleOverride_Text> AccessibleOverrides;
    }
}

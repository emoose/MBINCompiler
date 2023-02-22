using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x73FAEAF445FBDC01, NameHash = 0x585832A31F4C2EA1)]
    public class GcNGuiLayerData : NMSTemplate
    {
        /* 0x000 */ public GcNGuiElementData ElementData;
        /* 0x070 */ public TkNGuiGraphicStyle Style;
        /* 0x250 */ public NMSString0x80 Image;
        /* 0x2D0 */ public List<NMSTemplate> Children;
        /* 0x2E0 */ public NMSString0x80 DataFilename;
        // size: 0x3
        public enum AltModeEnum {
            None,
            Normal,
            Alt,
        }
        /* 0x360 */ public AltModeEnum AltMode;
    }
}

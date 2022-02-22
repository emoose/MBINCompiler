using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x3C0, GUID = 0x6AE9A0846E8C4835, NameHash = 0x585832A31F4C2EA1)]
    public class GcNGuiLayerData : NMSTemplate
    {
        /* 0x000 */ public GcNGuiElementData ElementData;
        /* 0x080 */ public TkNGuiGraphicStyle Style;
        /* 0x2A0 */ public NMSString0x80 Image;
        /* 0x320 */ public List<NMSTemplate> Children;
        /* 0x330 */ public NMSString0x80 DataFilename;
        // size: 0x3
        public enum AltModeEnum { None, Normal, Alt }
        /* 0x3B0 */ public AltModeEnum AltMode;
    }
}

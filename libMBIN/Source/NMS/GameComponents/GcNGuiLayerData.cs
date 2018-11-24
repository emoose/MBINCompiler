using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Alignment = 0x10, Size = 0x320, GUID = 0x7C767D18FDA6CB96)]
    public class GcNGuiLayerData : NMSTemplate
    {
        /* 0x000 */ public GcNGuiElementData ElementData;
        /* 0x050 */ public TkNGuiGraphicStyle Style;
        [NMS(Size = 0x80)]
        /* 0x200 */ public string Image;
        /* 0x280 */ public List<NMSTemplate> Children;
        [NMS(Size = 0x80)]
        /* 0x290 */ public string DataFilename;
        public enum AltModeEnum { None, Normal, Alt}
        /* 0x310 */ public AltModeEnum AltMode;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x314 */ public byte[] EndPadding;
    }
}

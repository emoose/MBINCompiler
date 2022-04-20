using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x20, GUID = 0x16EA3469D142FAD6, NameHash = 0x8AC0161286DB6A30)]
    public class GcCharacterCustomisationColourData : NMSTemplate
    {
        /* 0x00 */ public TkPaletteTexture Palette;
        /* 0x10 */ public Colour Colour;
    }
}

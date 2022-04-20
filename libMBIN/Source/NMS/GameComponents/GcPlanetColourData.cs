using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x1880, GUID = 0xA5943DFEC116B5B7, NameHash = 0x555E177C27F47DDB)]
    public class GcPlanetColourData : NMSTemplate
    {
        [NMS(Size = 0x38, EnumType = typeof(TkPaletteTexture.PaletteEnum))]
        /* 0x0 */ public GcColourPaletteData[] Palettes;
    }
}

using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x64, GUID = 0x6FE119BA9BDFBC74, NameHash = 0x30CD85DD787F512A)]
    public class GcTileTypeSet : NMSTemplate
    {
        /* 0x0 */ public float Probability;
        [NMS(Size = 0xC)]
        /* 0x4 */ public TkPaletteTexture[] Colours;
    }
}

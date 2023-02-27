using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDD0257E0F0D9E53B, NameHash = 0xDBD890CF58AC39B5)]
    public class GcTileTypeOptions : NMSTemplate
    {
        /* 0x0 */ public List<TkPaletteTexture> Options;
    }
}

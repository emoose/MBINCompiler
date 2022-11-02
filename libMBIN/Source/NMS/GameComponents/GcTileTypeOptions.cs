using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD5B21DDB73FF0C18, NameHash = 0xDBD890CF58AC39B5)]
    public class GcTileTypeOptions : NMSTemplate
    {
        /* 0x0 */ public List<TkPaletteTexture> Options;
    }
}

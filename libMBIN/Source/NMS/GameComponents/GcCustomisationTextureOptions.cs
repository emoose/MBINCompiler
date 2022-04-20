using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0x8449D9846760DA82, NameHash = 0x6464F543A870D3F3)]
    public class GcCustomisationTextureOptions : NMSTemplate
    {
        /* 0x0 */ public List<GcCustomisationTextureOption> TextureOptions;
    }
}

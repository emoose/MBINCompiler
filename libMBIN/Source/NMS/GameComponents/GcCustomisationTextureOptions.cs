using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8DEDCDAA2C511216, NameHash = 0x6464F543A870D3F3)]
    public class GcCustomisationTextureOptions : NMSTemplate
    {
        /* 0x0 */ public List<GcCustomisationTextureOption> TextureOptions;
    }
}

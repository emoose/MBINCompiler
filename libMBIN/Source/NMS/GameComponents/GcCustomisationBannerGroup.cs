using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x830, GUID = 0x931EDF27CED6F670, NameHash = 0xD679E7C47BC9313C)]
    public class GcCustomisationBannerGroup : NMSTemplate
    {
        /* 0x000 */ public List<GcCustomisationBannerImageData> BannerImages;
        /* 0x010 */ public GcPaletteData MainColours;
        /* 0x420 */ public GcPaletteData BackgroundColours;
    }
}

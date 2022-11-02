using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCEC80F155B3BA99A, NameHash = 0xD679E7C47BC9313C)]
    public class GcCustomisationBannerGroup : NMSTemplate
    {
        /* 0x000 */ public List<GcCustomisationBannerImageData> BannerImages;
        /* 0x010 */ public GcPaletteData MainColours;
        /* 0x420 */ public GcCustomisationColourPaletteExtraData MainColoursExtraData;
        /* 0x440 */ public GcPaletteData BackgroundColours;
        /* 0x850 */ public GcCustomisationColourPaletteExtraData BackgroundColoursExtraData;
    }
}

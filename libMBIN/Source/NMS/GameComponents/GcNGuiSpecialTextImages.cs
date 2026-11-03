using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC5F8B9209A37977F, NameHash = 0x4A2BA9B8)]
    public class GcNGuiSpecialTextImages : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcNGuiSpecialTextImageData> SpecialImages;
    }
}

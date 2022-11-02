using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x369170211BACA753, NameHash = 0x6AE3CB3B6A5A155D)]
    public class GcWeatherEffectTable : NMSTemplate
    {
        /* 0x0 */ public List<GcWeatherEffect> Effects;
    }
}

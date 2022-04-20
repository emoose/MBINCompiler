using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0xCF080381CE420340, NameHash = 0x6AE3CB3B6A5A155D)]
    public class GcWeatherEffectTable : NMSTemplate
    {
        /* 0x0 */ public List<GcWeatherEffect> Effects;
    }
}

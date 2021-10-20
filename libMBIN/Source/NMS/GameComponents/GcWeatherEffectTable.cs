using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0x13E6D80F5BF3A7B3, NameHash = 0x6AE3CB3B6A5A155D)]
    public class GcWeatherEffectTable : NMSTemplate
    {
        public List<GcWeatherEffect> Effects;
    }
}

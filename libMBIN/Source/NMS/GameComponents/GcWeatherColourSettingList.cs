using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6923174191E64B41, NameHash = 0xB5D0CD9B9ED4C2E8)]
    public class GcWeatherColourSettingList : NMSTemplate
    {
        /* 0x0 */ public List<GcPlanetWeatherColourData> Settings;
    }
}

using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF69E36CC1473AB56, NameHash = 0xB5D0CD9B9ED4C2E8)]
    public class GcWeatherColourSettingList : NMSTemplate
    {
        /* 0x0 */ public List<GcPlanetWeatherColourData> Settings;
    }
}

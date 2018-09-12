using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x6923174191E64B41)]
    public class GcWeatherColourSettingList : NMSTemplate
    {
        public List<GcPlanetWeatherColourData> Settings;
    }
}

using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x6923174191E64B41)]
    public class GcWeatherColourSettingList : NMSTemplate
    {
        public List<GcPlanetWeatherColourData> Settings;
    }
}

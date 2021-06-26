using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x6923174191E64B41, NameHash = 0xB5D0CD9B9ED4C2E8)]
    public class GcWeatherColourSettingList : NMSTemplate
    {
        public List<GcPlanetWeatherColourData> Settings;
    }
}
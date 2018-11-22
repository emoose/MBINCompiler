using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xDDF10BFCF81EB27B)]
    public class GcWaterColourSettingList : NMSTemplate
    {
        public List<GcPlanetWaterColourData> Settings;
    }
}

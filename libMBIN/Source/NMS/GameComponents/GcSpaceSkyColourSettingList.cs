using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0E8C6C0EE1B649953)]
    public class GcSpaceSkyColourSettingList : NMSTemplate      // size: 0x10
    {
	    public List<GcSolarSystemSkyColourData> Settings;
    }
}

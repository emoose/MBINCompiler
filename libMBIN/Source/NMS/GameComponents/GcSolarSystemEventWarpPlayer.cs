using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xF4CB9735961EC39E)]
    public class GcSolarSystemEventWarpPlayer : NMSTemplate
    {
        /* 0x00 */ public GcSolarSystemLocatorChoice Locator;
        /* 0x2C */ public float Time;
    }
}

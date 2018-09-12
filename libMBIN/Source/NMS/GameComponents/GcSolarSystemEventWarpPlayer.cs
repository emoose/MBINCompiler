using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0F4CB9735961EC39E)]
    public class GcSolarSystemEventWarpPlayer : NMSTemplate
    {
        /* 0x00 */ public GcSolarSystemLocatorChoice Locator;
        /* 0x2C */ public float Time;
    }
}

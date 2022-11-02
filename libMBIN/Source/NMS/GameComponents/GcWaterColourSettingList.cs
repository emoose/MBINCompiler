using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x646B990EC8E1CE45, NameHash = 0xB2E60FCA3C5550F9)]
    public class GcWaterColourSettingList : NMSTemplate
    {
        /* 0x0 */ public List<GcPlanetWaterColourData> Settings;
    }
}

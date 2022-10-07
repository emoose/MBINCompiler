using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE8C6C0EE1B649953, NameHash = 0x14C4B281A2FBD940)]
    public class GcSpaceSkyColourSettingList : NMSTemplate
    {
        /* 0x0 */ public List<GcSolarSystemSkyColourData> Settings;
    }
}

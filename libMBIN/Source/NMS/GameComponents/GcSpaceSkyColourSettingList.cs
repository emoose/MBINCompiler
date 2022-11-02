using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x27A7917A34A96384, NameHash = 0x14C4B281A2FBD940)]
    public class GcSpaceSkyColourSettingList : NMSTemplate
    {
        /* 0x0 */ public List<GcSolarSystemSkyColourData> Settings;
    }
}

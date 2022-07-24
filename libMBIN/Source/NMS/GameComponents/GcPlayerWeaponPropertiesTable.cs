using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x2A30, GUID = 0xC0A4600444DBAC54, NameHash = 0xD90787619164B12C)]
    public class GcPlayerWeaponPropertiesTable : NMSTemplate
    {
        /* 0x0 */ public GcCamouflageData CamouflageData;
        [NMS(Size = 0x13)]
        /* 0xA0 */ public GcPlayerWeaponPropertiesData[] PropertiesData;
    }
}

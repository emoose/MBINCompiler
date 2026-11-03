using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC8CAABF882E7248E, NameHash = 0xFF14721C)]
    public class GcGasGiantAtmosphereSettingsList : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcFilename> LookUps;
        [NMS(Index = 2)]
        /* 0x10 */ public List<GcFilename> Normals;
        [NMS(Index = 0)]
        /* 0x20 */ public List<GcGasGiantAtmosphereSetting> Settings;
    }
}

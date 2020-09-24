using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x3A0, GUID = 0xBF22EBF8DC881AFF, NameHash = 0x7333B5EC725370EF)]
    public class GcPlanetSkyProperties : NMSTemplate
    {
        /* 0x000 */ public GcSkyProperties PlanetSky;
        /* 0x030 */ public GcFogProperties PlanetFog;
        /* 0x10C */ public GcFogProperties PlanetExtremeFog;
        /* 0x1E8 */ public GcFogProperties PlanetStormFog;
        /* 0x2C4 */ public GcFogProperties PlanetFlightFog;
    }
}

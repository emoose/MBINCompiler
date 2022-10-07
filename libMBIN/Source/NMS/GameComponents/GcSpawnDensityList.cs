using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9585FA88C7E438B9, NameHash = 0xED492007250EEE25)]
    public class GcSpawnDensityList : NMSTemplate
    {
        /* 0x0 */ public List<GcSpawnDensity> DensityList;
    }
}

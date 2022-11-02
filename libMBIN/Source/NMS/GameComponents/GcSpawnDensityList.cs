using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6634953321B34091, NameHash = 0xED492007250EEE25)]
    public class GcSpawnDensityList : NMSTemplate
    {
        /* 0x0 */ public List<GcSpawnDensity> DensityList;
    }
}

using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x59E8152F3D9078A8, NameHash = 0x6BF62723)]
    public class GcFrigateTraitTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcFrigateTraitData> Traits;
    }
}

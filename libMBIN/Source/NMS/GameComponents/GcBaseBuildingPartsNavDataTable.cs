using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2DC4FEA70DE05D44, NameHash = 0x2DC080D1)]
    public class GcBaseBuildingPartsNavDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcBaseBuildingPartNavData> Parts;
    }
}

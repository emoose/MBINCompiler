using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAB32E2266B20B4C3, NameHash = 0xD12E966E50238278)]
    public class GcBaseBuildingPartsNavDataTable : NMSTemplate
    {
        /* 0x0 */ public List<GcBaseBuildingPartNavData> Parts;
    }
}

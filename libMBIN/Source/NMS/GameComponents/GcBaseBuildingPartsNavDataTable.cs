using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB6967F7549AD6A0, NameHash = 0xD12E966E50238278)]
    public class GcBaseBuildingPartsNavDataTable : NMSTemplate
    {
        /* 0x0 */ public List<GcBaseBuildingPartNavData> Parts;
    }
}

using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x16033E17DD2506E, NameHash = 0x56ACF1BE57EEA8E9)]
    public class GcBaseBuildingPartsDataTable : NMSTemplate
    {
        /* 0x0 */ public List<GcBaseBuildingPartData> PartsData;
    }
}

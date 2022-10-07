using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x70E8CDC29BE15B93, NameHash = 0x56ACF1BE57EEA8E9)]
    public class GcBaseBuildingPartsDataTable : NMSTemplate
    {
        /* 0x0 */ public List<GcBaseBuildingPartData> PartsData;
    }
}

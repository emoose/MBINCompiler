using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC8623D2287EA15A8, NameHash = 0x87AF3D11ECD3C009)]
    public class GcBaseBuildingPartsTable : NMSTemplate
    {
        /* 0x0 */ public List<GcBaseBuildingPart> Parts;
    }
}

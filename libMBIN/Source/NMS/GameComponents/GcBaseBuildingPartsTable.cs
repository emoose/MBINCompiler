using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0x775515EA93FE4356, NameHash = 0x87AF3D11ECD3C009)]
    public class GcBaseBuildingPartsTable : NMSTemplate
    {
        public List<GcBaseBuildingPart> Parts;
    }
}

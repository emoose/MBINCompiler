using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC3641CF5E0C94A58, NameHash = 0x82286E866B7201D0)]
    public class GcGrabbableComponentData : NMSTemplate
    {
        /* 0x0 */ public List<GcGrabbableData> GrabbableDataArray;
    }
}

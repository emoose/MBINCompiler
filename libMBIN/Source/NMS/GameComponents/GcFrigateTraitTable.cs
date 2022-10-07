using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x74F2737E186F2AFD, NameHash = 0xA6A94B5FC4AC3D18)]
    public class GcFrigateTraitTable : NMSTemplate
    {
        /* 0x0 */ public List<GcFrigateTraitData> Traits;
    }
}

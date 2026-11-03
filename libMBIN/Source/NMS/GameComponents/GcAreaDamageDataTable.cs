using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1EB712E87F4E0B2D, NameHash = 0x64882C9C)]
    public class GcAreaDamageDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcAreaDamageData> Table;
    }
}

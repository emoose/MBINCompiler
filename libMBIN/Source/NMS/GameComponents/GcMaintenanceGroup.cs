using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB63480FB49EE4C3C, NameHash = 0x989F3C45C63EA6B8)]
    public class GcMaintenanceGroup : NMSTemplate
    {
        /* 0x0 */ public List<GcMaintenanceGroupEntry> Table;
    }
}

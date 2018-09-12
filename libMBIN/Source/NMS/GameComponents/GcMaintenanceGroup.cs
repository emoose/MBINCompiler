using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0B63480FB49EE4C3C)]
    public class GcMaintenanceGroup : NMSTemplate
    {
        public List<GcMaintenanceGroupEntry> Table;
    }
}

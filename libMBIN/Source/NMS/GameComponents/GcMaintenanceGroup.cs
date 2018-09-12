using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0B63480FB49EE4C3C)]
    public class GcMaintenanceGroup : NMSTemplate
    {
        public List<GcMaintenanceGroupEntry> Table;
    }
}

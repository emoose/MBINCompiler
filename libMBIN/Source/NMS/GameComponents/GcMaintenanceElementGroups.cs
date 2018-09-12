using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0C73DD3B92E35C5CE)]
    public class GcMaintenanceElementGroups : NMSTemplate
    {
		public enum MaintenanceGroupEnum { Custom, Farming, Fuelling, Repairing, Cleaning }
		public MaintenanceGroupEnum MaintenanceGroup;
    }
}

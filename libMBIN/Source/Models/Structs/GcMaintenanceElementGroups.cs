using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcMaintenanceElementGroups : NMSTemplate
    {
        public int MaintenanceGroup;
        public string[] MaintenanceGroupValues()
        {
            return new[] { "Custom", "Farming", "Fuelling", "Repairing", "Cleaning"};
        }
    }
}

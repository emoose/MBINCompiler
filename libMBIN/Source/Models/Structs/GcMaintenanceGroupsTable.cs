using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcMaintenanceGroupsTable : NMSTemplate
    {
        [NMS(Size = 0x5, EnumValue = new string[5] { "Custom", "Farming", "Fuelling", "Repairing", "Cleaning" })]
        public GcMaintenanceGroup[] Groups;
    }
}

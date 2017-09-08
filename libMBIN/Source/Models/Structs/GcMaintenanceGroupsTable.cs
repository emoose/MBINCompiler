using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcMaintenanceGroupsTable : NMSTemplate
    {
        [NMS(Size = 0x5)]
        public GcMaintenanceGroup[] Groups;
    }
}

using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x58F8C89CC8A7C2F0)]
    public class GcCreatureRoleDataTable : NMSTemplate
    {
        public List<GcCreatureRoleData> AvailableRoles;
    }
}

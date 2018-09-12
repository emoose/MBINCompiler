using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x5A4C8E158976A977)]
    public class GcCreatureRoleFilenameList : NMSTemplate // 0x10 bytes
    {
        public List<GcCreatureRoleFilename> Options;
    }
}

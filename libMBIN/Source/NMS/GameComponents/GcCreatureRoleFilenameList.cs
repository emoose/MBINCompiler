using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x5A4C8E158976A977)]
    public class GcCreatureRoleFilenameList : NMSTemplate // 0x10 bytes
    {
        public List<GcCreatureRoleFilename> Options;
    }
}

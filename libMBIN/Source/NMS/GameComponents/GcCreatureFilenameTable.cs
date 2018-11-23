using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD3A2D6582C011CE1)]
    public class GcCreatureFilenameTable : NMSTemplate
    {
        public List<GcCreatureFilename> Table;
    }
}

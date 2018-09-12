using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8BE96E739B255AA3)]
    public class GcCreatureFilenameTable : NMSTemplate
    {
        public List<GcCreatureFilename> Table;
    }
}

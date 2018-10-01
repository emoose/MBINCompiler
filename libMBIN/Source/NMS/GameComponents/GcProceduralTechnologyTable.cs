using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x296F60165581305, Broken = true)]
    public class GcProceduralTechnologyTable : NMSTemplate
    {
        public List<GcProceduralTechnologyData> Table;
    }
}

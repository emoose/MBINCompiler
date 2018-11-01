using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4DDC716531270E61)]
    public class GcProceduralTechnologyTable : NMSTemplate
    {
        public List<GcProceduralTechnologyData> Table;
    }
}

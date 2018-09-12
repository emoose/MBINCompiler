using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7E62C1098D8333C1)]
    public class GcProceduralTechnologyTable : NMSTemplate
    {
        public List<GcProceduralTechnologyData> Table;
    }
}

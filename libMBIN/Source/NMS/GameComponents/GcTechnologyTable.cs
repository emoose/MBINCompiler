using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x92510DFFCE71CA74)]
    public class GcTechnologyTable : NMSTemplate
    {
        public List<GcTechnology> Table;
    }
}

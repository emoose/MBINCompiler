using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x29048923566B58D7)]
    public class GcTechnologyTable : NMSTemplate
    {
        public List<GcTechnology> Table;
    }
}

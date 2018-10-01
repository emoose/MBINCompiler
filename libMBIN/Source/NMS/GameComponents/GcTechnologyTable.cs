using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xA33987CC964AAE24, Broken = true)]
    public class GcTechnologyTable : NMSTemplate
    {
        public List<GcTechnology> Table;
    }
}

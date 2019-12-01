using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x74E81D31E31FDDA9, NameHash = 0x7BF27C8F05ED20B7)]
    public class GcTechnologyTable : NMSTemplate
    {
        public List<GcTechnology> Table;
    }
}

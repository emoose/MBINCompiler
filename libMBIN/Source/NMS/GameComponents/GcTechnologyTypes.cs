using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x85060E2965A20811, SubGUID = 0x324956CF456BD3E1)]
    public class GcTechnologyTypes : NMSTemplate
    {
        public List<GcTechnology> Technology;
    }
}

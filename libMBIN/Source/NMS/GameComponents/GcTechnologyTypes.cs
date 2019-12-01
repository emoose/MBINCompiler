using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x31ECEA6CE8660938, NameHash = 0x324956CF456BD3E1)]
    public class GcTechnologyTypes : NMSTemplate
    {
        public List<GcTechnology> Technology;
    }
}

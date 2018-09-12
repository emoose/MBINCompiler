using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x0F3CA17CA103F5724)]
    public class GcTechList : NMSTemplate
    {
        public List<NMSString0x10> AvailableTech;
    }
}

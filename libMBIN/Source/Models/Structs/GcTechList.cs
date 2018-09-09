using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x10, GUID = 0x0F3CA17CA103F5724)]
    public class GcTechList : NMSTemplate
    {
        public List<NMSString0x10> AvailableTech;
    }
}

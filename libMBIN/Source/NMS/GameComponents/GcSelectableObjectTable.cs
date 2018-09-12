using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x7EB306AB588C39AB)]
    public class GcSelectableObjectTable : NMSTemplate
    {
        public List<GcSelectableObjectList> Lists;
    }
}

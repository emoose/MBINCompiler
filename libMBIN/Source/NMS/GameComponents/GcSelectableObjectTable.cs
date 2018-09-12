using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7EB306AB588C39AB)]
    public class GcSelectableObjectTable : NMSTemplate
    {
        public List<GcSelectableObjectList> Lists;
    }
}

using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xD292EC640A03C7BF)]
    public class TkResourceFilterList : NMSTemplate
    {
        public List<TkResourceFilterData> Filters;

    }
}

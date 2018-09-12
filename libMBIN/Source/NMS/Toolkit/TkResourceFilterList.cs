using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0D292EC640A03C7BF)]
    public class TkResourceFilterList : NMSTemplate
    {
        public List<TkResourceFilterData> Filters;

    }
}

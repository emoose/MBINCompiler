using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0D0EAD3840328781D)]
    public class GcFrigateTraitTable : NMSTemplate
    {
        public List<GcFrigateTraitData> Traits;
    }
}

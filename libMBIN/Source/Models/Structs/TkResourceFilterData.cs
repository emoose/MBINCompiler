using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0F6AEDCB258E2CFC1)]
    public class TkResourceFilterData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string FilterName;
        public List<NMSString0x20> FilteredResources;

    }
}

using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x773E299A9E36D5F7)]
    public class GcHUDLayerData : NMSTemplate
    {
        public GcHUDComponent Data;
        public List<NMSTemplate> Children;
    }
}

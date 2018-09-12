using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x773E299A9E36D5F7)]
    public class GcHUDLayerData : NMSTemplate
    {
        public GcHUDComponent Data;
        public List<NMSTemplate> Children;
    }
}

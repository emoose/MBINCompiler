using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x9585FA88C7E438B9)]
    public class GcSpawnDensityList : NMSTemplate
    {
        public List<GcSpawnDensity> DensityList;
    }
}

using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x1D8475D6A5DE0D20)]
    public class GcPurchaseableBuildingBlueprints : NMSTemplate
    {
        public List<GcBuildingBlueprint> Table;
        public List<int> GroupMaxItems;
    }
}

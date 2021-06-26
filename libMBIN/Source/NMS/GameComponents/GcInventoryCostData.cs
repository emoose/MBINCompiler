using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x140, GUID = 0x5DC6800722F998DB, NameHash = 0x891585A60DC0D014)]
    public class GcInventoryCostData : NMSTemplate
    {
        [NMS(Size = 0x8, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        public GcInventoryCostDataEntry[] InventoryCostData;

    }
}

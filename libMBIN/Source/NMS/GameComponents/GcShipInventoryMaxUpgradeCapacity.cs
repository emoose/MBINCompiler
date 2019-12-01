using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x20, GUID = 0xCB99DEA09142AA8E, NameHash = 0xC51C8A0A49F892DC)]
    public class GcShipInventoryMaxUpgradeCapacity : NMSTemplate
    {
        [NMS(Size = 0x4)]
        public int[] MaxInventoryCapacity;
        [NMS(Size = 0x4)]
        public int[] MaxTechInventoryCapacity;
    }
}

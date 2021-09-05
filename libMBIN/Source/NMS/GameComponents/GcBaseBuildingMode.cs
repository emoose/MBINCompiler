using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0xBFF5DE124DF5E1F4, NameHash = 0xC3799C08BEEDFEF6)]
    public class GcBaseBuildingMode : NMSTemplate
    {
        // size: 0x4
        public enum BaseBuildingModeEnum { Inactive, Selection, Placement, Browse }
        public BaseBuildingModeEnum BaseBuildingMode;
    }
}

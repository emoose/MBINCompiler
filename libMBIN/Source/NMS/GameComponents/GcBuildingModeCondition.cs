using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0x9BA8DB2D80F3B645, NameHash = 0x307D1ADF8E3AA83B)]
    public class GcBuildingModeCondition : NMSTemplate
    {
        [NMS(Size = 0x4, EnumType = typeof(GcBaseBuildingMode.BaseBuildingModeEnum))]
        public int[] ValidBuildingModes;
    }
}

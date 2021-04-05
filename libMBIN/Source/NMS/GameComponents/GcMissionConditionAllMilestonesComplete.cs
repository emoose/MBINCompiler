using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x0000000000000000, NameHash = 0x88DB4BD2401DF5D)]
    public class GcMissionConditionAllMilestonesComplete : NMSTemplate
    {
        public int ForStage;
    }
}

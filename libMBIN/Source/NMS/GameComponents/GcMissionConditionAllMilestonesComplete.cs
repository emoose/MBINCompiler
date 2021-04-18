using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x63F47300F5DC6ECE, NameHash = 0x088DB4BD2401DF5D)]
    public class GcMissionConditionAllMilestonesComplete : NMSTemplate
    {
        public int ForStage;
    }
}

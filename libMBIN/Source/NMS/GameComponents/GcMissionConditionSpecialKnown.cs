using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0x0000000000000000, NameHash = 0x4F66A082950329D8)]
    public class GcMissionConditionSpecialKnown : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string SpecialID;
    }
}

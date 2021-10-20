using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x110, GUID = 0x81E5D0092B05967A, NameHash = 0xF83A832D3507037F)]
    public class GcMissionSequenceRepairTech : NMSTemplate
    {
        public NMSString0x80 Message;
        public List<GcTechnologyTableEnum> TechsToRepair;
        public NMSString0x80 DebugText;
    }
}

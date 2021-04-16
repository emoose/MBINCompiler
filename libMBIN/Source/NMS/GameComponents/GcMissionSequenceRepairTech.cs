using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x110, GUID = 0xDFFB3F29873D789A, NameHash = 0xF83A832D3507037F)]
    public class GcMissionSequenceRepairTech : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Message;
        public List<GcTechnologyTableEnum> TechsToRepair;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}

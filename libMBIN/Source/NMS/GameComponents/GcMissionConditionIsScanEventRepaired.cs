using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x20, GUID = 0x0000000000000000, NameHash = 0xA601980170B475C0)]
    public class GcMissionConditionIsScanEventRepaired : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Event;
    }
}

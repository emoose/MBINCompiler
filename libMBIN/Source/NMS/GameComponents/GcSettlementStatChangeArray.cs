using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0x1E3E338F7E1C64EA, NameHash = 0x661EFBF46F4B3D78)]
    public class GcSettlementStatChangeArray : NMSTemplate
    {
        public List<GcSettlementStatChange> Stats;
    }
}

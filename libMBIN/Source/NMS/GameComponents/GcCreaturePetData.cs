using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xED482D1696C467CC, NameHash = 0x60B2A2CE8774967D)]
    public class GcCreaturePetData : NMSTemplate
    {
        /* 0x0 */ public List<GcCreaturePetAccessory> AccessorySlots;
    }
}

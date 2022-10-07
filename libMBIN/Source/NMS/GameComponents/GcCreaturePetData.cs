using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8793BF5B5D82BD39, NameHash = 0x60B2A2CE8774967D)]
    public class GcCreaturePetData : NMSTemplate
    {
        /* 0x0 */ public List<GcCreaturePetAccessory> AccessorySlots;
    }
}

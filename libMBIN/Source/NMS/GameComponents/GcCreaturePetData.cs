using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7BBDBFBDD5E044D9, NameHash = 0x2088FF49)]
    public class GcCreaturePetData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCreaturePetAccessory> AccessorySlots;
    }
}

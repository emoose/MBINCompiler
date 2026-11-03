using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBA7EC47DABCD9677, NameHash = 0x3D34159D)]
    public class GcCreaturePetPartHider : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<NMSString0x20A> PartName;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x100 AccessorySlot;
    }
}

using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5D1C6458F4076AD1, NameHash = 0xC7B26C36881B633D)]
    public class GcCreaturePetPartHider : NMSTemplate
    {
        /* 0x000 */ public NMSString0x100 AccessorySlot;
        /* 0x100 */ public List<NMSString0x20A> PartName;
    }
}

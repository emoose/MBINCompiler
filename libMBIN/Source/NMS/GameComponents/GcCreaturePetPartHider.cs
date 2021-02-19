using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x110, GUID = 0x5D1C6458F4076AD1, NameHash = 0xC7B26C36881B633D)]
    public class GcCreaturePetPartHider : NMSTemplate
    {
        [NMS(Size = 0x100)]
        public string AccessorySlot;
        public List<NMSString0x20> PartName;
    }
}

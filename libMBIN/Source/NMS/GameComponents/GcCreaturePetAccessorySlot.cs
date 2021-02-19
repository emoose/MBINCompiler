using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x110, GUID = 0xC282A343C8EACBC7, NameHash = 0x7A3E98EFAB95FF53)]
    public class GcCreaturePetAccessorySlot : NMSTemplate
    {
        [NMS(Size = 0x100)]
        public string AttachLocator;
        [NMS(Size = 0x10)]
        public string AccessoryGroup;
    }
}

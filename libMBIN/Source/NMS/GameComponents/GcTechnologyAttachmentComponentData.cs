using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0x30BE414835A620E, NameHash = 0x7CCA2E6781CC7070)]
    public class GcTechnologyAttachmentComponentData : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> Techs;
        // size: 0x1
        public enum InventoryEnum { Vehicle }
        /* 0x10 */ public InventoryEnum Inventory;
        /* 0x14 */ public bool Inverted;
    }
}

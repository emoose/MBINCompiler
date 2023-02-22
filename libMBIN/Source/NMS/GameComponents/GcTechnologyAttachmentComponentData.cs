using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7168E53F55CDAD62, NameHash = 0x7CCA2E6781CC7070)]
    public class GcTechnologyAttachmentComponentData : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> Techs;
        // size: 0x1
        public enum InventoryEnum {
            Vehicle,
        }
        /* 0x10 */ public InventoryEnum Inventory;
        /* 0x14 */ public bool Inverted;
    }
}

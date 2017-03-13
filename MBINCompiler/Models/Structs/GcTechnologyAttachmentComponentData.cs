using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcTechnologyAttachmentComponentData : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> Techs;

        /* 0x10 */ public int Inventory;
        public string[] InventoryValues()
        {
            return new[] { "Vehicle"};
        }
        /* 0x14 */ public bool Inverted;
    }
}

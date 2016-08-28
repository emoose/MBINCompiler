using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcInventoryContainer : NMSTemplate // 0x20 bytes
    {
        public List<GcInventoryElement> Slots;
        public List<GcInventoryIndex> ValidSlotIndices;
    }
}

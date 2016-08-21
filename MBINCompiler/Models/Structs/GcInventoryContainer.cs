using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcInventoryContainer : NMSTemplate
    {
        public List<GcInventoryElement> Slots;
        public List<GcInventoryIndex> ValidSlotIndices;
    }
}

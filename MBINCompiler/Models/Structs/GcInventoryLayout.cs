using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcInventoryLayout : NMSTemplate
    {
        public int Slots;
        [NMS(Ignore = true)]
        public int EmptyNode1;
        public GcSeed Seed;
        public int Level;
        [NMS(Ignore = true)]
        public int EmptyNode2;
    }
}

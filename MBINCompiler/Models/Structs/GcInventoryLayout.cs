using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcInventoryLayout : NMSTemplate
    {
        public int Slots;
        [NMSAttribute(Ignore = true)]
        public int EmptyNode1;
        public GcSeed Seed;
        public int Level;
        [NMSAttribute(Ignore = true)]
        public int EmptyNode2;
    }
}
